using Business.Abstract;
using Entities.Concrete;
using HastaneApp.Doctor;
using HastaneApp.Secretary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneApp.Login
{
	public partial class GirisForm : Form
	{
		IDoktorService _doktorService;
		IHastaService _hastaService;
		ISekreterService _sekreterService;
		IBransService _bransService;
		IRandevuService _randevuService;
		ITahlilService _tahlilService;
		ITahlilDetayService _tahlilDetayService;
		IDoktorTeshisService _doktorTeshisService;

		public GirisForm(IDoktorService doktorService,
			IHastaService hastaService,
			ISekreterService sekreterService,
			IBransService bransService,
			IRandevuService randevuService,
			ITahlilService tahlilService,
			ITahlilDetayService tahlilDetayService,
			IDoktorTeshisService doktorTeshisService)
		{
			_doktorService = doktorService;
			_hastaService = hastaService;
			_sekreterService = sekreterService;
			_bransService = bransService;
			_randevuService = randevuService;
			_tahlilService = tahlilService;
			_tahlilDetayService = tahlilDetayService;
			_doktorTeshisService = doktorTeshisService;

			InitializeComponent();
		}






		private void LoginForm_Load(object sender, EventArgs e)
		{



			List<Tahlil> tahlil = new List<Tahlil>
			{
				 new Tahlil
				 {
					 ThlilAdi="KAN"
				 },
				  new Tahlil
				 {
					 ThlilAdi="Hemogram"
				 },
				   new Tahlil
				 {
					 ThlilAdi="HGB"
				 }
			};

			List<Brans> brans = new List<Brans>
			{
				 new Brans
				 {
					 BransAdi ="KBB"
				 },
				  new Brans
				 {
					  BransAdi="NÖROLOJİ"
				 },

				   new Brans
				 {
					  BransAdi="KALP DAMAR"
				 },
				new Brans
				 {
					  BransAdi="KARDİYOLOJİ"
				 } ,
				new Brans
				 {
					  BransAdi="GENEL CERRAHİ"
				 } ,
				new Brans
				 {
					  BransAdi="PSİKİYATRİ"
				 } ,
				new Brans
				 {
					  BransAdi="KADIN HASTALIKLARI"
				 } ,
				new Brans
				 {
					  BransAdi="KADIN DOĞUM"
				 }
			};




			if (!_bransService.GetAll().Any())
			{


				foreach (var item in tahlil)
				{
					_tahlilService.Add(item);

				}
				foreach (var item in brans)
				{
					_bransService.Add(item);

				}

			}
		}

		private void BtbDktrGiris_Click(object sender, EventArgs e)
		{
			tableLayoutPanel1.Controls.Clear();
			DoktorGirisForm d_LoginForm = new DoktorGirisForm(_tahlilService, _tahlilDetayService, _doktorTeshisService, _hastaService, _doktorService,_randevuService);
			d_LoginForm.MdiParent = this;
			d_LoginForm.FormBorderStyle = FormBorderStyle.None;
			tableLayoutPanel1.Controls.Add(d_LoginForm);
			d_LoginForm.Show();


		}

		private void BtnSkrtrGiris_Click(object sender, EventArgs e)
		{

			if (!_sekreterService.GetAll().Any())
			{
				tableLayoutPanel1.Controls.Clear();
				SekreterKayit s_RegisterForm = new SekreterKayit(_sekreterService);
				s_RegisterForm.MdiParent = this;
				s_RegisterForm.FormBorderStyle = FormBorderStyle.None;
				tableLayoutPanel1.Controls.Add(s_RegisterForm);
				s_RegisterForm.Show();

			}

			else
			{
				tableLayoutPanel1.Controls.Clear();
				SekreterGiris s_LoginForm = new SekreterGiris(_doktorService, _hastaService, _sekreterService, _bransService, _randevuService);
				s_LoginForm.MdiParent = this;
				s_LoginForm.FormBorderStyle = FormBorderStyle.None;
				tableLayoutPanel1.Controls.Add(s_LoginForm);
				s_LoginForm.Show();
			}


		}

		private void BtnSekreterHesapSil_Click(object sender, EventArgs e)
		{
			try
			{
				string SekreterTC = Microsoft.VisualBasic.Interaction.InputBox("TC Kimlik No Girin", "Silinecek Hesap İçin TC Bilgisi", "TC..", 380, 350);

				Sekreter sekreter = _sekreterService.GetSekreterWithTc(SekreterTC);

				_sekreterService.Delete(sekreter);

				MessageBox.Show("Hesap Silindi Yeniden Kayıt Yapın.");


				tableLayoutPanel1.Controls.Clear();
				SekreterKayit s_RegisterForm = new SekreterKayit(_sekreterService);
				s_RegisterForm.MdiParent = this;
				s_RegisterForm.FormBorderStyle = FormBorderStyle.None;
				tableLayoutPanel1.Controls.Add(s_RegisterForm);
				s_RegisterForm.Show();


			}
			catch (Exception)
			{
				MessageBox.Show("Henüz Sekreter Bilgileri Getirlmedi.");

			}
		}
	}
}
