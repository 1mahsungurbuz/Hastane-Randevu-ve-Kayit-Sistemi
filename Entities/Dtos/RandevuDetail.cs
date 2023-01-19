using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
	public class RandevuDetail 
	{

		public int Id { get; set; }
		public int HastaId { get; set; }
		public int DoktorId { get; set; }
		public string HastaAdi { get; set; }
		public string DoktorAdi { get; set; }
		public string BolumAdi { get; set; }
		public string Tarih { get; set; }
		public string Saat { get; set; }
	}
}
