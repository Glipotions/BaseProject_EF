using DevExpress.XtraEditors;
using UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace UI.Win.UserControls.Controls
{
	[ToolboxItem(true)]
	public class MyTextEdit : TextEdit, IStatusBarAciklama
	{

		public MyTextEdit()
		{
			Properties.AppearanceFocused.BackColor = Color.LightCyan;
			Properties.MaxLength = 50;
		}

		public string StatusBarAciklama { get; set; }
	}
}
