using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlistCS;
using System.Linq;
using System.Text.RegularExpressions;

namespace BundleReader
{
	[Flags]
	public enum Architecture
	{
		None = 0,
		Intel32 = 1,
		Intel64 = 2,
		PPC32 = 4,
		PPC64 = 8,
		ClassicOS = 16,
	}

	public class Bundle
	{
		private static string[] versionStringFluff = { " -", "Demo", " for", " by", " stable",
			".Copy", " (build", " (Build", " [build", " [Build", "Universal", ".release", " build", "build",
			" Release", " release", " PowerPC", " Intel", "Int", ".app", " Mac", "G",
			" (", ", ", "x86_", "©", "V", "V ", "v", "v " };

		private DirectoryInfo bundleDirectory;
		private FileInfo plistFile;
		private Dictionary<string, object> plist;
		private FileInfo icnsFile;
		private string bundleExecutable;
		private bool isValid = true;

		private bool guessedMinOsVersion = false;
		private string displayName;
		private string mudVersion;
		private string bundleVersion;
		private string shortVersion;
		private string getInfoVersion;
		private string buildVersion;
		private string localIconSize;
		private List<int> serverIcons;
		private string bundleId;
		private string sparkleUrl;
		private Architecture architecture;
		private string minOSVersion;
		private int productId;
		private string serverVersion;
		private string autoMatchUrl;
		private List<string> localLanguages;
		private List<string> serverLanguages;
		private string expectedIcnsFileName;
		private FileInfo pngIconFile;

		#region Properties
		public bool IsValid
		{
			get { return this.isValid; }
		}

		public DirectoryInfo AppFile
		{
			get { return this.bundleDirectory; }
			private set { this.bundleDirectory = value; }
		}

		public FileInfo PlistFile
		{
			get { return this.plistFile; }
			private set { this.plistFile = value; }
		}

		public Dictionary<string, object> Plist
		{
			get { return this.plist; }
			private set { this.plist = value; }
		}

		public string FileName
		{
			get { return this.bundleDirectory.Name; }
		}

		public string DisplayName
		{
			get { return this.displayName; }
			set { this.displayName = value.Trim(); }
		}

		public string MUDVersion
		{
			get { return this.mudVersion; }
		}

		public string BundleVersion
		{
			get { return this.bundleVersion; }
			set { this.bundleVersion = value; }
		}

		public string ShortVersion
		{
			get { return this.shortVersion; }
			set { this.shortVersion = value; }
		}

		public string GetInfoVersion
		{
			get { return this.getInfoVersion; }
			set { this.getInfoVersion = value; }
		}

		public string BuildVersion
		{
			get { return this.buildVersion; }
			set { this.buildVersion = value; }
		}

		public string LocalIconSize
		{
			get { return this.localIconSize; }
		}

		public List<int> ServerIcons
		{
			get { return this.serverIcons; }
		}

		public string BundleId
		{
			get { return this.bundleId; }
			set { this.bundleId = value; }
		}

		public string SparkleUrl
		{
			get { return this.sparkleUrl; }
			set { this.sparkleUrl = value; }
		}

		public Architecture Architecture
		{
			get { return this.architecture; }
			set { this.architecture = value; }
		}

		public string MinOSVersion
		{
			get { return this.minOSVersion; }
			set { this.minOSVersion = value; }
		}

		public int MUProductId
		{
			get { return this.productId; }
			set { this.productId = value; }
		}

		public string ServerVersion
		{
			get { return this.serverVersion; }
			set { this.serverVersion = value; }
		}

		public string AutoMatchUrl
		{
			get { return this.autoMatchUrl; }
			set { this.autoMatchUrl = value; }
		}

		public List<string> LocalLanguages
		{
			get { return this.localLanguages; }
		}

		public List<string> ServerLanguages
		{
			get { return this.serverLanguages; }
		}

		public FileInfo PngIconFile
		{
			get { return this.pngIconFile; }
			private set { this.pngIconFile = value; }
		}

		public Boolean GuessedMinOsVersion
		{
			get { return this.guessedMinOsVersion; }
		}
		#endregion

		public override string ToString()
		{
			return String.Format("Bundle: {0}", this.FileName);
		}

