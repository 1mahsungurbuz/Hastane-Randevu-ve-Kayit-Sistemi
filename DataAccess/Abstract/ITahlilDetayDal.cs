using Core.DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
	public interface ITahlilDetayDal : IEntityRepositoryBase<TahlilDetay>  
	{
		List<TahlilDetay> GetAllTahlil(Expression<Func<TahlilDetay, bool>> filter);
		List<TahlilDetay> GetTahlilByHastaId(Expression<Func<TahlilDetay, bool>> hastaId);
		
	}
}
