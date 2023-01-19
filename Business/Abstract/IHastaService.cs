using Core.Business.Abstract;
using Core.Entities.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IHastaService : IEntityServiceBase<Hasta>
	{
		
		List<Hasta> FilterByName(string name);

		List<Hasta> GetHastaWithTc(string Tc);

	}
}
