using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Eframework;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.Eframework
{
	public class EfRandevuDal : EfEntityRepositoryBase<Randevu, MyProjectContext>, IRandevuDal  
	{
		public List<BolumAndHasta> GetBolumAdiVeHastaSayisi()
		{

			using (MyProjectContext context=new MyProjectContext())
			{

				var res =   from r in context.Randevular
							join dktr in context.Doktorlar on r.DoktorId equals dktr.Id
							join brns in context.Branslar on dktr.BransId equals brns.Id
						    group r by new { brns.Id, brns.BransAdi }  
							into g select new BolumAndHasta{ BolumAdi=g.Key.BransAdi, HastaSayisi = g.Count() }; 

				return res.ToList();
			}

		}

		public List<DoktorAndHasta> GetDoktorAdiVeHastaSayisi()
		{
			using (MyProjectContext context = new MyProjectContext())
			{

				var res = from r in context.Randevular
						  join d in context.Doktorlar on r.DoktorId equals d.Id
						  group r by new { r.DoktorId, d.Adi } 
							into g
						  select new DoktorAndHasta { DoktorAdi = g.Key.Adi, HastaSayisi = g.Count() };

				return res.ToList();
			}
		}

		public List<RandevuDetail> GetRandevuDetailsByDoktorId(int doktorId)
		{
			using (MyProjectContext context = new MyProjectContext())
			{
				var resut = from rndv in context.Randevular
							join dktr in context.Doktorlar on rndv.DoktorId equals dktr.Id
							join hsta in context.Hastalar on rndv.HastaId equals hsta.Id
							join blm in context.Branslar on dktr.BransId equals blm.Id
							where dktr.Id == doktorId

							select new RandevuDetail
							{
								Id = rndv.Id,
								HastaId=hsta.Id,
								DoktorId=dktr.Id,
								DoktorAdi = dktr.Adi,
								HastaAdi = hsta.Adi,
								BolumAdi = blm.BransAdi,
								Saat = rndv.Saat,
								Tarih = rndv.Tarih.ToString()

							};

				return resut.ToList();



			}
		}

			public List<RandevuDetail> RandevuAyrintilari()
		{
			using (MyProjectContext context = new MyProjectContext())
			{
				var resut = from rndv in context.Randevular
							join dktr in context.Doktorlar on rndv.DoktorId equals dktr.Id
							join hsta in context.Hastalar on rndv.HastaId equals hsta.Id
							join blm in context.Branslar on dktr.BransId equals blm.Id

							select new RandevuDetail
							{
								Id = rndv.Id,
								DoktorAdi = dktr.Adi,
								HastaAdi = hsta.Adi,
								BolumAdi = blm.BransAdi,
								Saat = rndv.Saat,
								Tarih = rndv.Tarih.ToString()

							};

				return resut.ToList();

			}


		}

		public List<RandevuDetail> RandevuDetailsByTime(string tarih)
		{
			using (MyProjectContext context=new MyProjectContext())
			{

				var resut = from rndv in context.Randevular
							join dktr in context.Doktorlar on rndv.DoktorId equals dktr.Id
							join hsta in context.Hastalar on rndv.HastaId equals hsta.Id
							join blm in context.Branslar on dktr.BransId equals blm.Id 
							where rndv.Tarih==tarih
							select new RandevuDetail 
							{
								Id = rndv.Id,
								DoktorAdi = dktr.Adi,
								HastaAdi = hsta.Adi,
								BolumAdi = blm.BransAdi,
								Saat = rndv.Saat,
								Tarih = rndv.Tarih.ToString()

							};



				return resut.ToList();
			}
		}

		public List<RandevuDetail> RandevuDetailsByTimeAndDoktorId(string tarih, int doktorId)
		{
			using (MyProjectContext context = new MyProjectContext())
			{

				var resut = from rndv in context.Randevular
							join dktr in context.Doktorlar on rndv.DoktorId equals dktr.Id
							join hsta in context.Hastalar on rndv.HastaId equals hsta.Id
							join blm in context.Branslar on dktr.BransId equals blm.Id
							where rndv.Tarih == tarih && dktr.Id==doktorId
							select new RandevuDetail
							{
								Id = rndv.Id,
								DoktorAdi = dktr.Adi,
								HastaAdi = hsta.Adi,
								BolumAdi = blm.BransAdi,
								Saat = rndv.Saat,
								Tarih = rndv.Tarih.ToString()

							};



				return resut.ToList();
			}

		}
	}
}


