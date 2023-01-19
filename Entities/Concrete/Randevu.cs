using Core.Entities.Abstract;

namespace Entities.Concrete
{
	public class Randevu : IEntity 
	{

		public int Id { get; set; }
		public int HastaId { get; set; }
		public int DoktorId { get; set; }
		public string Tarih { get; set; } 
		public string Saat { get; set; } 

	}





}
