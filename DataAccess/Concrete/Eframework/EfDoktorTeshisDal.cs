using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.Eframework
{
	public class EfDoktorTeshisDal : EfEntityRepositoryBase<DoktorTeshis, MyProjectContext>, IDoktorTeshisDal
	{
		public List<DoktorTeshis> GetDoktorTeshisByHastaIdAndDoktorId(Expression<Func<DoktorTeshis, bool>> filter)
		{
			using (MyProjectContext context = new MyProjectContext()) 
			{
				return context.Set<DoktorTeshis>().Where(filter).ToList();

			}
		}

		public DoktorTeshis DoktorTeshisByHastaIdAndDoktorId(Expression<Func<DoktorTeshis, bool>> filter)
		{
			using (MyProjectContext context = new MyProjectContext())
			{
				return context.DoktorTeshisleri.OrderBy(s => s.TeshisTarih).Last(filter);

			}
		}
	}
}
