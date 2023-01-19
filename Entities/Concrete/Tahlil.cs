using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
	public class Tahlil : IEntity
	{
		[Key]
		public int ThlilId { get; set; } 
		public string ThlilAdi { get; set; }

	}
}
