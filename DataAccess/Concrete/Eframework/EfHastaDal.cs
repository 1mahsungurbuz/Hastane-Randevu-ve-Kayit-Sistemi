using Core.DataAccess.Concrete;
using Core.Entities.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.Eframework
{
	public class EfHastaDal : EfEntityRepositoryBase<Hasta, MyProjectContext>, IHastaDal
	{
	


		public List<Hasta> GetHastaWithTc(Expression<Func<Hasta, bool>> Tc)
		{
			using (MyProjectContext context = new MyProjectContext())
			{
				return context.Set<Hasta>().Where(Tc).ToList();

			}
		}

		
	}
}
