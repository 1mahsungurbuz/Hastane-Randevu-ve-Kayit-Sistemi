using Core.Entities.Abstract;

namespace Entities.Concrete
{
	public class Sekreter : Entity, IEntity 
	{

		public int Id { get; set; }
		public string Sifre { get; set; }


	}


}
