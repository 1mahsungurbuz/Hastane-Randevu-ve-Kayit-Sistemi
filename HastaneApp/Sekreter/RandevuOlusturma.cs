using Business.Abstract;
using Entities.Concrete;
using Microsoft.Reporting.Map.WebForms.BingMaps;
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
	public partial class RandevuOlusturma : Form
	{
		IHastaService _hastaService;
		IBransService _bransService;
		IDoktorService _doktorService;
		IRandevuService _randevuService;
		int id;
		public RandevuOlusturma(IHastaService hastaService, IBransService bransService, IDoktorService doktorService, IRandevuService randevuService)
		{
			_hastaService = hastaService;
			_bransService = bransService;
			_doktorService = doktorService;
			_randevuService = randevuService;
			InitializeComponent();

		}

		private void S_Appointment_Form_Load(object sender, EventArgs e)
		{
			dataGridViewHstaRndv_islmlri.DataSource = _hastaService.GetAll();
			CmBoxBlmSec.DataSource = _bransService.GetAll();
			dataGridViewRandevular.DataSource = _randevuService.RandevuAyrintilari();
		}

		void ClearDataBindingForPolklink()
		{
			foreach (Control item in GroupBoxPlknkKontrl.Controls)
			{
				item.DataBindings.Clear();

			}
		}

		void RandevuSaatiBelirle()
		{
			var randevuSaati = _randevuService.GetAll(id);

			foreach (var Dbitem in randevuSaati)
			{
				if (Dbitem.Tarih == DateTimePickerRandevuTarihi.Value.ToString("MM/dd/yy"))
				{
					foreach (Control frmItem in GroupBoxRandevuSaati.Controls)
					{

						if (frmItem.Text == Dbitem.Saat)
						{
							frmItem.BackColor = Color.Red;

						}




					}

				}

			}


		}

		private void CmBoxBlmSec_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int id = Convert.ToInt16(CmBoxBlmSec.SelectedValue);
				dataGridViewDktrSec.DataSource = _doktorService.GetDoktorByBransId(id);
				ClearDataBindingForPolklink();
				TxtPolklnkId.Text = id.ToString();
				TxtPolknk.Text = CmBoxBlmSec.Text;


			}
			catch (Exception)
			{

				MessageBox.Show("Yeniden Deneyin");
			}

		}


		void ClearDataBinding()
		{
			foreach (Control item in GroupBoxHstaControl.Controls)
			{
				item.DataBindings.Clear();

			}
		}



		void ClearDataBindingForDoktor()
		{
			foreach (Control item in GroupBoxDktrControls.Controls)
			{

				item.DataBindings.Clear();

			}
		}
		void DataBindingForRandevuSaati()
		{
			foreach (Control item in GroupBoxRandevuSaati.Controls)
			{


				if (item.GetType() == typeof(Button))
				{
					item.BackColor = Color.Cyan;
				}

			}
		}



		private void BtnPage2DoktorSec_Click(object sender, EventArgs e)
		{
			try
			{
				DataBindingForRandevuSaati();

				id = Convert.ToInt16(dataGridViewDktrSec.Rows[dataGridViewDktrSec.CurrentCell.RowIndex].Cells[0].Value);
				RandevuSaatiBelirle();
				TabPageDoktorSec.Hide();
				TabPageRandevuOlustur.Show();
				data_Bindingg(_doktorService.Get(id));
				TxtRandevuSaati.Text = "";

			}
			catch (Exception)
			{

				MessageBox.Show(" Lütfen Önce Doktor Ekleyin");
			}



		}

		void data_Bindingg(Doktor doktor)
		{
			ClearDataBindingForDoktor();

			TxtDktrId.DataBindings.Add("Text", doktor, "Id");
			TxtDktrAdi.DataBindings.Add("Text", doktor, "Adi");
			TxtDktrSydi.DataBindings.Add("Text", doktor, "Soyadi");
		}


		void data_Binding(Hasta hasta)
		{
			ClearDataBinding();

			TxtHstaId.DataBindings.Add("Text", hasta, "Id");
			TxtHstaAdi.DataBindings.Add("Text", hasta, "Adi");
			TxtHstaSoyadi.DataBindings.Add("Text", hasta, "Soyadi");
		}


		private void BtnPageHastaSec_Click(object sender, EventArgs e)
		{
			try
			{
				int id = Convert.ToInt16(dataGridViewHstaRndv_islmlri.Rows[dataGridViewHstaRndv_islmlri.CurrentCell.RowIndex].Cells[0].Value);
				TabPageHastaSec.Hide();
				TabPageRandevuOlustur.Show();
				data_Binding(_hastaService.Get(id));
			}
			catch (Exception)
			{

				MessageBox.Show("Lütfen Önce Hasta Ekleyin");
			}


		}

		private void BtnDoktorSec_Click(object sender, EventArgs e)
		{
			TabPageRandevuOlustur.Hide();
			TabPageDoktorSec.Show();
		}

		private void BtnHastaSec_Click(object sender, EventArgs e)
		{
			TabPageRandevuOlustur.Hide();
			TabPageHastaSec.Show();
		}

		private void BtnRandevuOnay_Click(object sender, EventArgs e)
		{
			if (TxtDktrId.Text.Length > 0 && TxtHstaId.Text.Length > 0 && TxtRandevuSaati.Text.Length>0)
			{

				Randevu randevu = new Randevu
				{
					DoktorId = Convert.ToInt16(TxtDktrId.Text),
					HastaId = Convert.ToInt16(TxtHstaId.Text),
					Saat = TxtRandevuSaati.Text,
					Tarih = DateTimePickerRandevuTarihi.Value.ToString("MM/dd/yy")
				};

				_randevuService.Add(randevu);
				DataBindingForRandevuSaati();

				RandevuSaatiBelirle();
				TxtRandevuSaati.Text = "";
				MessageBox.Show("Randevu Oluşturuldu.", "Başarılı");

				dataGridViewRandevular.DataSource = _randevuService.RandevuAyrintilari();


			}



			else
			{
				foreach (Control item in TabPageRandevuOlustur.Controls)
				{
					if (item.Tag != null)
					{
						item.BackColor = Color.Coral;

					}

				}


				MessageBox.Show("Kırmızı ALanları Doldurun Lütfen");
			}

		}



		public void randevuSaatiSec(object sender, EventArgs args)

		{


			if ((sender as Button).BackColor == Color.Red)
			{
				MessageBox.Show("Bu Saat için Randevu Mevcut");

			}

			else
			{
				TxtRandevuSaati.Text = (sender as Button).Text;


			}


		}

		private void DateTimePickerRandevuTarihi_ValueChanged(object sender, EventArgs e)
		{
			BtnPage2DoktorSec_Click(sender, e);

			//LblTarih.Text = DateTimePickerRandevuTarihi.Value.ToShortDateString();

			TxtRandevuSaati.Text = "";
		


		}
	

		private void BtnRandevuSil_Click(object sender, EventArgs e)
		{
			try
			{
				int id = Convert.ToInt16(dataGridViewRandevular.Rows[dataGridViewRandevular.CurrentCell.RowIndex].Cells[0].Value);

				Randevu randevu = new Randevu
				{
					Id = id
				};
				_randevuService.Delete(randevu);
				MessageBox.Show("Randevu Silindi", "Silme Başarrılı.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				dataGridViewRandevular.DataSource = _randevuService.RandevuAyrintilari();

			}
			catch (Exception)
			{
				MessageBox.Show("Henüz Randevu Yok");
			}




		}

		private void DateTimePickerRandevuSirala_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				string tarih = DateTimePickerRandevuSirala.Value.ToString("MM/dd/yy");

				dataGridViewRandevular.DataSource = _randevuService.RandevuDetailsByTime(tarih);

			}
			catch (Exception)
			{
				MessageBox.Show("Bir Hata Oldu");

			}
			

		}
	}
}

