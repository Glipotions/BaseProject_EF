using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraTabbedMdi;
using Business.Functions;
using Common.Message;
using UI.Win.Show;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Win.GeneralForms
{
	public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public static string KurumAdi;
		public static long KullaniciId;
		public static string KullaniciAdi;
		public static long KullaniciRolId;
		public static string KullaniciRolAdi;
		public static long DonemId;
		public static string DonemAdi = "Dönem Bilgisi Bekleniyor...";
		public static long SubeId;
		public static string SubeAdi = "Şube Bilgisi Bekleniyor...";
		public static List<long> YetkiliOlunanSubeler;


		//public static DonemParametre DonemParametre;
		//public static KullaniciParametreS KullaniciParametreleri = new KullaniciParametreS();
		//public static IEnumerable<RolYetkileriL> RolYetkileri;

		public AnaForm()
		{
			InitializeComponent();
			EventsLoad();

			//imgArkaPlanResmi.EditValue = KullaniciParametreleri.ArkaPlanResim;
		}

		private void EventsLoad()
		{
			Load += AnaForm_Load;
			Closing += AnaForm_Closing;
			KeyDown += Control_KeyDown;

			foreach (var item in ribbonControl.Items)
			{
				switch (item)
				{
					case SkinRibbonGalleryBarItem btn:
						btn.GalleryItemClick += GalleryItem_GalleryItemClick;
						break;
					case SkinPaletteRibbonGalleryBarItem btn:
						btn.GalleryItemClick += GalleryItem_GalleryItemClick;
						break;

					case BarButtonItem btn:
						btn.ItemClick += Butonlar_ItemClick;
						break;

				}
			}

			foreach (Control control in Controls)
				control.KeyDown += Control_KeyDown;


			xtraTabbedMdiManager.PageAdded += XtraTabbedMdiManager_PageAdded;
			xtraTabbedMdiManager.PageRemoved += XtraTabbedMdiManager_PageRemoved;
		}

		//private void SubeDonemSecimi(bool subeSecimButonunaBasildi)
		//{
		//	// Şubeyi seçme yeri, parametreleri gönderiyoruz.
		//	ShowEditForms<SubeDonemSecimiEditForm>.ShowDialogEditForm(null, KullaniciId, subeSecimButonunaBasildi,
		//		SubeId, DonemId);
		//	barDonem.Caption = DonemAdi;
		//	btnSube.Caption = SubeAdi;
		//}

		private void AnaForm_Load(object sender, System.EventArgs e)
		{
			//barKullanici.Caption = $@"{KullaniciAdi} ( {KullaniciRolAdi} )";
			//barKurum.Caption = KurumAdi;
			//SubeDonemSecimi(false); //daha ilk yüklenme aşamasında olduğu için

			//if (DonemParametre == null)
			//{
			//	Messages.HataMesaji("Dönem Parametreleri Girilmemiş. Lütfen Sistem Yöneticinize Başvurunuz.");
			//	Application.ExitThread();
			//	return;
			//}

			//if (!DonemParametre.YetkiKontroluAnlikYapilacak)
			//{
			//	using (var Business = new RolYetkileriBusiness())
			//	{
			//		//Başka bir Kullanım
			//		//Converts.EntityListConvert<RolYetkileriL>(Business.List(x => x.RolId == KullaniciRolId));

			//		RolYetkileri = Business.List(x => x.RolId == KullaniciRolId).EntityListConvert<RolYetkileriL>();
			//	}
			//}
		}

		private void AnaForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (Messages.HayirSeciliEvetHayir("Programdan Çıkmak İstiyor musunuz?", "Çıkış Onayı") == DialogResult.Yes)
				Application.ExitThread();
			else
				e.Cancel = true;
		}

		private void GalleryItem_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
		{
			var gallery = sender as InRibbonGallery;
			if (gallery.OwnerItem.GetType() == typeof(SkinRibbonGalleryBarItem))
				Functions.GeneralFunctions.AppSettingsWrite("Skin", e.Item.Caption);
			else if (gallery.OwnerItem.GetType() == typeof(SkinPaletteRibbonGalleryBarItem))
				Functions.GeneralFunctions.AppSettingsWrite("Palette", e.Item.Caption);
		}

		private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
		{


			
		}

		private void Control_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				Close();
		}

		private void XtraTabbedMdiManager_PageAdded(object sender, MdiTabPageEventArgs e)
		{
			imgArkaPlanResmi.SendToBack();
		}

		private void XtraTabbedMdiManager_PageRemoved(object sender, MdiTabPageEventArgs e)
		{
			if (((XtraTabbedMdiManager)sender).Pages.Count == 0)
				imgArkaPlanResmi.BringToFront();
		}
	}
}