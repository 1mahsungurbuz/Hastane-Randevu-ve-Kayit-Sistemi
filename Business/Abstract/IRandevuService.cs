using Core.Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
	public interface IRandevuService : IEntityServiceBase<Randevu>
	{
		
		public List<Randevu> GetAll(int doktorId);

		List<BolumAndHasta> GetBolumAdiVeHastaSayisi();
		List<DoktorAndHasta> GetDoktorAdiVeHastaSayisi();

		List<RandevuDetail> RandevuAyrintilari();

		List<RandevuDetail> RandevuDetailsByTime(string tarih);
		List<RandevuDetail> RandevuDetailsByTimeAndDoktorId(string tarih,int doktorId);  
		List<RandevuDetail> GetRandevuDetailsByDoktorId(int doktorId); 


	}
}
