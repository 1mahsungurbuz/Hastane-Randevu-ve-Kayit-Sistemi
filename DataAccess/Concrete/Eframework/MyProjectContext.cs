using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Eframework
{
	public class MyProjectContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

		{
			optionsBuilder.UseSqlServer(@"Server=.;Database=MahsunGurbuzHastaneRandevuSistemi;Trusted_Connection=true");


			
		}

		public DbSet<Brans> Branslar { get; set; }

		public DbSet<Doktor> Doktorlar { get; set; }

		public DbSet<Hasta> Hastalar { get; set; }

		public DbSet<Sekreter> Sekreterler { get; set; }

		public DbSet<Tahlil> Tahliller { get; set; }
		public DbSet<TahlilDetay> TahlilDetaylari { get; set; }  
		public DbSet<DoktorTeshis> DoktorTeshisleri { get; set; }   

		public DbSet<Randevu> Randevular { get; set; }
		 

	}
}
