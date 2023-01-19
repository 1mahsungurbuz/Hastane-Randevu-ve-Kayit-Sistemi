using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Eframework;
using Entities.Concrete;

namespace Business.Concrete
{
	public class SekreterManager : ISekreterService

	{
		ISekreterDal _sekreterDal;

		public SekreterManager(ISekreterDal sekreterDal)
		{
			_sekreterDal = sekreterDal;
		}

		public void Add(Sekreter entity)
		{
			 _sekreterDal.Add(entity);
		}

		public void Delete(Sekreter entity)
		{
			_sekreterDal.Delete(entity);
		}

		public List<Sekreter> FilterByName(string name)
		{
			return _sekreterDal.GetAll(t => t.Adi.Contains(name));
		}

		public Sekreter Get(int id)
		{
			return _sekreterDal.Get(p => p.Id == id);
		}

		public List<Sekreter> GetAll()
		{
			return _sekreterDal.GetAll();
		}

		public Sekreter GetLoginForSekreter(string TC, string Sifre)
		{
			var result = _sekreterDal.GetLoginForSekreter(d => d.TC == TC && d.Sifre == Sifre);

			if (result != null && result.TC == TC && result.Sifre == Sifre)
			{

	
					return result;

				


			}


			return null;



		}

		public Sekreter GetSekreterWithTc(string TC)
		{
			return _sekreterDal.GetSekreterWithTc(s => s.TC == TC);
		}

		public void Update(Sekreter entity)
		{

			 _sekreterDal.Update(entity);
		}
	}
}
