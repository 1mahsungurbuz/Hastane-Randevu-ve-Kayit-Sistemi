using Business.Abstract;
using Entities.Concrete;
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
	public partial class SekreterEkleme : Form
	{
		ISekreterService _sekreterService;
		int sekreterId;
		public SekreterEkleme(ISekreterService sekreterService)
		{
			_sekreterService = sekreterService;
			InitializeComponent();
		}

		private void S_SecretaryForm_Load(object sender, EventArgs e)
		{
			dataGridViewSkrtr_islmlri.DataSource = _sekreterService.GetAll();
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


		void data_Binding(Sekreter sekreter)
		{
			ClearDataBinding();

			TxtSkrtrTcKmlkNo.DataBindings.Add("Text", sekreter, "TC");
			TxtSkrtrAdi.DataBindings.Add("Text", sekreter, "Adi");
			TxtSkrtrSydi.DataBindings.Add("Text", sekreter, "Soyadi");
			TxtMskdSkrtrTlfnNo.DataBindings.Add("Text", sekreter, "TelNo");
			TxtSkrtrEmail.DataBindings.Add("Text", sekreter, "Email");
			TxtSkrtrDogmYri.DataBindings.Add("Text", sekreter, "DogumYeri");
			dateTimePickerSkrtrDogmTrh.DataBindings.Add("Text", sekreter, "DogumTarihi");
			TxtSkrtrSifre.DataBindings.Add("Text", sekreter, "Sifre");


		}

		void ClearDataBinding()
		{
			foreach (Control item in GroupBoxSkrtrContrls.Controls)
			{
				item.DataBindings.Clear();

			}
		}

		void EmptyDataBinding()
		{
			data_Binding(new Sekreter());
		}



		private void BtnSkrtrCntrlTmzle_Click(object sender, EventArgs e)
		{
			EmptyDataBinding();
		}

		private void BtnSkrtrGnclle_Click(object sender, EventArgs e)
		{
			if (TxtSkrtrAdi.Text.Length > 0 && TxtSkrtrSydi.Text.Length > 0 && TxtSkrtrTcKmlkNo.Text.Length > 0 && TxtSkrtrSifre.Text.Length > 0)
			{
				Sekreter sekreter = new Sekreter
				{
					Id = sekreterId,
					Adi = TxtSkrtrAdi.Text,
					Soyadi = TxtSkrtrSydi.Text,
					TelNo = TxtMskdSkrtrTlfnNo.Text,
					TC = TxtSkrtrTcKmlkNo.Text,
					DogumTarihi = dateTimePickerSkrtrDogmTrh.Value.ToShortDateString(),
					DogumYeri = TxtSkrtrDogmYri.Text,
					Email = TxtSkrtrEmail.Text,
					Sifre = TxtSkrtrSifre.Text

				};
				_sekreterService.Update(sekreter);

				MessageBox.Show("Sekreter Güncellendi");
				S_SecretaryForm_Load(sender, e);
				EmptyDataBinding();
			}

			else
			{
				SekreterBoslukKontrol();
			}
		}

		private void BtnSkrtrKydt_Click(object sender, EventArgs e)
		{
			if (TxtSkrtrAdi.Text.Length > 0 && TxtSkrtrSydi.Text.Length > 0 && TxtSkrtrTcKmlkNo.Text.Length > 0 && TxtSkrtrSifre.Text.Length > 0)
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
						Sifre = TxtSkrtrSifre.Text


					};
					_sekreterService.Add(sekreter);
					MessageBox.Show("Sekreter Kaydedildi.");


					S_SecretaryForm_Load(sender, e);
					EmptyDataBinding();
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

		private void BtnSkrtrSil_Click(object sender, EventArgs e)
		{
			try
			{
				Sekreter sekreter = new Sekreter()
				{
					Id = sekreterId
				};

				_sekreterService.Delete(sekreter);
				S_SecretaryForm_Load(sender, e);
				EmptyDataBinding();
			}
			catch (Exception)
			{

				MessageBox.Show("Bir Hata Oldu");
			}
		}

		private void TxtSkrtrAra_TextChanged(object sender, EventArgs e)
		{
			dataGridViewSkrtr_islmlri.DataSource = _sekreterService.FilterByName(TxtSkrtrAra.Text);

		}

		private void BtnPage2SekreterSec_Click(object sender, EventArgs e)
		{
			TabPageSekreterDuzenleme.Hide();
			TabPageSekreterSecme.Show();
		}

		private void BtnPage1SekreterSec_Click(object sender, EventArgs e)
		{
			try
			{
				sekreterId = Convert.ToInt16(dataGridViewSkrtr_islmlri.Rows[dataGridViewSkrtr_islmlri.CurrentCell.RowIndex].Cells[0].Value);
				TabPageSekreterSecme.Hide();
				TabPageSekreterDuzenleme.Show();
				data_Binding(_sekreterService.Get(sekreterId));

			}
			catch (Exception)
			{

				MessageBox.Show("Lütfen Önce Hasta Ekleyin");
			}

		}

	}
}
