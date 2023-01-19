using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
	public class TahlilDetay : IEntity 
	{
		[Key]
		public int ThlilDetayId { get; set; }
		public int TahlilId { get; set; } 
		public int HastalId { get; set; }  
		public string ThlilSonuc { get; set; }
		public string? ThlilSonucBirimi { get; set; } 
		public string? ThlilReferansDegeri { get; set; }
		public DateTime ThlilTarihi { get; set; }

	}
}
