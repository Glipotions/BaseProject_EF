using DevExpress.XtraEditors;
using UI.Win.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace UI.Win.UserControls.Controls
{
	public class MyMemoEdit : MemoEdit, IStatusBarAciklama
	{
		[ToolboxItem(true)]
		public MyMemoEdit()
		{
			Properties.Appearance.BackColor = Color.LightCyan;
			Properties.MaxLength = 500;
		}
		public override bool EnterMoveNextControl { get; set; } = true;
		public string StatusBarAciklama { get; set; } = "Açıklama Giriniz.";
	}
}
