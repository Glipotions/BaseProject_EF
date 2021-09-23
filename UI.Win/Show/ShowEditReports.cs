using System;
using System.Windows.Forms;
using Common.Enums;
using UI.Win.Functions;
using UI.Win.Reports.FormReports.Base;

namespace UI.Win.Show
{
    public class ShowEditReports<TForm> where TForm : BaseRapor
    {
        public static void ShowEditReport(KartTuru kartTuru)
        {
			//if (!kartTuru.YetkiKontrolu(YetkiTuru.Gorebilir)) return;

			var frm = (TForm)Activator.CreateInstance(typeof(TForm));
            frm.MdiParent = Form.ActiveForm;

            frm.Yukle();
            frm.Show();
        }
    }
}