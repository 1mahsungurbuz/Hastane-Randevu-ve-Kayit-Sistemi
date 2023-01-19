using Core.Business.Abstract;
using Core.Entities.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Linq.Expressions;

namespace Business.Abstract
{
	public interface IDoktorService : IEntityServiceBase<Doktor>
	{


		List<Doktor> FilterByName(string name);

		public List<Doktor> GetDoktorByBransId(int id);

		public Doktor GetDoktorWithTc(string Tc);

		public Doktor GetLoginForDoktor(string TC, string Sifre);

		



	}
}
