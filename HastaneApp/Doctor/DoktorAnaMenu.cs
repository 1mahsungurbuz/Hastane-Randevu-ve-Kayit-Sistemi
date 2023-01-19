using Business.Abstract;
using Entities.Concrete;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneApp.Doctor
{
	public partial class DoktorAnaMenu : Form
	{

		ITahlilService _tahlilService;
		ITahlilDetayService _tahlilDetayService;
		IDoktorTeshisService _doktorTeshisService;
		IHastaService _hastaService;
		IDoktorService _doktorService;
		IRandevuService _randevuService;

		int _hastaId;
		int _doktorId ;
		int _tahlilId;

		DoktorTeshis _hastaTeshisleri;
		Hasta _hasta;
		string _hastaDoktorinfo;



		public DoktorAnaMenu(ITahlilService tahlilService, ITahlilDetayService tahlilDetayService,
			IDoktorTeshisService doktorTeshisService, IHastaService hastaService,
			IDoktorService doktorService, IRandevuService randevuService, int doktorId)
		{
			_tahlilService = tahlilService;
			_tahlilDetayService = tahlilDetayService;
			_doktorTeshisService = doktorTeshisService;
			_hastaService = hastaService;
			_doktorService = doktorService;
			_randevuService = randevuService;

			_doktorId = doktorId;
			InitializeComponent();
		}


		private void BilgileriGetir()
		{
			DataGridViewHastaTeshisleri.DataSource = _doktorTeshisService.GetDoktorTeshisByHastaIdAndDoktorId(_hastaId, _doktorId);
			dataGridViewTahlilDetay.DataSource = _tahlilDetayService.GetTahlilDetayByHastaIdAndTahlilId(_hastaId, _tahlilId);


		}







		private void DoktorAnaMenu_Load(object sender, EventArgs e)
		{
			data_BindingForDoktor(_doktorService.Get(_doktorId));


			dataGridViewRnadevular.DataSource = _randevuService.GetRandevuDetailsByDoktorId(_doktorId);

			CmbBoxTahliller.DataSource = _tahlilService.GetAll();
			CmboBoxTahlilSec.DataSource = _tahlilService.GetAll();
			
		}

		private void BtnHastaSec_Click(object sender, EventArgs e)
		{
			
			

			try
			{
				_hastaId = Convert.ToInt16(dataGridViewRnadevular.Rows[dataGridViewRnadevular.CurrentCell.RowIndex].Cells[1].Value);

				data_Binding(_hastaService.Get(_hastaId));

				BilgileriGetir();

				pdfİşlemleriToolStripMenuItem.Visible = true;

			}
			catch (Exception)
			{

				MessageBox.Show("Seçili Randevu Yok");
			}

			

		}

		void ClearDataBinding()
		{
			foreach (Control item in groupBoxHastaBilgileri.Controls)
			{
				item.DataBindings.Clear();

			}
		}

		void ClearDataBindingForDoktor() 
		{
			foreach (Control item in groupBoxDoktorBilgileri.Controls)
			{
				item.DataBindings.Clear();

			}
		}

		void ClearDataForTahilller()
		{
			TxtRefernsDegeri.Text = "";
			TxtThlilSonuc.Text = "";
			TxtThlilSonucBirimi.Text = "";

		}

		void ClearDataForRichBox()
		{

			RichTextBoxTeshisBaslik.Text = "";
			RichTextBoxTeshisDetay.Text = "";


		}

		void data_Binding(Hasta hasta)
		{
			ClearDataBinding();

			LblHastaAdi.DataBindings.Add("Text", hasta, "Adi");
			LblHastaTC.DataBindings.Add("Text", hasta, "TC");
			LblHastaSoyadi.DataBindings.Add("Text", hasta, "Soyadi");
			
		}

		void data_BindingForDoktor(Doktor doktor)
		{
			ClearDataBindingForDoktor();


			LblDoktorAdi.DataBindings.Add("Text", doktor, "Adi");
			LblDoktorSoyadi.DataBindings.Add("Text", doktor, "Soyadi");

		}

		private void CmbBoxTahliller_SelectedIndexChanged(object sender, EventArgs e)
		{

			try
			{
				_tahlilId = Convert.ToInt16(CmbBoxTahliller.SelectedValue);
				dataGridViewTahlilDetay.DataSource = _tahlilDetayService.GetTahlilDetayByHastaIdAndTahlilId(_hastaId, _tahlilId);


			}
			catch (Exception)
			{

				MessageBox.Show("Yeniden Deneyin");
			}
		}

		private void BtnTahlilKaydet_Click(object sender, EventArgs e)
		{

			if (LblHastaTC.Text.Count()==0)
			{
				MessageBox.Show("Önce Hasta Seç");

			}

			else
			{
				if (TxtThlilSonuc.Text.Count() != 0 && TxtThlilSonucBirimi.Text.Count() != 0 && TxtRefernsDegeri.Text.Count() != 0)
				{
					try
					{
						TahlilDetay tahlilDetay = new TahlilDetay
						{
							TahlilId = Convert.ToInt16(CmboBoxTahlilSec.SelectedValue),
							ThlilSonuc = TxtThlilSonuc.Text,
							ThlilSonucBirimi = TxtThlilSonucBirimi.Text,
							ThlilReferansDegeri = TxtRefernsDegeri.Text,
							ThlilTarihi = DateTime.UtcNow,
							HastalId = _hastaId

						};
						_tahlilDetayService.Add(tahlilDetay);
						MessageBox.Show("Kayıt Ekleme Başarılı");
						ClearDataForTahilller();
						DoktorAnaMenu_Load(sender, e);

					}
					catch (Exception)
					{

						MessageBox.Show("Bir Hata Oldu");
					}

				}

				else
				{
					MessageBox.Show("Boş Alanları Doldurun");

				}

			}




		}

		private void BtnTeshisKaydet_Click(object sender, EventArgs e)
		{

			if (LblHastaTC.Text.Count() == 0)
			{
				MessageBox.Show("Önce Hasta Seç");

			}


			else
			{
				if (RichTextBoxTeshisBaslik.Text.Count() != 0 && RichTextBoxTeshisDetay.Text.Count() != 0)
				{
					try
					{
						DoktorTeshis doktorTeshis = new DoktorTeshis
						{
							TeshisBaslik = RichTextBoxTeshisBaslik.Text,
							TeshisDetay = RichTextBoxTeshisDetay.Text,
							HastaId = _hastaId,
							DoktorId = _doktorId,
							TeshisTarih = DateTime.UtcNow
						};

						_doktorTeshisService.Add(doktorTeshis);

						MessageBox.Show("Kayıt Ekleme Başarılı");
						ClearDataForRichBox();
						BilgileriGetir();

					}
					catch (Exception)
					{

						MessageBox.Show("Bir Hata Oldu");
					}

				}

				else
				{
					MessageBox.Show("Boş Alanları Doldur");

				}


			}

			

		}

		private void PDFOlusturToolStripMenuItem_Click(object sender, EventArgs e)
		{

			try
			{


				_hasta = _hastaService.Get(_hastaId);
				Doktor doktor = _doktorService.Get(_doktorId);
				_hastaTeshisleri = _doktorTeshisService.DoktorTeshisByHastaIdAndDoktorId(_hastaId, _doktorId);


				_hastaDoktorinfo = $"                                               TÜRKİYE CUMHURİYETİ SAĞLIK BAKANLIĞI \n " +
				   $"                                                                         BALKAN HASTANESİ \n\n" +
				   $"HASTA\n\n" +
				   $"ADI: {_hasta.Adi}\n" +
				   $"SOYADI: {_hasta.Soyadi}\n" +
				   $"DOĞUM TARİHİ: {_hasta.DogumTarihi}\n" +
				   $"DOĞUM YERİ: {_hasta.DogumYeri}\n" +
				   $"T.C NO : {_hasta.TC}\n\n" +
				   $"-------------------------------------------------------\n" +
				   $"DOKTOR \n\n" +
				   $"ADI: {doktor.Adi}\n" +
				   $"SOYADI: {doktor.Soyadi}\n\n" +
				   $"**************************************************************************************************" +
				   $"                                            " +
				   $"                                    DOKTOR GÖRÜŞÜ\n" +
				   $"{_hastaTeshisleri.TeshisDetay}";



				var document = new Document();
				PdfWriter.GetInstance(document, new FileStream($"C:/{_hasta.Adi}.pdf", FileMode.Create, FileAccess.ReadWrite));

				document.Open();


				BaseFont STF_Helvetica_Turkish = BaseFont.CreateFont("Helvetica", "CP1254", BaseFont.NOT_EMBEDDED);

				iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);





				Paragraph HastaDoktorparagraf = new Paragraph(_hastaDoktorinfo, fontNormal);

				document.Add(HastaDoktorparagraf);

				document.Close();



				MessageBox.Show($" PDF C:/'Dizininde {_hasta.Adi}.pdf İsmiyle Oluşturuldu");

			}
			catch (Exception)
			{

				MessageBox.Show("Lütfen Görüş ekledikten sonra PDF Oluşturun.");
			}

			


		}

		private void HastayaMailGonderToolStripMenuItem_Click(object sender, EventArgs e)
		{

			try
			{

				string hastaEpostaAdresi = Microsoft.VisualBasic.Interaction.InputBox("Hasta Email Adresi Girin", "E Posta Gönderme", $"{_hasta.Email}", 320, 320);


				SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
				smtpClient.EnableSsl = true;
				smtpClient.Credentials = new NetworkCredential("hastaneeposta@outlook.com", "H1s2t3a4n5e");


				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress("hastaneeposta@outlook.com");
				mailMessage.To.Add(hastaEpostaAdresi);
				mailMessage.Subject = "Doktor Görüşme Kayıtları";
				mailMessage.IsBodyHtml = true;
				mailMessage.Body = _hastaDoktorinfo;

				smtpClient.Send(mailMessage);

				MessageBox.Show("Hastaya Görüşme Kaydı Gönderildi.");

			}
			catch (Exception)
			{

				MessageBox.Show("İnternete Bağlı Olduğunuzdan  Ya Da Kayıt Eklediğinizden Emin Olun.", "E-Posta Gönderme Hatası");
			}
		}

		private void dateTimePickerRandevuSırala_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				string tarih = dateTimePickerRandevuSırala.Value.ToString("MM/dd/yy");

				dataGridViewRnadevular.DataSource = _randevuService.RandevuDetailsByTimeAndDoktorId(tarih,_doktorId); 

			}
			catch (Exception)
			{
				MessageBox.Show("Bir Hata Oldu");

			}


		}
	}
}
