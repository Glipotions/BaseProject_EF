using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Windows.Forms;

namespace UI.Win.Functions
{
	public static class SelectRepositoryFunctions
	{
		private static GridView _tablo;
		private static ControlNavigator _navigator;
		private static RepositoryItemButtonEdit _butonEdit;
		private static GridColumn _idColumn;
		private static GridColumn _nameColumn;
		private static GridColumn _prmIdColumn;
		private static GridColumn _prmNameColumn;

		private static void RemoveEvent()
		{
			if (_butonEdit == null) return;

			_butonEdit.ButtonClick -= ButtonEdit_ButtonClick;
			_butonEdit.KeyDown -= ButtonEdit_KeyDown;
			_butonEdit.DoubleClick -= ButtonEdit_DoubleClick;

			_tablo.KeyDown -= Tablo_KeyDown;
		}

		public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn)
		{
			RemoveEvent();

			_tablo = tablo;
			_navigator = navigator;
			_butonEdit = buttonEdit;
			_idColumn = idColumn;
			_nameColumn = nameColumn;

			_butonEdit.ButtonClick += ButtonEdit_ButtonClick;
			_butonEdit.KeyDown += ButtonEdit_KeyDown;
			_butonEdit.DoubleClick += ButtonEdit_DoubleClick;

			_tablo.KeyDown += Tablo_KeyDown;
		}

		public static void Sec(this GridColumn nameColumn, GridView tablo, ControlNavigator navigator, RepositoryItemButtonEdit buttonEdit, GridColumn idColumn, GridColumn prmIdColumn, GridColumn prmNameColumn)
		{
			RemoveEvent();

			_tablo = tablo;
			_navigator = navigator;
			_butonEdit = buttonEdit;
			_idColumn = idColumn;
			_nameColumn = nameColumn;

			_prmIdColumn = prmIdColumn;
			_prmNameColumn = prmNameColumn;

			_butonEdit.ButtonClick += ButtonEdit_ButtonClick;
			_butonEdit.KeyDown += ButtonEdit_KeyDown;
			_butonEdit.DoubleClick += ButtonEdit_DoubleClick;

			_tablo.KeyDown += Tablo_KeyDown;
		}

		private static void ButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			SecimYap();
		}

		private static void ButtonEdit_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Delete when e.Control && e.Shift:
					_tablo.SetFocusedRowCellValue(_idColumn, null);
					_tablo.SetFocusedRowCellValue(_nameColumn, null);
					_navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
					break;

				case Keys.F4:
				case Keys.Down when e.Alt:
					SecimYap();
					break;
			}
		}

		private static void ButtonEdit_DoubleClick(object sender, EventArgs e)
		{
			SecimYap();
		}

		private static void Tablo_KeyDown(object sender, KeyEventArgs e)
		{
			if (_tablo.FocusedColumn.ColumnEdit == null) return;

			var type = _tablo.FocusedColumn.ColumnEdit.GetType();
			if (type != typeof(RepositoryItemButtonEdit)) return;

			switch (e.KeyCode)
			{
				case Keys.Delete when e.Control && e.Shift:
					_tablo.SetFocusedRowCellValue(_idColumn, null);
					_tablo.SetFocusedRowCellValue(_nameColumn, null);
					_navigator.Buttons.DoClick(_navigator.Buttons.EndEdit);
					break;

				case Keys.F4:
				case Keys.Down when e.Alt:
					SecimYap();
					break;
			}
		}

		private static void SecimYap()
		{
			//switch (_butonEdit.Name)
			//{
			//	//Doldurulacak
			//}
		}
	}
}