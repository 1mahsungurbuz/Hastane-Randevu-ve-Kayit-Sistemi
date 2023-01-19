using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.Eframework
{
	public class EfTahlilDetayDal : EfEntityRepositoryBase<TahlilDetay, MyProjectContext>, ITahlilDetayDal
	{
		public List<TahlilDetay> GetAllTahlil(Expression<Func<TahlilDetay, bool>> filter)
		{
			using (MyProjectContext context=new MyProjectContext())
			{
				return context.Set<TahlilDetay>().Where(filter).ToList();

			}
		}

		public List<TahlilDetay> GetTahlilByHastaId(Expression<Func<TahlilDetay, bool>> hastaId)
		{
			using (MyProjectContext context = new MyProjectContext())
			{
				return context.Set<TahlilDetay>().Where(hastaId).ToList();

			}
		}
	}
}
