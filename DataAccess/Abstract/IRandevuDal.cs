using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
	public interface IRandevuDal : IEntityRepositoryBase<Randevu>
	{

		List<BolumAndHasta> GetBolumAdiVeHastaSayisi();

		List<DoktorAndHasta> GetDoktorAdiVeHastaSayisi();
		List<RandevuDetail> RandevuAyrintilari();

		List<RandevuDetail> RandevuDetailsByTime(string tarih);

		List<RandevuDetail> GetRandevuDetailsByDoktorId(int doktorId);

		public List<RandevuDetail> RandevuDetailsByTimeAndDoktorId(string tarih, int doktorId); 

	}
}
