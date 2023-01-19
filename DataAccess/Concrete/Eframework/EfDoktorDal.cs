using Core.DataAccess.Concrete;
using Core.Entities.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.Eframework
{
	public class EfDoktorDal : EfEntityRepositoryBase<Doktor, MyProjectContext>, IDoktorDal
	{
		
		public List<Doktor> GetDoktorByBransId(Expression<Func<Doktor, bool>> filter)
		{
			using (MyProjectContext context = new MyProjectContext())
			{


				return filter == null ? context.Set<Doktor>().ToList() : context.Set<Doktor>().Where(filter).ToList();



			}

		}

	

		public Doktor GetLoginForDoktor(Expression<Func<Doktor,bool>> filter)
		{
			using (MyProjectContext context=new MyProjectContext())
			{

				return  context.Doktorlar.SingleOrDefault(filter);

			}
		}

		public Doktor GetDoktorWithTc(Expression<Func<Doktor, bool>> Tc)
		{
			using (MyProjectContext context = new MyProjectContext())
			{
				return context.Doktorlar.SingleOrDefault(Tc);

			}
		}
	}
}
