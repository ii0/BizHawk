using System;
using System.Windows.Forms;

namespace BizHawk.Client.WinformsCustom
{
	public class TransparentTrackBar : TrackBar
	{
		protected override void OnCreateControl()
		{
			if (!DesignMode)
			{
				SetStyle(ControlStyles.SupportsTransparentBackColor, true);
				if (Parent != null)
					BackColor = Parent.BackColor;
			}

			base.OnCreateControl();
		}
	}
}
