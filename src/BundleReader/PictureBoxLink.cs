using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace BundleReader
{
	/// <summary>
	/// A standard TextBox control which uses the correct Hand cursor instead of the default pre-Vista cursor used by .NET.
	/// </summary>
	public class PictureBoxLink : PictureBox
	{
		public PictureBoxLink() : base()
		{
			this.SetStyle(ControlStyles.StandardDoubleClick, false);
		}

		protected override void WndProc(ref Message m)
		{
			if (this.Cursor == Cursors.Hand)
			{
				if (m.Msg == NativeMethods.WM_SETCURSOR)
				{
					NativeMethods.SetCursor(NativeMethods.LoadCursor(0, NativeMethods.IDC_HAND));

					m.Result = IntPtr.Zero;
					return;
				}
			}

			base.WndProc(ref m);
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			// Smooth those background images!
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			e.Graphics.InterpolationMode = InterpolationMode.Low;
			e.Graphics.CompositingMode = CompositingMode.SourceOver;
			e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

			base.OnPaintBackground(e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			// Smooth those .. foreground images!
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			e.Graphics.InterpolationMode = InterpolationMode.Low;
			e.Graphics.CompositingMode = CompositingMode.SourceOver;
			e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

			base.OnPaint(e);

			// Smoooooth
		}
	}
}
