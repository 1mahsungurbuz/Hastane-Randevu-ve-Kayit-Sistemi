using Business.Abstract;
using HastaneApp.Secretary;
using iTextSharp.text.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneApp.Doctor
{
	public partial class DoktorGirisForm : Form
	{

		ITahlilService _tahlilService;
		ITahlilDetayService _tahlilDetayService;
		IDoktorTeshisService _doktorTeshisService;
		IDoktorService _doktorService;
		IHastaService _hastaService;
		IRandevuService _randevuService;

		public DoktorGirisForm(ITahlilService tahlilService, ITahlilDetayService tahlilDetayService, IDoktorTeshisService doktorTeshisService, IHastaService hastaService,IDoktorService doktorService, IRandevuService randevuService)
		{
			_tahlilService = tahlilService;
			_tahlilDetayService = tahlilDetayService;
			_doktorTeshisService = doktorTeshisService;
			_hastaService = hastaService;
			_doktorService = doktorService;
			_randevuService = randevuService;
			InitializeComponent();
		}


		private void BtnDktrGiris_Click(object sender, EventArgs e)
		{
			if (TxtTC.Text.Length > 0 && TxtSifre.Text.Length > 0)
			{
				var result = _doktorService.GetLoginForDoktor(TxtTC.Text, TxtSifre.Text);

				if (result != null)
				{
					tableLayoutPanel1.Controls.Clear();
					DoktorAnaMenu doktorAnaMenu = new DoktorAnaMenu(_tahlilService,
						_tahlilDetayService, _doktorTeshisService,
						_hastaService, _doktorService,_randevuService ,result.Id);

					doktorAnaMenu.ShowDialog();
				}

				else
				{
					MessageBox.Show("Giriş Bilgileri Hatalı. Şifrenizi Hatırlamıyorsanız Sekreterden Güncel Şifre Edinin.", "Hata");
				}

			}
			

			else
			{
				if (TxtTC.Tag != null && TxtSifre.Tag != null)
				{
					TxtTC.BackColor = Color.Coral;
					TxtSifre.BackColor = Color.Coral;

				}




				MessageBox.Show("Kırmızı ALanları Doldurun Lütfen");
			}

		}
	}
}
