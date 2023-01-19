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
	public class DoktorTeshisManager : IDoktorTeshisService
	{
		IDoktorTeshisDal _doktorTeshisDal;

		public DoktorTeshisManager(IDoktorTeshisDal doktorTeshisDal)
		{
			_doktorTeshisDal = doktorTeshisDal;
		}

		public void Add(DoktorTeshis entity)
		{
			_doktorTeshisDal.Add(entity);
		}

		public void Delete(DoktorTeshis entity)
		{
			_doktorTeshisDal.Delete(entity);
		}

		public DoktorTeshis DoktorTeshisByHastaIdAndDoktorId(int hastaId, int doktorId)
		{
			return _doktorTeshisDal.DoktorTeshisByHastaIdAndDoktorId(p => p.HastaId == hastaId && p.DoktorId == doktorId);
		}

		public DoktorTeshis Get(int id)
		{
			return _doktorTeshisDal.Get(p=>p.TshisId==id);
		}

		public List<DoktorTeshis> GetAll()
		{
			return _doktorTeshisDal.GetAll();
		}

		public List<DoktorTeshis> GetDoktorTeshisByHastaIdAndDoktorId(int hastaId, int doktorId)  
		{
			return _doktorTeshisDal.GetDoktorTeshisByHastaIdAndDoktorId(p => p.HastaId == hastaId && p.DoktorId == doktorId);
		}

		public void Update(DoktorTeshis entity)
		{
			_doktorTeshisDal.Update(entity);
		}
	}
}
