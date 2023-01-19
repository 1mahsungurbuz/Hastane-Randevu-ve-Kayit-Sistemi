using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class BransManager : IBransService
	{
		IBransDal _bransDal; 

		public BransManager(IBransDal bransDal)
		{
			_bransDal = bransDal;
		}

		public void Add(Brans entity)
		{
			_bransDal.Add(entity);
		}

		public void Delete(Brans entity)
		{
			throw new NotImplementedException();
		}

		public List<Brans> FilterByName(string name)
		{
			return _bransDal.GetAll(t => t.BransAdi.Contains(name));
		}

		public Brans Get(int id)
		{
			return _bransDal.Get(p => p.Id == id);
		}

		public List<Brans> GetAll()
		{
			return _bransDal.GetAll();
		}


		public void Update(Brans entity)
		{
			throw new NotImplementedException();
		}
	}
}
