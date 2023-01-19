namespace HastaneApp.Secretary
{
	partial class Grafikler
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.GrafikPages = new System.Windows.Forms.TabControl();
			this.HastaDoktorGrafikPage = new System.Windows.Forms.TabPage();
			this.pieChartHastaDoktor = new LiveCharts.WinForms.PieChart();
			this.HastaBolumGrafikPage = new System.Windows.Forms.TabPage();
			this.pieChartHastaBolum = new LiveCharts.WinForms.PieChart();
			this.GrafikPages.SuspendLayout();
			this.HastaDoktorGrafikPage.SuspendLayout();
			this.HastaBolumGrafikPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// GrafikPages
			// 
			this.GrafikPages.Controls.Add(this.HastaDoktorGrafikPage);
			this.GrafikPages.Controls.Add(this.HastaBolumGrafikPage);
			this.GrafikPages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GrafikPages.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.GrafikPages.Location = new System.Drawing.Point(0, 0);
			this.GrafikPages.Name = "GrafikPages";
			this.GrafikPages.SelectedIndex = 0;
			this.GrafikPages.Size = new System.Drawing.Size(955, 519);
			this.GrafikPages.TabIndex = 0;
			// 
			// HastaDoktorGrafikPage
			// 
			this.HastaDoktorGrafikPage.Controls.Add(this.pieChartHastaDoktor);
			this.HastaDoktorGrafikPage.Location = new System.Drawing.Point(4, 34);
			this.HastaDoktorGrafikPage.Name = "HastaDoktorGrafikPage";
			this.HastaDoktorGrafikPage.Padding = new System.Windows.Forms.Padding(3);
			this.HastaDoktorGrafikPage.Size = new System.Drawing.Size(947, 481);
			this.HastaDoktorGrafikPage.TabIndex = 0;
			this.HastaDoktorGrafikPage.Text = "Hasta-Doktor Grafiği";
			this.HastaDoktorGrafikPage.UseVisualStyleBackColor = true;
			this.HastaDoktorGrafikPage.Click += new System.EventHandler(this.HastaDoktorGrafikPage_Click);
			// 
			// pieChartHastaDoktor
			// 
			this.pieChartHastaDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pieChartHastaDoktor.Location = new System.Drawing.Point(3, 3);
			this.pieChartHastaDoktor.Name = "pieChartHastaDoktor";
			this.pieChartHastaDoktor.Size = new System.Drawing.Size(941, 475);
			this.pieChartHastaDoktor.TabIndex = 0;
			this.pieChartHastaDoktor.Text = "pieChart1";
			// 
			// HastaBolumGrafikPage
			// 
			this.HastaBolumGrafikPage.Controls.Add(this.pieChartHastaBolum);
			this.HastaBolumGrafikPage.Location = new System.Drawing.Point(4, 34);
			this.HastaBolumGrafikPage.Name = "HastaBolumGrafikPage";
			this.HastaBolumGrafikPage.Padding = new System.Windows.Forms.Padding(3);
			this.HastaBolumGrafikPage.Size = new System.Drawing.Size(947, 481);
			this.HastaBolumGrafikPage.TabIndex = 1;
			this.HastaBolumGrafikPage.Text = "Hasta-Bolum Grafiği";
			this.HastaBolumGrafikPage.UseVisualStyleBackColor = true;
			this.HastaBolumGrafikPage.Click += new System.EventHandler(this.HastaBolumGrafikPage_Click);
			// 
			// pieChartHastaBolum
			// 
			this.pieChartHastaBolum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pieChartHastaBolum.Location = new System.Drawing.Point(3, 3);
			this.pieChartHastaBolum.Name = "pieChartHastaBolum";
			this.pieChartHastaBolum.Size = new System.Drawing.Size(941, 475);
			this.pieChartHastaBolum.TabIndex = 3;
			this.pieChartHastaBolum.Text = "pieChart1";
			// 
			// Grafikler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(955, 519);
			this.Controls.Add(this.GrafikPages);
			this.Name = "Grafikler";
			this.Text = "Hasta-Doktor   Hasta-Bölüm Grafikleri";
			this.Load += new System.EventHandler(this.S_GrafiklerForm_Load);
			this.GrafikPages.ResumeLayout(false);
			this.HastaDoktorGrafikPage.ResumeLayout(false);
			this.HastaBolumGrafikPage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private TabControl GrafikPages;
		private TabPage HastaDoktorGrafikPage;
		private LiveCharts.WinForms.PieChart pieChartHastaDoktor;
		private TabPage HastaBolumGrafikPage;
		private LiveCharts.WinForms.PieChart pieChartHastaBolum;
	}
}