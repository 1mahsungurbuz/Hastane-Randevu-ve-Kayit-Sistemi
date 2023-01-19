using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Eframework;
using Entities.Concrete;

namespace Business.Concrete
{
	public class TahlilManager : ITahlilService 

	{
		ITahlilDal _tahlilDal;

		public TahlilManager(ITahlilDal tahlilDal)
		{
			_tahlilDal = tahlilDal;
		}

		public void Add(Tahlil entity)
		{
			_tahlilDal.Add(entity);
		}

		public void Delete(Tahlil entity)
		{
			throw new NotImplementedException();
		}

		public List<Tahlil> FilterByName(string name)
		{
			return _tahlilDal.GetAll(t => t.ThlilAdi.Contains(name));
		}

		public Tahlil Get(int id)
		{
			return _tahlilDal.Get(p => p.ThlilId == id);
		}

		public List<Tahlil> GetAll()
		{
			return _tahlilDal.GetAll();
		}

		

		public void Update(Tahlil entity)
		{
			throw new NotImplementedException();
		}
	}
}
