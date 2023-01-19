namespace HastaneApp.Login
{
	partial class GirisForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
			this.BtbDktrGiris = new System.Windows.Forms.Button();
			this.BtnSkrtrGiris = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.Panel();
			this.BtnSekreterHesapSil = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtbDktrGiris
			// 
			this.BtbDktrGiris.Image = ((System.Drawing.Image)(resources.GetObject("BtbDktrGiris.Image")));
			this.BtbDktrGiris.Location = new System.Drawing.Point(-5, 2);
			this.BtbDktrGiris.Name = "BtbDktrGiris";
			this.BtbDktrGiris.Size = new System.Drawing.Size(241, 431);
			this.BtbDktrGiris.TabIndex = 7;
			this.BtbDktrGiris.UseVisualStyleBackColor = true;
			this.BtbDktrGiris.Click += new System.EventHandler(this.BtbDktrGiris_Click);
			// 
			// BtnSkrtrGiris
			// 
			this.BtnSkrtrGiris.BackColor = System.Drawing.Color.Gainsboro;
			this.BtnSkrtrGiris.Image = ((System.Drawing.Image)(resources.GetObject("BtnSkrtrGiris.Image")));
			this.BtnSkrtrGiris.Location = new System.Drawing.Point(696, 2);
			this.BtnSkrtrGiris.Name = "BtnSkrtrGiris";
			this.BtnSkrtrGiris.Size = new System.Drawing.Size(241, 431);
			this.BtnSkrtrGiris.TabIndex = 1;
			this.BtnSkrtrGiris.UseVisualStyleBackColor = false;
			this.BtnSkrtrGiris.Click += new System.EventHandler(this.BtnSkrtrGiris_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(235, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 431);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// BtnSekreterHesapSil
			// 
			this.BtnSekreterHesapSil.BackColor = System.Drawing.Color.LightGray;
			this.BtnSekreterHesapSil.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnSekreterHesapSil.Location = new System.Drawing.Point(696, 2);
			this.BtnSekreterHesapSil.Name = "BtnSekreterHesapSil";
			this.BtnSekreterHesapSil.Size = new System.Drawing.Size(231, 36);
			this.BtnSekreterHesapSil.TabIndex = 21;
			this.BtnSekreterHesapSil.Text = "Şifre Sıfırlama";
			this.BtnSekreterHesapSil.UseVisualStyleBackColor = false;
			this.BtnSekreterHesapSil.Click += new System.EventHandler(this.BtnSekreterHesapSil_Click);
			// 
			// GirisForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 433);
			this.Controls.Add(this.BtnSekreterHesapSil);
			this.Controls.Add(this.BtnSkrtrGiris);
			this.Controls.Add(this.BtbDktrGiris);
			this.Controls.Add(this.tableLayoutPanel1);
			this.IsMdiContainer = true;
			this.Name = "GirisForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hastane Randevu Sistem Girişi";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private Button BtnSkrtrGiris;
		private Button BtbDktrGiris;
		private Panel tableLayoutPanel1;
		private Button BtnSekreterHesapSil;
	}
}