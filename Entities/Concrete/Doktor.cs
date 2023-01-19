using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
	public class Doktor : Entity, IEntity 
	{
		public int Id { get; set; } 
		public int BransId { get; set; }	
		public string Sifre { get; set; } 



	}

}
