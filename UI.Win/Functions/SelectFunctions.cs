using Common.Enums;
using Model.Entities;
using UI.Win.Show;
using UI.Win.UserControls.Controls;
using System;

namespace UI.Win.Functions
{
	public class SelectFunctions : IDisposable
	{
		#region Variables
		private MyButtonEdit _btnEdit;
		private MyButtonEdit _prmEdit;
		private KartTuru _kartTuru;
		//private OdemeTipi _odemeTipi;
		//private BankaHesapTuru _hesapTuru;
		#endregion

		public void Sec(MyButtonEdit btnEdit)
		{
			_btnEdit = btnEdit;
			SecimYap();
		}

		public void Sec(MyButtonEdit btnEdit, KartTuru kartTuru)
		{
			_btnEdit = btnEdit;
			_kartTuru = kartTuru;
			SecimYap();
		}

		//public void Sec(MyButtonEdit btnEdit, OdemeTipi odemeTipi)
		//{
		//	_btnEdit = btnEdit;
		//	_odemeTipi = odemeTipi;
		//	SecimYap();
		//}

		//public void Sec(MyButtonEdit btnEdit, KartTuru kartTuru, BankaHesapTuru hesapTuru)
		//{
		//	_btnEdit = btnEdit;
		//	_kartTuru = kartTuru;
		//	_hesapTuru = hesapTuru;
		//	SecimYap();
		//}

		public void Sec(MyButtonEdit btnEdit, MyButtonEdit prmEdit)
		{
			_btnEdit = btnEdit;
			_prmEdit = prmEdit;
			SecimYap();
		}

		private void SecimYap()
		{
			//switch (_btnEdit.Name)
			//{
				//Doldurulacak..
			//}
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}
