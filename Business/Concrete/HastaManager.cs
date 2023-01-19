using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Eframework;
using Entities.Concrete;

namespace Business.Concrete
{
	public class HastaManager : IHastaService 

	{

		IHastaDal _hastaDal;

		public HastaManager(IHastaDal hastaDal)
		{
			_hastaDal = hastaDal;
		}

		public void Add(Hasta entity)
		{
			_hastaDal.Add(entity);
		}

		public void Delete(Hasta entity)
		{
			_hastaDal.Delete(entity);
		}

		public List<Hasta> FilterByName(string name)
		{
			return _hastaDal.GetAll(t => t.Adi.Contains(name));
		}

		public Hasta Get(int id)
		{
			return _hastaDal.Get(p => p.Id ==id);
		}

		public List<Hasta> GetAll()
		{
			return _hastaDal.GetAll();
		}


		public void Update(Hasta entity)
		{
			_hastaDal.Update(entity);
		
		}

		public List<Hasta> GetHastaWithTc(string Tc)
		{
			return _hastaDal.GetHastaWithTc(p=>p.TC==Tc);
		}
	}
}
