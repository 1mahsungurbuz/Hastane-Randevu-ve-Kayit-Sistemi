using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.Eframework
{
	public class EfSekreterDal : EfEntityRepositoryBase<Sekreter, MyProjectContext>, ISekreterDal
	{
		public Sekreter GetLoginForSekreter(Expression<Func<Sekreter, bool>> filter)
		{
			using (MyProjectContext context = new MyProjectContext())
			{

				return context.Sekreterler.SingleOrDefault(filter);

			}
		}

		public Sekreter GetSekreterWithTc(Expression<Func<Sekreter, bool>> filter)
		{
			using (MyProjectContext context = new MyProjectContext())
			{
				return context.Sekreterler.SingleOrDefault(filter);
			}
		}
	}
}
