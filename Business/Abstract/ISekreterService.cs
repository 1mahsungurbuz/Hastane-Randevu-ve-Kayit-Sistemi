using Core.Business.Abstract;
using Core.Entities.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ISekreterService : IEntityServiceBase<Sekreter>
	{
		List<Sekreter> FilterByName(string name);

		public Sekreter GetLoginForSekreter(string TC, string Sifre);
		public Sekreter GetSekreterWithTc(string TC);

		

	}
}
