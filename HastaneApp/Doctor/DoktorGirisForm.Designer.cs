namespace HastaneApp.Doctor
{
	partial class DoktorGirisForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnDktrGiris = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.TxtTC = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 435);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.BtnDktrGiris);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.TxtSifre);
			this.panel1.Controls.Add(this.TxtTC);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(464, 429);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(9, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 32);
			this.label2.TabIndex = 20;
			this.label2.Text = "TC Kimlik No";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(89, 231);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 32);
			this.label1.TabIndex = 19;
			this.label1.Text = "Şifre";
			// 
			// BtnDktrGiris
			// 
			this.BtnDktrGiris.BackColor = System.Drawing.Color.Cyan;
			this.BtnDktrGiris.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnDktrGiris.Location = new System.Drawing.Point(216, 331);
			this.BtnDktrGiris.Name = "BtnDktrGiris";
			this.BtnDktrGiris.Size = new System.Drawing.Size(144, 43);
			this.BtnDktrGiris.TabIndex = 12;
			this.BtnDktrGiris.Text = "Giriş Yap";
			this.BtnDktrGiris.UseVisualStyleBackColor = false;
			this.BtnDktrGiris.Click += new System.EventHandler(this.BtnDktrGiris_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(152, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(166, 37);
			this.label5.TabIndex = 11;
			this.label5.Text = "Doktor Girişi";
			// 
			// TxtSifre
			// 
			this.TxtSifre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtSifre.Location = new System.Drawing.Point(187, 231);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.Size = new System.Drawing.Size(199, 36);
			this.TxtSifre.TabIndex = 10;
			this.TxtSifre.Tag = "*";
			// 
			// TxtTC
			// 
			this.TxtTC.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtTC.Location = new System.Drawing.Point(187, 134);
			this.TxtTC.MaxLength = 11;
			this.TxtTC.Name = "TxtTC";
			this.TxtTC.Size = new System.Drawing.Size(199, 36);
			this.TxtTC.TabIndex = 8;
			this.TxtTC.Tag = "*";
			// 
			// DoktorGirisForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 435);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "DoktorGirisForm";
			this.Text = "Doktor Giriş Sayfası";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel1;
		private Button BtnDktrGiris;
		private Label label5;
		private TextBox TxtSifre;
		private TextBox TxtTC;
		private Label label2;
		private Label label1;
	}
}