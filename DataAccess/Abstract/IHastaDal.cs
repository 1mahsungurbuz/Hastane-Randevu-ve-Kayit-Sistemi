using Core.DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
	public interface IHastaDal : IEntityRepositoryBase<Hasta> 
	{

		List<Hasta> GetHastaWithTc(Expression<Func<Hasta,bool>> Tc);

	}
}

