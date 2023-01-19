using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class RandevuManager : IRandevuService
	{
		IRandevuDal _randevuDal;

		public RandevuManager(IRandevuDal randevuDal)
		{
			_randevuDal = randevuDal;
		}

		public void Add(Randevu entity)
		{
			_randevuDal.Add(entity);
		}

		public void Delete(Randevu entity)
		{
			_randevuDal.Delete(entity);
		}

		public Randevu Get(int id)
		{
			return _randevuDal.Get(p => p.Id == id);
		}

		public List<Randevu> GetAll()
		{
			return _randevuDal.GetAll();
		}

		public List<Randevu> GetAll(int doktorId)
		{
			return _randevuDal.GetAll(d => d.DoktorId == doktorId);
		}


		public List<BolumAndHasta> GetBolumAdiVeHastaSayisi()
		{
			return _randevuDal.GetBolumAdiVeHastaSayisi();
		}

		public List<DoktorAndHasta> GetDoktorAdiVeHastaSayisi()
		{
			return _randevuDal.GetDoktorAdiVeHastaSayisi();
		}

		public List<RandevuDetail> GetRandevuDetailsByDoktorId(int doktorId)
		{
			return _randevuDal.GetRandevuDetailsByDoktorId(doktorId);
		}

		public List<RandevuDetail> RandevuAyrintilari()
		{
			return _randevuDal.RandevuAyrintilari();

		}

		public List<RandevuDetail> RandevuDetailsByTime(string tarih)
		{

			return _randevuDal.RandevuDetailsByTime(tarih);
		}

		public List<RandevuDetail> RandevuDetailsByTimeAndDoktorId(string tarih, int doktorId) 
		{
			return _randevuDal.RandevuDetailsByTimeAndDoktorId(tarih, doktorId); 
		}

		public void Update(Randevu entity)
		{
			_randevuDal.Update(entity);
		}
	}
}
