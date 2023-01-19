using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Eframework;
using HastaneApp.Doctor;
using HastaneApp.Login;
using HastaneApp.Secretary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HastaneApp
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
		
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var services = new ServiceCollection();

			ConfigureServices(services);

			using (ServiceProvider serviceProvider = services.BuildServiceProvider())
			{
				var baslangicForm  = serviceProvider.GetRequiredService<GirisForm>();
				Application.Run(baslangicForm);
			}

		}

		public static void ConfigureServices(IServiceCollection services)

		{
			

			services.AddSingleton<IBransService, BransManager>();
			services.AddSingleton<IBransDal, EfBransDal>();


			services.AddSingleton<IDoktorService, DoktorManager>();
			services.AddSingleton<IDoktorDal, EfDoktorDal>();

			services.AddSingleton<IHastaService, HastaManager>();
			services.AddSingleton<IHastaDal, EfHastaDal>();


			services.AddSingleton<ITahlilService, TahlilManager>();
			services.AddSingleton<ITahlilDal, EfTahlilDal>();

			services.AddSingleton<ITahlilDetayService, TahlilDetayManager>();
			services.AddSingleton<ITahlilDetayDal, EfTahlilDetayDal>();

			services.AddSingleton<ISekreterService, SekreterManager>();
			services.AddSingleton<ISekreterDal, EfSekreterDal>();

			services.AddSingleton<IRandevuService, RandevuManager>();
			services.AddSingleton<IRandevuDal, EfRandevuDal>();

			services.AddSingleton<IDoktorTeshisService, DoktorTeshisManager>();
			services.AddSingleton<IDoktorTeshisDal, EfDoktorTeshisDal>();

			
		

			services.AddScoped<GirisForm>();

			MyProjectContext context = new();

			context.Database.Migrate();

		}

	}
}