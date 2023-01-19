using Core.Business.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IDoktorTeshisService : IEntityServiceBase<DoktorTeshis>
	{

		List<DoktorTeshis> GetDoktorTeshisByHastaIdAndDoktorId(int hastaId, int doktorId);
		DoktorTeshis DoktorTeshisByHastaIdAndDoktorId(int hastaId, int doktorId); 

	}
} 