		public Bundle(string fileName)
		{
			if (!Directory.Exists(fileName))
			{
				Debug.WriteLine("Unable to locate directory \"" + fileName + "\".");
				this.isValid = false;
			}

			// TODO: Exceptions for DirectoryInfo constructor
			this.bundleDirectory = new DirectoryInfo(fileName);
			this.plistFile = GetPlistFile();

			if (this.plistFile != null)
			{
				try
				{
					this.plist = (Dictionary<string, object>)PlistCS.Plist.readPlist(this.plistFile.FullName);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

				ReadPlistData();
				this.localLanguages = GetLanguages();
				this.icnsFile = GetIcnsFile();
				this.pngIconFile = ConvertIcnsToPng();
				this.localIconSize = GetLocalIconSize();
			}
		}

		private Architecture GetArchitecture()
		{
			// Get Contents folder:
			List<DirectoryInfo> subDirectories = new List<DirectoryInfo>(bundleDirectory.GetDirectories());
			DirectoryInfo contentsFolder = null;
			bool hasContentsDirectory = false;

			foreach (DirectoryInfo di in subDirectories)
			{
				if (di.Name.EqualsIgnoreCase("Contents"))
				{
					hasContentsDirectory = true;
					contentsFolder = di;
					break;
				}
			}

			if (!hasContentsDirectory)
			{
				throw new DirectoryNotFoundException("Unable to locate bundle's Contents folder.");
			}

			// Get MacOS folder:
			subDirectories = new List<DirectoryInfo>(contentsFolder.GetDirectories());
			DirectoryInfo macOSFolder = null;
			bool hasMacOSDirectory = false;

			foreach (DirectoryInfo directoryInfo in subDirectories)
			{
				if (directoryInfo.Name.EqualsIgnoreCase("MacOS"))
				{
					hasMacOSDirectory = true;
					macOSFolder = directoryInfo;
					break;
				}
			}

			if (!hasMacOSDirectory)
			{
				throw new DirectoryNotFoundException("Unable to locate bundle's MacOS folder.");
			}

			// Get binary:
			List<FileInfo> files = new List<FileInfo>(macOSFolder.GetFiles());
			FileInfo binaryFile = null;

			foreach (FileInfo fileInfo in files)
			{
				// Check for executable file indicated by CFBundleExecutable:
				if (!String.IsNullOrEmpty(this.bundleExecutable) && (fileInfo.Name.Contains(this.bundleExecutable)))
				{
					binaryFile = fileInfo;
					break;
				}

				// Check for executable file indicated by CFBundleDisplayName:
				if (!String.IsNullOrEmpty(this.displayName) && fileInfo.Name.Contains(this.displayName))
				{
					binaryFile = fileInfo;
					break;
				}

				// Otherwise, check for executable file named after the bundle itself:
				if (fileInfo.Name.EqualsIgnoreCase(this.FileName.Remove(this.FileName.LastIndexOf('.'), this.FileName.Length - this.FileName.LastIndexOf('.'))))
				{
					binaryFile = fileInfo;
					break;
				}
			}

			// Unable to locate a binary file:
			if (binaryFile == null)
			{
				throw new FileNotFoundException("Unable to locate bundle's binary.");
			}

			/* A Mach-O fat binary's architecture is a combination of one or
			 * more of the following architecture/bitness pairs:
			 * 
			 *		1. Intel   32-bit	->	Intel32	->	i386
			 *		2. Intel   64-bit	->	Intel64	->	x86_64
			 *		3. PowerPC 32-bit	->	PPC32	->	ppc
			 *		4. PowerPC 64-bit	->	PPC64	->	ppc64
			 *		
			 * If a binary does not fall into the above categories, it is either a 
			 * Classic OS binary or a non-native (Java) bundle, and is thus out
			 * of BundleReader's scope.
			 * 
			 * We'll use lipo to determine which pairs the bundle's binary contains.
			 */

			// Invoke lipo to check the binary's architecture(s):
			string lipoExecutable = Path.Combine(Application.StartupPath, "utils", "lipo", "lipo.exe");

			if (!File.Exists(lipoExecutable))
			{
				throw new DirectoryNotFoundException("Unable to locate lipo. Checked path: \"" + lipoExecutable + "\".");
			}

			string lipoDirectory = new FileInfo(lipoExecutable).Directory.FullName;

			ProcessStartInfo startInfo = new ProcessStartInfo(lipoExecutable, String.Format(" -info \"{0}\"", binaryFile.FullName));
			startInfo.WorkingDirectory = lipoDirectory;
			startInfo.UseShellExecute = false;
			startInfo.CreateNoWindow = true;
			startInfo.RedirectStandardOutput = true;
			startInfo.WindowStyle = ProcessWindowStyle.Hidden;

			Process lipoProcess = new Process();
			lipoProcess.StartInfo = startInfo;

			lipoProcess.Start();
			lipoProcess.WaitForExit(1000);
			string output = string.Empty;

			using (StreamReader reader = lipoProcess.StandardOutput)
			{
				output = reader.ReadToEnd();
			}

			if (string.IsNullOrEmpty(output))
			{
				return Architecture.None;
			}
			
			// Strip descriptive text:
			output = output.Remove(0, output.LastIndexOf(':') + 1).Trim();
			string[] tokens = output.Split(' ');
			Architecture architecture = Architecture.None;

			Debug.WriteLine("lipo: " + output);

			// Parse the output from lipo and determine the binary's architecture(s):
			foreach (string token in tokens)
			{
				if (token.EqualsIgnoreCase("i386"))
				{
					architecture |= Architecture.Intel32;
				}
				else if (token.EqualsIgnoreCase("x86_64"))
				{
					architecture |= Architecture.Intel64;
				}
				else if (token.StartsWith("ppc", StringComparison.OrdinalIgnoreCase))
				{
					// This handles ppc, ppc64, ppc7400, ppc7450, etc.
					if (token.EqualsIgnoreCase("ppc64"))
					{
						architecture |= Architecture.PPC64;
					}
					else
					{
						architecture |= Architecture.PPC32;
					}
				}
			}

			return architecture;
		}

		private string GetLocalIconSize()
		{
			int size = 0;

			if (this.pngIconFile != null)
			{
				using (Image icon = Image.FromFile(this.pngIconFile.FullName))
				{
					size = icon.Size.Width;
				}

				return size.ToString();
			}

			return size == 0 ? "-" : size.ToString();
		}

		private FileInfo GetIcnsFile()
		{
			// Get Contents folder:
			List<DirectoryInfo> subDirectories = new List<DirectoryInfo>(bundleDirectory.GetDirectories());
			DirectoryInfo contentsDirectoryInfo = null;
			bool hasContentsDirectory = false;

			foreach (DirectoryInfo directoryInfo in subDirectories)
			{
				if (directoryInfo.Name.EqualsIgnoreCase("Contents"))
				{
					hasContentsDirectory = true;
					contentsDirectoryInfo = new DirectoryInfo(directoryInfo.FullName);
				}
			}

			if (!hasContentsDirectory)
			{
				throw new DirectoryNotFoundException("Unable to locate bundle's Contents folder.");
			}

			// Get Resources folder:
			subDirectories = new List<DirectoryInfo>(contentsDirectoryInfo.GetDirectories());
			DirectoryInfo resourcesDirectoryInfo = null;
			bool hasResourcesDirectory = false;

			foreach (DirectoryInfo directoryInfo in subDirectories)
			{
				if (directoryInfo.Name.EqualsIgnoreCase("Resources"))
				{
					hasResourcesDirectory = true;
					resourcesDirectoryInfo = new DirectoryInfo(directoryInfo.FullName);
					break;
				}
			}

			if (!hasResourcesDirectory)
			{
				throw new DirectoryNotFoundException("Unable to locate bundle's Resources folder.");
			}

			List<FileInfo> icnsFiles = new List<FileInfo>(resourcesDirectoryInfo.GetFiles("*.icns"));
			FileInfo icnsFileInfo = null;

			if (icnsFiles.Count > 0)
			{
				// Attempt to match an icns file to CFBundleIconFile:
				foreach (FileInfo fileInfo in icnsFiles)
				{
					if (fileInfo.Name.EqualsIgnoreCase(this.expectedIcnsFileName))
					{
						icnsFileInfo = fileInfo;
						break;
					}
				}

				// Otherwise, look for an icns file with the bundle's name:
				foreach (FileInfo fileInfo in icnsFiles)
				{
					if (fileInfo.Name.EqualsIgnoreCase(this.expectedIcnsFileName + ".icns"))
					{
						icnsFileInfo = fileInfo;
						break;
					}
				}
			}

			return icnsFileInfo;
		}

		private FileInfo ConvertIcnsToPng()
		{
			if (this.icnsFile != null)
			{
				string nConvertPath = Path.Combine(Application.StartupPath, "utils", "nconvert", "nconvert.exe");
				string pngIconPath = Application.StartupPath + @"\icon.png";

				if (!File.Exists(nConvertPath))
				{
					throw new DirectoryNotFoundException("Unable to locate \"" + nConvertPath + "\".");
				}

				ProcessStartInfo nConvertStartInfo = new ProcessStartInfo(nConvertPath, String.Format(" -out png -o \"{0}\" -overwrite \"{1}\"", pngIconPath, icnsFile.FullName));
				nConvertStartInfo.UseShellExecute = false;
				nConvertStartInfo.CreateNoWindow = true;
				nConvertStartInfo.RedirectStandardOutput = true;
				nConvertStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

				Process nConvertProcess = new Process();
				nConvertProcess.StartInfo = nConvertStartInfo;

				nConvertProcess.Start();
				nConvertProcess.WaitForExit(5000);

				if (!File.Exists(pngIconPath))
				{
					throw new FileNotFoundException("nConvert process failed: Unable to locate \"" + pngIconPath + "\".");
				}

				return new FileInfo(pngIconPath);
			}

			return null;
		}

		private FileInfo GetPlistFile()
		{
			List<DirectoryInfo> subDirectories = new List<DirectoryInfo>(bundleDirectory.GetDirectories());
			DirectoryInfo contentsDirectoryInfo = null;
			bool hasContentsDirectory = false;

			foreach (DirectoryInfo directoryInfo in subDirectories)
			{
				if (directoryInfo.Name.EqualsIgnoreCase("Contents"))
				{
					hasContentsDirectory = true;
					contentsDirectoryInfo = new DirectoryInfo(directoryInfo.FullName);
				}
			}

			// TODO: Widgets don't have a Contents folder. Their Info.plist file is directly inside the .wdgt directory... sometimes.

			if (!hasContentsDirectory)
			{
				Debug.WriteLine("Unable to locate bundle's Contents folder.");
				this.isValid = false;
				return null;
			}

			List<FileInfo> contentsFiles = new List<FileInfo>(contentsDirectoryInfo.GetFiles());
			FileInfo plistFileInfo = null;

			foreach (FileInfo fileInfo in contentsFiles)
			{
				if (fileInfo.Name.EqualsIgnoreCase("Info.plist"))
				{
					plistFileInfo = new FileInfo(fileInfo.FullName);
					break;
				}
			}

			if (!plistFileInfo.Exists)
			{
				Debug.WriteLine("Unable to locate bundle's Info.plist file.");
				this.isValid = false;
				return null;
			}

			return plistFileInfo;
		}

		private string GetField(string key, string defaultValue = "-")
		{
			if (String.IsNullOrEmpty(key))
			{
				throw new ArgumentNullException("key");
			}

			if (plist == null || plist.Count == 0)
			{
				throw new InvalidOperationException("Unable to read from a null or empty property list.");
			}

			object field;
			this.plist.TryGetValue(key, out field);

			return (field as string) ?? defaultValue;
		}

		private void ReadPlistData()
		{
			this.DisplayName = GetField("CFBundleDisplayName", "?");
			this.bundleExecutable = GetField("CFBundleExecutable", this.displayName);
			this.BundleVersion = GetField("CFBundleVersion");
			this.ShortVersion = GetField("CFBundleShortVersionString");
			this.GetInfoVersion = GetField("CFBundleGetInfoString");
			this.BuildVersion = GetField("CFBuildVersion");
			this.BundleId = GetField("CFBundleIdentifier");
			this.SparkleUrl = GetField("SUFeedURL");
			this.Architecture = GetArchitecture();
			this.MinOSVersion = GetField("LSMinimumSystemVersion", "?");
			this.expectedIcnsFileName = GetField("CFBundleIconFile");
			// MUProductID
			// ServerVersion
			// AutoMatchUrl
			// ServerLanguages

			if (!String.IsNullOrEmpty(this.expectedIcnsFileName)
				&& !this.expectedIcnsFileName.EndsWith(".icns", StringComparison.CurrentCultureIgnoreCase))
			{
				this.expectedIcnsFileName += ".icns";
			}

			// Trim trailing .0 from min. OS version:
			if (this.minOSVersion.EndsWith(".0"))
			{
				this.minOSVersion = this.minOSVersion.Remove(this.minOSVersion.Length - 2, 2);
			}

			// If CFBundleDisplayName is not present, use CFBundleName as a fallback:
			if (this.displayName.EqualsIgnoreCase("?"))
			{
				this.displayName = GetField("CFBundleName", "?");
				if (!this.displayName.EqualsIgnoreCase("?"))
				{
					Debug.WriteLine("Using CFBundleName name for Display Name");
				}
			}

			// If CFBundleName is not present, fallback to the bundle directory name with the extension removed:
			if (this.displayName.EqualsIgnoreCase("?"))
			{
				this.displayName = this.bundleDirectory.Name.Remove(this.bundleDirectory.Name.LastIndexOf('.'), this.bundleDirectory.Name.Length - this.bundleDirectory.Name.LastIndexOf('.'));
				Debug.WriteLine("Using bundle file's name for Display Name");
			}

			// Finally, determine version MUD will use:
			this.mudVersion = DetermineMudVersion();
		}

		private string DetermineMudVersion()
		{
			// MUDV appears to only examine CFBundleVersion and CFBundleShortVersionString (MUApp#getLocalVersion)
			// starting with CFBundleShortVersionString.
			string version = this.shortVersion;

			// If CFBundleShortVersionString doesn't contain any numbers, MUDV uses CFBundleVersion. If CFBundleVersion
			// doesn't contain any numbers, then there's probably no useful version info at all.
			if (!string.IsNullOrEmpty(version))
			{
				if (!version.Any(char.IsDigit))
				{
					version = this.bundleVersion;
					
					if (!version.Any(char.IsDigit))
					{
						version = "-";
					}
				}
			}

			// MUDV then checks to see whether CFBundleVersion contains CFBundleShortVersionString. If so, MUDV
			// will use CFBundleVersion provided it is sufficiently longer than CFBundleShortVersionString.
			if (this.bundleVersion.Contains(version)
				&& this.bundleVersion.Length > version.Length
				&& this.bundleVersion.Length <= version.Length + 6)
			{
				version = this.bundleVersion;
			}

			// Trim:
			version = version.Trim();

			// MUDV then cleans the version string:
			foreach (string item in versionStringFluff)
			{
				if (version.Contains(item))
				{
					if (version.IndexOf(item) > 0)
					{
						version = Regex.Replace(version, Regex.Escape(item) + ".*", string.Empty).Trim();
					}
					else
					{
						version = version.Replace(item, string.Empty).Trim();
					}
				}
			}

			return version;
		}

		private List<string> GetLanguages()
		{
			// Get Contents folder:
			List<DirectoryInfo> subDirectories = new List<DirectoryInfo>(bundleDirectory.GetDirectories());
			DirectoryInfo contentsFolder = null;
			bool hasContents = false;

			foreach (DirectoryInfo di in subDirectories)
			{
				if (di.Name.EqualsIgnoreCase("Contents"))
				{
					hasContents = true;
					contentsFolder = new DirectoryInfo(di.FullName);
					break;
				}
			}

			if (!hasContents)
			{
				throw new DirectoryNotFoundException("Unable to locate bundle's Contents folder.");
			}

			// Get Resources folder:
			subDirectories = new List<DirectoryInfo>(contentsFolder.GetDirectories());
			DirectoryInfo resourcesFolder = null;
			bool hasResources = false;

			foreach (DirectoryInfo di in subDirectories)
			{
				if (di.Name.EqualsIgnoreCase("Resources"))
				{
					hasResources = true;
					resourcesFolder = new DirectoryInfo(di.FullName);
					break;
				}
			}

			if (!hasResources)
			{
				throw new DirectoryNotFoundException("Unable to locate bundle's Resources folder.");
			}

			// Find all .lproj folders:
			subDirectories = new List<DirectoryInfo>(resourcesFolder.GetDirectories());
			List<string> languages = new List<string>();

			foreach (DirectoryInfo di in subDirectories)
			{
				if (di.Extension.EqualsIgnoreCase(".lproj"))
				{
					string language = di.Name.Split(new char[] { '.' })[0];

					if (language.EqualsIgnoreCase("English"))
						language = "en";

					if (!language.EqualsIgnoreCase("base"))
						languages.Add(language);
				}
			}


			return languages;
		}
	}

	public static class StringExtensions
	{
		/// <summary>
		/// Determines whether this string and a specified System.String object have the same value using an OrdinalIgnoreCase comparison.
		/// </summary>
		/// <param name="original">The string to test against.</param>
		/// <param name="value">The string to compare to this instance.</param>
		/// <returns>True if the strings are equal; false otherwise.</returns>
		public static bool EqualsIgnoreCase(this string original, string value)
		{
			return original.Equals(value, StringComparison.OrdinalIgnoreCase);
		}

		public static string[] Split(this string original, string separator)
		{
			if (separator.Length > 1)
			{
				throw new ArgumentException("separator must be a single-character string", "separator");
			}

			if (original == null)
			{
				throw new ArgumentNullException(original);
			}

			return original.Split(new char[] { separator[0] });
		}

		public static string[] Split(this string original, char separator)
		{
			if (original == null)
			{
				throw new ArgumentNullException(original);
			}

			return original.Split(new char[] { separator });
		}
	}
}
