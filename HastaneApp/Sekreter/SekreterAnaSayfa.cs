using Business.Abstract;
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
	
	public partial class S_SecretaryHomeForm : Form
	{
		IDoktorService _doktorService;
		IHastaService _hastaService;
		ISekreterService _sekreterService;
		IBransService _bransService;
		IRandevuService _randevuService;


		public S_SecretaryHomeForm(
			IDoktorService doktorService, 
			IHastaService hastaService,
			ISekreterService sekreterService,
			IBransService bransService, 
			IRandevuService randevuService)
		{
			_doktorService = doktorService;
			_hastaService = hastaService;
			_sekreterService = sekreterService;
			_bransService = bransService;
			_randevuService = randevuService;
			InitializeComponent();
		}

		public void RenkDegistir(ToolStripMenuItem toolStripMenuItem)
		{
			if (randevuOluşturToolStripMenuItem == toolStripMenuItem)
			{
				randevuOluşturToolStripMenuItem.BackColor = Color.Cyan;
				hastaİşlemleriToolStripMenuItem.BackColor = Color.Gainsboro;
				doktorİşlemleriToolStripMenuItem.BackColor = Color.WhiteSmoke;
				sekreterİşlermleriiToolStripMenuItem.BackColor = Color.Gainsboro;
				grafiklerToolStripMenuItem.BackColor = Color.WhiteSmoke;

			}

			if (hastaİşlemleriToolStripMenuItem == toolStripMenuItem)
			{
				hastaİşlemleriToolStripMenuItem.BackColor = Color.Cyan;

				randevuOluşturToolStripMenuItem.BackColor = Color.WhiteSmoke;
				doktorİşlemleriToolStripMenuItem.BackColor = Color.WhiteSmoke;
				sekreterİşlermleriiToolStripMenuItem.BackColor = Color.Gainsboro;
				grafiklerToolStripMenuItem.BackColor = Color.WhiteSmoke;

			}

			if (doktorİşlemleriToolStripMenuItem == toolStripMenuItem)
			{
				doktorİşlemleriToolStripMenuItem.BackColor = Color.Cyan;

				randevuOluşturToolStripMenuItem.BackColor = Color.WhiteSmoke;
				hastaİşlemleriToolStripMenuItem.BackColor = Color.Gainsboro;
				sekreterİşlermleriiToolStripMenuItem.BackColor = Color.WhiteSmoke;
				grafiklerToolStripMenuItem.BackColor = Color.Gainsboro;

			}

			if (sekreterİşlermleriiToolStripMenuItem == toolStripMenuItem)
			{
				sekreterİşlermleriiToolStripMenuItem.BackColor = Color.Cyan;

				hastaİşlemleriToolStripMenuItem.BackColor = Color.Gainsboro;
				randevuOluşturToolStripMenuItem.BackColor = Color.WhiteSmoke;
				doktorİşlemleriToolStripMenuItem.BackColor = Color.Gainsboro;
				grafiklerToolStripMenuItem.BackColor = Color.WhiteSmoke;

			}
			
			if (grafiklerToolStripMenuItem == toolStripMenuItem)
			{
				grafiklerToolStripMenuItem.BackColor = Color.Cyan;

				randevuOluşturToolStripMenuItem.BackColor = Color.WhiteSmoke;
				hastaİşlemleriToolStripMenuItem.BackColor = Color.Gainsboro;
				doktorİşlemleriToolStripMenuItem.BackColor = Color.WhiteSmoke;
				sekreterİşlermleriiToolStripMenuItem.BackColor = Color.Gainsboro;

			}



		}
	


		private void randevuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RenkDegistir(randevuOluşturToolStripMenuItem);
			panel1.Controls.Clear();
			RandevuOlusturma s_AppointmentForm = new RandevuOlusturma(_hastaService, _bransService, _doktorService, _randevuService);
			s_AppointmentForm.MdiParent = this;
			s_AppointmentForm.FormBorderStyle = FormBorderStyle.None;
			panel1.Controls.Add(s_AppointmentForm);
			s_AppointmentForm.Show();
		}

		private void hastaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RenkDegistir(hastaİşlemleriToolStripMenuItem);
			panel1.Controls.Clear();
			HastaEkleme s_PatientForm = new HastaEkleme(_hastaService);
			s_PatientForm.MdiParent = this;
			s_PatientForm.FormBorderStyle = FormBorderStyle.None;
			panel1.Controls.Add(s_PatientForm);
			s_PatientForm.Show();
		}

		private void doktorİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RenkDegistir(doktorİşlemleriToolStripMenuItem);

			panel1.Controls.Clear();
			DoktorEkleme s_DoctorForm = new DoktorEkleme(_doktorService, _bransService);
			s_DoctorForm.MdiParent = this;
			s_DoctorForm.FormBorderStyle = FormBorderStyle.None;
			panel1.Controls.Add(s_DoctorForm);
			s_DoctorForm.Show();
		}

		private void sekreterİşlermleriiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RenkDegistir(sekreterİşlermleriiToolStripMenuItem);

			panel1.Controls.Clear();
			SekreterEkleme s_SecretaryForm = new SekreterEkleme(_sekreterService);
			s_SecretaryForm.MdiParent = this;
			s_SecretaryForm.FormBorderStyle = FormBorderStyle.None;
			panel1.Controls.Add(s_SecretaryForm);
			s_SecretaryForm.Show();
		}

		private void grafiklerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RenkDegistir(grafiklerToolStripMenuItem);

			panel1.Controls.Clear();
			Grafikler s_GrafiklerForm = new Grafikler( _randevuService);
			s_GrafiklerForm.MdiParent = this;
			s_GrafiklerForm.FormBorderStyle = FormBorderStyle.None;
			panel1.Controls.Add(s_GrafiklerForm);
			s_GrafiklerForm.Show();
		}
	}
	
}
