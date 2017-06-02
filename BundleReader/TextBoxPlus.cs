using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Drawing;

namespace BundleReader
{
	/// <summary>
	/// A standard TextBox control which uses the correct Hand cursor instead of the default pre-Vista cursor used by .NET.
	/// </summary>
	public class TextBoxPlus : RichTextBox
	{
		public TextBoxPlus() : base()
		{
			this.LinkClicked += (s, e) => Process.Start(this.Text);
		}

		protected override void WndProc(ref Message m)
		{
			if (this.DetectUrls)
			{
				if (m.Msg == NativeMethods.WM_SETCURSOR)
				{
					if (Form.ActiveForm == this.FindForm())
					{
						NativeMethods.SetCursor(NativeMethods.LoadCursor(0, NativeMethods.IDC_HAND));
					}
					else
					{
						NativeMethods.SetCursor(NativeMethods.LoadCursor(0, NativeMethods.IDC_IBEAM));
					}

					m.Result = IntPtr.Zero;
					return;
				}
			}

			base.WndProc(ref m);
		}

		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);

			NativeMethods.HideCaret(this);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			NativeMethods.HideCaret(this);
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);

			NativeMethods.HideCaret(this);
		}

		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);

			NativeMethods.HideCaret(this);
			this.SelectionStart = 0;
			this.SelectionLength = 0;
		}
	}
}
