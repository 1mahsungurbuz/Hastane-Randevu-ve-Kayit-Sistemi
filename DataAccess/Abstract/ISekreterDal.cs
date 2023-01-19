using Core.DataAccess.Abstract;
using DataAccess.Concrete.Eframework;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
	public interface ISekreterDal : IEntityRepositoryBase<Sekreter> 
	{
		public Sekreter GetLoginForSekreter(Expression<Func<Sekreter, bool>> filter);

		public Sekreter GetSekreterWithTc(Expression<Func<Sekreter, bool>> filter);

	}
}
