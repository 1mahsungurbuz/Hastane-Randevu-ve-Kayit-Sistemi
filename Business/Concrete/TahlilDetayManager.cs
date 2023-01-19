using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Eframework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class TahlilDetayManager : ITahlilDetayService
	{
		ITahlilDetayDal _tahlilDetayDal;

		public TahlilDetayManager(ITahlilDetayDal tahlilDetayDal)
		{
			_tahlilDetayDal = tahlilDetayDal;
		}

		public void Add(TahlilDetay entity)
		{
			_tahlilDetayDal.Add(entity);
		}

		public void Delete(TahlilDetay entity)
		{
			throw new NotImplementedException();
		}

		public TahlilDetay Get(int id)
		{
			throw new NotImplementedException();
		}

		public List<TahlilDetay> GetAll()
		{
			return _tahlilDetayDal.GetAll();
		}

		public List<TahlilDetay> GetTahlilDetayByHastaIdAndTahlilId(int hastaId, int tahlilId)
		{
			return _tahlilDetayDal.GetTahlilByHastaId(p =>p.HastalId == hastaId && p.TahlilId==tahlilId);
		}
		public List<TahlilDetay> GetAllTahlil(int TahlilId)
		{
			return _tahlilDetayDal.GetAllTahlil(p => p.TahlilId == TahlilId);
		}

		public void Update(TahlilDetay entity)
		{
			throw new NotImplementedException();
		}
	}
}
