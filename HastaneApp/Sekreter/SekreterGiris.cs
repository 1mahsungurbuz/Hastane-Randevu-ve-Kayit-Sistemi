using Business.Abstract;
using Entities.Concrete;
using HastaneApp.Login;
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
	public partial class SekreterGiris : Form
	{
		IDoktorService _doktorService;
		IHastaService _hastaService;
		ISekreterService _sekreterService;
		IBransService _bransService;
		IRandevuService _randevuService;

		public SekreterGiris(IDoktorService doktorService,
			IHastaService hastaService,
			ISekreterService sekreterService,
			IBransService bransService,
			IRandevuService randevuService
	)
		{
			_doktorService = doktorService;
			_hastaService = hastaService;
			_sekreterService = sekreterService;
			_bransService = bransService;
			_randevuService = randevuService;
			InitializeComponent();
		}



		private void BtnSkrtrGiris_Click_1(object sender, EventArgs e)
		{
			if (TxtTc.Text.Length > 0 && TxtSifre.Text.Length > 0)
			{
				var result = _sekreterService.GetLoginForSekreter(TxtTc.Text, TxtSifre.Text);

				if (result != null)
				{
					tableLayoutPanel1.Controls.Clear();
					S_SecretaryHomeForm s_SecretaryHomeForm = new S_SecretaryHomeForm(
						_doktorService,
						_hastaService,
						_sekreterService,
						_bransService,
						_randevuService);

					s_SecretaryHomeForm.ShowDialog();

				}


				else
				{
					MessageBox.Show("Giriş Bilgileri Hatalı", "Hata");
				}


			}
			else
			{
				if (TxtTc.Tag != null && TxtSifre.Tag != null)
				{
					TxtTc.BackColor = Color.Coral;
					TxtSifre.BackColor = Color.Coral;

				}




				MessageBox.Show("Kırmızı ALanları Doldurun Lütfen");
			}





		}


	}
}
