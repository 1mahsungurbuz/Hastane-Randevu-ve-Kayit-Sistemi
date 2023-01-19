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
	public partial class HastaEkleme : Form
	{
		IHastaService _hastaService;
		int hastaId;


		public HastaEkleme(IHastaService hastaService )
		{
			_hastaService = hastaService;
			InitializeComponent();

		}

		private void S_PatientForm_Load_1(object sender, EventArgs e)
		{
			dataGridViewHsta_islmlri.DataSource = _hastaService.GetAll();


		}

		private void HastaBoslukKontrol()
		{


			foreach (Control item in GroupBoxHstaContrls.Controls)
			{
				if (item.Tag != null)
				{
					item.BackColor = Color.Coral;

				}

			}
			MessageBox.Show("Kırmızı ALanları Doldurun Lütfen");

		}

		void data_Binding(Hasta hasta)
		{
			ClearDataBinding();


			TxtHstaTcKmlkNo.DataBindings.Add("Text", hasta, "TC");
			TxtHstaAdi.DataBindings.Add("Text", hasta, "Adi");
			TxtHstaSydi.DataBindings.Add("Text", hasta, "Soyadi");
			TxtMskdHstaTlfnNo.DataBindings.Add("Text", hasta, "TelNo");
			TxtHstaEmail.DataBindings.Add("Text", hasta, "Email");
			TxtHstaDogmYri.DataBindings.Add("Text", hasta, "DogumYeri");
			dateTimePickerHstaDogmTrh.DataBindings.Add("Text", hasta, "DogumTarihi");


		}

		void ClearDataBinding()
		{
			foreach (Control item in GroupBoxHstaContrls.Controls)
			{
				item.DataBindings.Clear();

			}
		}

		void EmptyDataBinding()
		{
			data_Binding(new Hasta());
		}

	
		
		private void BtnPage2HastaSec_Click(object sender, EventArgs e)
		{
			try
			{
				hastaId = Convert.ToInt16(dataGridViewHsta_islmlri.Rows[dataGridViewHsta_islmlri.CurrentCell.RowIndex].Cells[0].Value);
				TabPageHastaSecme.Hide();
				TabPageHastaDuzenleme.Show();
				data_Binding(_hastaService.Get(hastaId));
			}
			catch (Exception)
			{

				MessageBox.Show("Lütfen Önce Hasta Ekleyin");
			}


		}

		private void BtnPage2HastaSec_Click_1(object sender, EventArgs e)
		{
			TabPageHastaDuzenleme.Hide();
			TabPageHastaSecme.Show();
		}


		private void TxtHstaAra_TextChanged_1(object sender, EventArgs e)
		{
			dataGridViewHsta_islmlri.DataSource = _hastaService.FilterByName(TxtHstaAra.Text);

		}

		private void BtnHstaSil_Click_1(object sender, EventArgs e)
		{
			try
			{
				Hasta hasta = new Hasta()
				{
					Id = hastaId
				};

				_hastaService.Delete(hasta);
				S_PatientForm_Load_1(sender, e);
				EmptyDataBinding();

			}
			catch (Exception)
			{
				MessageBox.Show("Bir Hata Oldu");
			}


		}

		private void BtnHstaCntrlTmzle_Click_1(object sender, EventArgs e)
		{
			EmptyDataBinding();

		}

		private void BtnHstaKydt_Click_1(object sender, EventArgs e)
		{



			if (TxtHstaAdi.Text.Length > 0 && TxtHstaSydi.Text.Length > 0 && TxtHstaTcKmlkNo.Text.Length > 0)
			{
				var result = _hastaService.GetHastaWithTc(TxtHstaTcKmlkNo.Text);

				if (result.Count == 0)
				{
					Hasta hasta = new Hasta
					{
						Adi = TxtHstaAdi.Text,
						Soyadi = TxtHstaSydi.Text,
						TelNo = TxtMskdHstaTlfnNo.Text,
						TC = TxtHstaTcKmlkNo.Text,
						DogumTarihi = dateTimePickerHstaDogmTrh.Value.ToShortDateString(),
						DogumYeri = TxtHstaDogmYri.Text,
						Email = TxtHstaEmail.Text
					};
					_hastaService.Add(hasta);

					MessageBox.Show("Hasta Kaydedildi.");

					S_PatientForm_Load_1(sender, e);
					EmptyDataBinding();
				}

				else
				{
					MessageBox.Show("Bu TC Kimlik Numarası ile  Bir Hasta zaten Mevcut");
				}

			}

			else
			{

				HastaBoslukKontrol();
			}

		}

		private void BtnHstaGnclle_Click_1(object sender, EventArgs e)
		{

			try
			{
				if (TxtHstaAdi.Text.Length > 0 && TxtHstaSydi.Text.Length > 0 && TxtHstaTcKmlkNo.Text.Length > 0)
				{
					Hasta hasta = new Hasta
					{
						Id = hastaId,
						Adi = TxtHstaAdi.Text,
						Soyadi = TxtHstaSydi.Text,
						TelNo = TxtMskdHstaTlfnNo.Text,
						TC = TxtHstaTcKmlkNo.Text,
						DogumTarihi = dateTimePickerHstaDogmTrh.Value.ToShortDateString(),
						DogumYeri = TxtHstaDogmYri.Text,
						Email = TxtHstaEmail.Text
					};
					_hastaService.Update(hasta);
					MessageBox.Show("Hasta Güncellendi.");

					S_PatientForm_Load_1(sender, e);
					EmptyDataBinding();
					EmptyDataBinding();
				}

				else
				{
					HastaBoslukKontrol();

				}
			}
			catch (Exception)
			{
				MessageBox.Show("Bir Hata Oldu");
			}


		}

	}
}
