using DevExpress.XtraEditors;
using UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace UI.Win.UserControls.Controls
{
	public class MySimpleButton : SimpleButton, IStatusBarAciklama
	{
		[ToolboxItem(true)]
		public MySimpleButton()
		{
			Appearance.ForeColor = Color.Maroon;
		}
		public string StatusBarAciklama { get; set; }
	}
}
