using Business.Abstract;
using Business.Concrete;
using Core.Entities.Abstract;
using Entities.Concrete;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneApp.Secretary
{
	public partial class SekreterKayit : Form
	{
		ISekreterService _sekreterService;


		public SekreterKayit(ISekreterService sekreterService)
		{
			_sekreterService = sekreterService;

			InitializeComponent();

		}

		private void SekreterBoslukKontrol()
		{


			foreach (Control item in GroupBoxSkrtrContrls.Controls)
			{
				if (item.Tag != null)
				{
					item.BackColor = Color.Coral;

				}

			}

			MessageBox.Show("Kırmızı ALanları Doldurun Lütfen");

		}

		private void BtnSkreterKayit_Click_1(object sender, EventArgs e)
		{


			if (TxtSkrtrAdi.Text.Length > 0 && TxtSkrtrSydi.Text.Length > 0 && TxtSkrtrTcKmlkNo.Text.Length > 0 && TxtSekreterSifre.Text.Length > 0)
			{

				var result = _sekreterService.GetSekreterWithTc(TxtSkrtrTcKmlkNo.Text);

				if (result == null)
				{
					Sekreter sekreter = new Sekreter
					{
						Adi = TxtSkrtrAdi.Text,
						Soyadi = TxtSkrtrSydi.Text,
						TelNo = TxtMskdSkrtrTlfnNo.Text,
						TC = TxtSkrtrTcKmlkNo.Text,
						DogumTarihi = dateTimePickerSkrtrDogmTrh.Value.ToShortDateString(),
						DogumYeri = TxtSkrtrDogmYri.Text,
						Email = TxtSkrtrEmail.Text,
						Sifre = TxtSekreterSifre.Text



					};



					_sekreterService.Add(sekreter);

					MessageBox.Show("Giriş için Sekreter Resmine Tıklayın Lütfen", "Kayıt Başarılı");
				}

				else
				{
					MessageBox.Show("Bu TC Kimlik Numarası ile  Bir Sekrreter zaten Mevcut");
				}
			}

			else
			{
				SekreterBoslukKontrol();
			}




		}

		
	}
}
