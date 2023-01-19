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
	public partial class DoktorEkleme : Form
	{
		IDoktorService _doktorService;
		IBransService _bransService;
		int doktorId;

		public DoktorEkleme(IDoktorService doktorService, IBransService bransService)
		{
			_doktorService = doktorService;
			_bransService = bransService;	
			InitializeComponent();
		}

		private void S_DoctorForm_Load(object sender, EventArgs e)
		{
			dataGridViewDktr_islmlri.DataSource= _doktorService.GetAll();

			CmBoxDktrBrans.DataSource = _bransService.GetAll();

		}

		private void DoktorBoslukKontrol()
		{
			foreach (Control item in GroupBoxDktrContrls.Controls)
			{
				if (item.Tag != null)
				{
					item.BackColor = Color.Coral;

				}

			}

			MessageBox.Show("Kırmızı ALanları Doldurun Lütfen");

		}

		void data_Binding(Doktor doktor)
		{
			ClearDataBinding();

			CmBoxDktrBrans.DataBindings.Add("SelectedValue", doktor, "BransId",true);
			TxtDktrTcKmlkNo.DataBindings.Add("Text", doktor, "TC");
			TxtDktrAdi.DataBindings.Add("Text", doktor, "Adi");
			TxtDktrSydi.DataBindings.Add("Text", doktor, "Soyadi");
			TxtMskdDktrTlfnNo.DataBindings.Add("Text", doktor, "TelNo");
			TxtDktrEmail.DataBindings.Add("Text", doktor, "Email");
			TxtDktrDogmYri.DataBindings.Add("Text", doktor, "DogumYeri"); 
			dateTimePickerDktrDogmTrh.DataBindings.Add("Text", doktor, "DogumTarihi", true);
			TxtDoktorSifre.DataBindings.Add("Text", doktor, "Sifre"); 

		}

		void ClearDataBinding()
		{
			foreach (Control item in GroupBoxDktrContrls.Controls)
			{
				item.DataBindings.Clear();

			}
		}

		void EmptyDataBinding()
		{
			data_Binding(new Doktor());
		}



		private void BtnDktrCntrlTmzle_Click(object sender, EventArgs e)
		{
			EmptyDataBinding();

		}

		private void BtnDktrGnclle_Click(object sender, EventArgs e)
		{
			try
			{
				if (TxtDktrAdi.Text.Length > 0 && TxtDktrSydi.Text.Length > 0 && TxtDktrTcKmlkNo.Text.Length > 0 && TxtDoktorSifre.Text.Length > 0)
				{
					Doktor doktor = new Doktor
					{
						Id = doktorId,
						BransId = Convert.ToInt16(CmBoxDktrBrans.SelectedValue),
						Adi = TxtDktrAdi.Text,
						Soyadi = TxtDktrSydi.Text,
						TelNo = TxtMskdDktrTlfnNo.Text,
						TC = TxtDktrTcKmlkNo.Text,
						DogumTarihi = dateTimePickerDktrDogmTrh.Value.ToShortDateString(),
						DogumYeri = TxtDktrDogmYri.Text,
						Email = TxtDktrEmail.Text,
						Sifre = TxtDoktorSifre.Text


					};
					_doktorService.Update(doktor);

					MessageBox.Show("Doktor Güncelleme Başarılı.");
					S_DoctorForm_Load(sender, e);
					EmptyDataBinding();
				}



				else
				{
					DoktorBoslukKontrol();


				}
			}
			catch (Exception)
			{

				MessageBox.Show("Bir Hata Oldu");
			}

		}

		private void BtnDktrKydt_Click(object sender, EventArgs e)
		{

			if (TxtDktrAdi.Text.Length > 0 && TxtDktrSydi.Text.Length > 0 && TxtDktrTcKmlkNo.Text.Length > 0 && TxtDoktorSifre.Text.Length > 0)
			{
				var result = _doktorService.GetDoktorWithTc(TxtDktrTcKmlkNo.Text);

				if (result == null)
				{

					Doktor doktor = new Doktor
					{

						BransId = Convert.ToInt16(CmBoxDktrBrans.SelectedValue),
						Adi = TxtDktrAdi.Text,
						Soyadi = TxtDktrSydi.Text,
						TelNo = TxtMskdDktrTlfnNo.Text,
						TC = TxtDktrTcKmlkNo.Text,
						DogumTarihi = dateTimePickerDktrDogmTrh.Value.ToShortDateString(),
						DogumYeri = TxtDktrDogmYri.Text,
						Email = TxtDktrEmail.Text,
						Sifre = TxtDoktorSifre.Text

					};

					_doktorService.Add(doktor);

					S_DoctorForm_Load(sender, e);
					EmptyDataBinding();
					MessageBox.Show("Doktor Kaydı Başarılı");

				}

				else
				{
					MessageBox.Show("Bu TC Kimlik Numarası ile  Bir Sekrreter zaten Mevcut");
				}
			}

			else
			{
				DoktorBoslukKontrol();


			}

		}

		private void BtnDktrSil_Click(object sender, EventArgs e)
		{
			try
			{
				Doktor doktor = new Doktor()
				{
					Id = doktorId
				};

				_doktorService.Delete(doktor);
				S_DoctorForm_Load(sender, e);
				EmptyDataBinding();

			}
			catch (Exception)
			{

				MessageBox.Show("Bir Hata Oldu");
			}


		}

		private void TxtDktrAra_TextChanged(object sender, EventArgs e)
		{
			dataGridViewDktr_islmlri.DataSource = _doktorService.FilterByName(TxtDktrAra.Text);
		}

		
		private void BtnPage1DoktorSec_Click(object sender, EventArgs e)
		{
			try
			{
				doktorId = Convert.ToInt16(dataGridViewDktr_islmlri.Rows[dataGridViewDktr_islmlri.CurrentCell.RowIndex].Cells[0].Value);
				TabPageDoktorSecme.Hide();
				TabPageDoktorDuzenleme.Show();
				data_Binding(_doktorService.Get(doktorId));
			}
			catch (Exception)
			{

				MessageBox.Show(" Lütfen Önce Doktor Ekleyin");
			}
			

		}

		private void BtnPage2DoktorSec_Click(object sender, EventArgs e)
		{
			try
			{
				TabPageDoktorDuzenleme.Hide();
				TabPageDoktorSecme.Show();
			}
			catch (Exception)
			{

				MessageBox.Show("Lütfen Önce Doktor Ekleyin");
			}
			
		}

	}
}
