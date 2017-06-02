using System;
using System.Runtime.InteropServices;

namespace BundleReader
{
	public static class NativeMethods
	{
		public const int WM_SETCURSOR	= 0x0020;
		public const int IDC_HAND		= 32649;
		public const int IDC_IBEAM		= 32513;

		[DllImport("user32.dll")]
		private static extern bool HideCaret(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern int LoadCursor(int hInstance, int lpCursorName);

		[DllImport("user32.dll")]
		public static extern int SetCursor(int hCursor);

		public static void HideCaret(TextBoxPlus textbox)
		{
			HideCaret(textbox.Handle);
		}
	}
}
