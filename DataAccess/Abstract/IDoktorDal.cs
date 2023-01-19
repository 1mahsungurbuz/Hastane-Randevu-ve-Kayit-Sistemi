using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using DataAccess.Concrete.Eframework;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
	public interface IDoktorDal : IEntityRepositoryBase<Doktor>
	{

		 List<Doktor> GetDoktorByBransId(Expression<Func<Doktor, bool>> filter);

		public Doktor GetLoginForDoktor(Expression<Func<Doktor, bool>> filter);


		public Doktor GetDoktorWithTc(Expression<Func<Doktor, bool>> Tc);


	}
}
