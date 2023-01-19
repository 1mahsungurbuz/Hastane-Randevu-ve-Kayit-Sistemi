using Core.Business.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ITahlilDetayService :IEntityServiceBase<TahlilDetay>
	{
		List<TahlilDetay> GetAllTahlil(int TahlilId);

		List<TahlilDetay> GetTahlilDetayByHastaIdAndTahlilId(int hastaId,int tahlilId);
	}
}
