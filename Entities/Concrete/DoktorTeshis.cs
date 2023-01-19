using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
	public class DoktorTeshis : IEntity  
	{
		[Key]
		public int TshisId { get; set; } 
		public int HastaId { get; set; }
		public int DoktorId { get; set; }
		public string TeshisBaslik { get; set; }
		public string TeshisDetay { get; set; }
		public DateTime TeshisTarih { get; set; }
 

	}
}
