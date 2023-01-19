namespace HastaneApp.Secretary
{
	partial class SekreterGiris
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
			this.BtnSkrtrGiris = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.TxtTc = new System.Windows.Forms.TextBox();
			this.TxtSifre = new System.Windows.Forms.TextBox();
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
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.BtnSkrtrGiris);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.TxtTc);
			this.panel1.Controls.Add(this.TxtSifre);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(464, 429);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(8, 156);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 30);
			this.label2.TabIndex = 18;
			this.label2.Text = "TC Kimlik No";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(62, 237);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 30);
			this.label1.TabIndex = 17;
			this.label1.Text = "Şifre";
			// 
			// BtnSkrtrGiris
			// 
			this.BtnSkrtrGiris.BackColor = System.Drawing.Color.Cyan;
			this.BtnSkrtrGiris.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnSkrtrGiris.Location = new System.Drawing.Point(206, 316);
			this.BtnSkrtrGiris.Name = "BtnSkrtrGiris";
			this.BtnSkrtrGiris.Size = new System.Drawing.Size(119, 52);
			this.BtnSkrtrGiris.TabIndex = 16;
			this.BtnSkrtrGiris.Text = "Giriş Yap";
			this.BtnSkrtrGiris.UseVisualStyleBackColor = false;
			this.BtnSkrtrGiris.Click += new System.EventHandler(this.BtnSkrtrGiris_Click_1);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(151, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(200, 41);
			this.label5.TabIndex = 15;
			this.label5.Text = "Sekreter Girişi";
			// 
			// TxtTc
			// 
			this.TxtTc.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtTc.Location = new System.Drawing.Point(179, 156);
			this.TxtTc.MaxLength = 11;
			this.TxtTc.Name = "TxtTc";
			this.TxtTc.Size = new System.Drawing.Size(197, 34);
			this.TxtTc.TabIndex = 13;
			this.TxtTc.Tag = "*";
			// 
			// TxtSifre
			// 
			this.TxtSifre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtSifre.Location = new System.Drawing.Point(179, 237);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.Size = new System.Drawing.Size(197, 34);
			this.TxtSifre.TabIndex = 14;
			this.TxtSifre.Tag = "*";
			// 
			// SekreterGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 435);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "SekreterGiris";
			this.Text = "Sekreter Giriş";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel1;
		private Button BtnSkrtrGiris;
		private Label label5;
		private TextBox TxtTc;
		private TextBox TxtSifre;
		private Label label2;
		private Label label1;
	}
}