using Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Interfaces
{
	public interface IBaseHareketSelectBusiness<TEntity>
	{
		IEnumerable<BaseHareketEntity> List(Expression<Func<TEntity, bool>> filter);
	}
}