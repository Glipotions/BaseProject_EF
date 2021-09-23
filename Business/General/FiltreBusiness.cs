using Business.Base;
using Business.Interfaces;
using Common.Enums;
using Model.Entities;
using System.Windows.Forms;

namespace Business.General
{
	public class FiltreBusiness : BaseGenelBusiness<Filtre>, IBaseCommonBusiness
	{
		public FiltreBusiness() : base(KartTuru.Filtre) { }
		public FiltreBusiness(Control ctrl) : base(ctrl, KartTuru.Filtre) { }
	}
}