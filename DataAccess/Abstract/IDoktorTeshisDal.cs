using Core.DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
	public interface IDoktorTeshisDal : IEntityRepositoryBase<DoktorTeshis>
	{
		List<DoktorTeshis> GetDoktorTeshisByHastaIdAndDoktorId(Expression<Func<DoktorTeshis, bool>> filter); 

		DoktorTeshis DoktorTeshisByHastaIdAndDoktorId(Expression<Func<DoktorTeshis, bool>> filter); 

	} 
}
