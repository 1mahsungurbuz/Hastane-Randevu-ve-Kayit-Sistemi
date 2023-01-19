using Business.Abstract;
using Entities.Dtos;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneApp.Secretary
{
	public partial class Grafikler : Form
	{
		IRandevuService _randevuService;

		public Grafikler(IRandevuService randevuService)
		{
			_randevuService = randevuService;
			InitializeComponent();
		}

		

		private void HastaDoktorGrafikPage_Click(object sender, EventArgs e)
		{

			Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

			// Define a collection of items to display in the chart 
			SeriesCollection piechartData = new SeriesCollection();

			List<DoktorAndHasta> result = _randevuService.GetDoktorAdiVeHastaSayisi();



			foreach (DoktorAndHasta item in result)
			{


				PieSeries pieSeries = new PieSeries
				{
					Title = item.DoktorAdi,
					Values = new ChartValues<int> { item.HastaSayisi },
					DataLabels = true,
					LabelPoint = labelPoint
				};

				piechartData.Add(pieSeries);


			}




			pieChartHastaDoktor.Series = piechartData;

			pieChartHastaDoktor.LegendLocation = LegendLocation.Right;

		}

		private void HastaBolumGrafikPage_Click(object sender, EventArgs e)
		{
			Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

			// Define a collection of items to display in the chart 
			SeriesCollection piechartData = new SeriesCollection();

			List<BolumAndHasta> result = _randevuService.GetBolumAdiVeHastaSayisi();



			foreach (BolumAndHasta item in result)
			{


				PieSeries pieSeries = new PieSeries
				{
					Title = item.BolumAdi,
					Values = new ChartValues<int> { item.HastaSayisi },
					DataLabels = true,
					LabelPoint = labelPoint
				};

				piechartData.Add(pieSeries);


			}



			pieChartHastaBolum.Series = piechartData;

			pieChartHastaBolum.LegendLocation = LegendLocation.Right;
		}

		private void S_GrafiklerForm_Load(object sender, EventArgs e)
		{
			HastaBolumGrafikPage_Click(sender, e);
			HastaDoktorGrafikPage_Click(sender, e);
		}
	}
}
