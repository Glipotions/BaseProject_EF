using Model.Entities.Base;

namespace Business.Interfaces
{
	public interface IBaseGenelBusiness
	{
		bool Insert(BaseEntity entity);
		bool Update(BaseEntity oldEntity, BaseEntity currentEntity);
		string YeniKodVer();
	}
}
