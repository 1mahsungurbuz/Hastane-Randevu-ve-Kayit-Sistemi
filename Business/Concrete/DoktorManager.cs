using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Eframework;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class DoktorManager : IDoktorService

	{
		IDoktorDal _doktorDal;

		public DoktorManager(IDoktorDal doktorDal)
		{
			_doktorDal = doktorDal;
		}

		public void Add(Doktor entity)
		{
			_doktorDal.Add(entity);
		}

		public void Delete(Doktor entity)
		{
			_doktorDal.Delete(entity);
		}

		public List<Doktor> FilterByName(string name)
		{

			return _doktorDal.GetAll(t => t.Adi.Contains(name));
		}

		public Doktor Get(int id)
		{
			return _doktorDal.Get(p => p.Id == id);
		}

		public List<Doktor> GetAll()
		{
			return _doktorDal.GetAll();
		}

	

		public List<Doktor> GetDoktorByBransId(int id)
		{
			return _doktorDal.GetDoktorByBransId(p => p.BransId == id);
		}


		public Doktor GetLoginForDoktor(string TC, string Sifre)
		{
			var result = _doktorDal.GetLoginForDoktor(d=>d.TC==TC && d.Sifre==Sifre);

			if (result != null && result.TC == TC && result.Sifre == Sifre)
			{
			
						return result;
	
			}


			return null;


		}

		public Doktor GetDoktorWithTc(string Tc)
		{
			return _doktorDal.GetDoktorWithTc(d => d.TC == Tc);
		}


		public void Update(Doktor entity)
		{
			_doktorDal.Update(entity);
		}
	}
}
