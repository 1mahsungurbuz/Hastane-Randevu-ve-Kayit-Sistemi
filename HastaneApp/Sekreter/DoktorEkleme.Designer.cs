namespace HastaneApp.Secretary
{
	partial class DoktorEkleme
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.BtnDktrSil = new System.Windows.Forms.Button();
			this.BtnDktrKydt = new System.Windows.Forms.Button();
			this.BtnDktrGnclle = new System.Windows.Forms.Button();
			this.BtnDktrCntrlTmzle = new System.Windows.Forms.Button();
			this.GroupBoxDktrContrls = new System.Windows.Forms.GroupBox();
			this.TxtDoktorSifre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnPage2DoktorSec = new System.Windows.Forms.Button();
			this.LblDktrBrans = new System.Windows.Forms.Label();
			this.LblDktrAdi = new System.Windows.Forms.Label();
			this.CmBoxDktrBrans = new System.Windows.Forms.ComboBox();
			this.TxtDktrAdi = new System.Windows.Forms.TextBox();
			this.LblDktrTelNo = new System.Windows.Forms.Label();
			this.TxtDktrEmail = new System.Windows.Forms.TextBox();
			this.TxtDktrSydi = new System.Windows.Forms.TextBox();
			this.LblDktrEmail = new System.Windows.Forms.Label();
			this.TxtMskdDktrTlfnNo = new System.Windows.Forms.MaskedTextBox();
			this.TxtDktrDogmYri = new System.Windows.Forms.TextBox();
			this.LblDktrSyadi = new System.Windows.Forms.Label();
			this.LblDktrDgmTrh = new System.Windows.Forms.Label();
			this.LblDktrDgmYri = new System.Windows.Forms.Label();
			this.dateTimePickerDktrDogmTrh = new System.Windows.Forms.DateTimePicker();
			this.TxtDktrTcKmlkNo = new System.Windows.Forms.TextBox();
			this.LblDktrTcKmlkNo = new System.Windows.Forms.Label();
			this.durumBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.TxtDktrAra = new System.Windows.Forms.TextBox();
			this.LblDktrAra = new System.Windows.Forms.Label();
			this.dataGridViewDktr_islmlri = new System.Windows.Forms.DataGridView();
			this.doktorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TabPageDoktorSecme = new System.Windows.Forms.TabPage();
			this.BtnPage1DoktorSec = new System.Windows.Forms.Button();
			this.TabPageDoktorDuzenleme = new System.Windows.Forms.TabPage();
			this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bransIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dogumYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GroupBoxDktrContrls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.durumBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDktr_islmlri)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.TabPageDoktorSecme.SuspendLayout();
			this.TabPageDoktorDuzenleme.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnDktrSil
			// 
			this.BtnDktrSil.BackColor = System.Drawing.Color.Red;
			this.BtnDktrSil.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnDktrSil.Location = new System.Drawing.Point(727, 347);
			this.BtnDktrSil.Name = "BtnDktrSil";
			this.BtnDktrSil.Size = new System.Drawing.Size(127, 49);
			this.BtnDktrSil.TabIndex = 31;
			this.BtnDktrSil.Text = "Sil";
			this.BtnDktrSil.UseVisualStyleBackColor = false;
			this.BtnDktrSil.Click += new System.EventHandler(this.BtnDktrSil_Click);
			// 
			// BtnDktrKydt
			// 
			this.BtnDktrKydt.BackColor = System.Drawing.Color.Lime;
			this.BtnDktrKydt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnDktrKydt.Location = new System.Drawing.Point(574, 347);
			this.BtnDktrKydt.Name = "BtnDktrKydt";
			this.BtnDktrKydt.Size = new System.Drawing.Size(118, 49);
			this.BtnDktrKydt.TabIndex = 30;
			this.BtnDktrKydt.Text = "Kaydet";
			this.BtnDktrKydt.UseVisualStyleBackColor = false;
			this.BtnDktrKydt.Click += new System.EventHandler(this.BtnDktrKydt_Click);
			// 
			// BtnDktrGnclle
			// 
			this.BtnDktrGnclle.BackColor = System.Drawing.Color.Yellow;
			this.BtnDktrGnclle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnDktrGnclle.Location = new System.Drawing.Point(727, 257);
			this.BtnDktrGnclle.Name = "BtnDktrGnclle";
			this.BtnDktrGnclle.Size = new System.Drawing.Size(127, 49);
			this.BtnDktrGnclle.TabIndex = 29;
			this.BtnDktrGnclle.Text = "Güncelle";
			this.BtnDktrGnclle.UseVisualStyleBackColor = false;
			this.BtnDktrGnclle.Click += new System.EventHandler(this.BtnDktrGnclle_Click);
			// 
			// BtnDktrCntrlTmzle
			// 
			this.BtnDktrCntrlTmzle.BackColor = System.Drawing.Color.Tomato;
			this.BtnDktrCntrlTmzle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnDktrCntrlTmzle.Location = new System.Drawing.Point(574, 260);
			this.BtnDktrCntrlTmzle.Name = "BtnDktrCntrlTmzle";
			this.BtnDktrCntrlTmzle.Size = new System.Drawing.Size(118, 49);
			this.BtnDktrCntrlTmzle.TabIndex = 27;
			this.BtnDktrCntrlTmzle.Text = "Temizle";
			this.BtnDktrCntrlTmzle.UseVisualStyleBackColor = false;
			this.BtnDktrCntrlTmzle.Click += new System.EventHandler(this.BtnDktrCntrlTmzle_Click);
			// 
			// GroupBoxDktrContrls
			// 
			this.GroupBoxDktrContrls.Controls.Add(this.TxtDoktorSifre);
			this.GroupBoxDktrContrls.Controls.Add(this.label2);
			this.GroupBoxDktrContrls.Controls.Add(this.BtnPage2DoktorSec);
			this.GroupBoxDktrContrls.Controls.Add(this.BtnDktrSil);
			this.GroupBoxDktrContrls.Controls.Add(this.BtnDktrKydt);
			this.GroupBoxDktrContrls.Controls.Add(this.BtnDktrGnclle);
			this.GroupBoxDktrContrls.Controls.Add(this.BtnDktrCntrlTmzle);
			this.GroupBoxDktrContrls.Controls.Add(this.LblDktrBrans);
			this.GroupBoxDktrContrls.Controls.Add(this.LblDktrAdi);
			this.GroupBoxDktrContrls.Controls.Add(this.CmBoxDktrBrans);
			this.GroupBoxDktrContrls.Controls.Add(this.TxtDktrAdi);
			this.GroupBoxDktrContrls.Controls.Add(this.LblDktrTelNo);
			this.GroupBoxDktrContrls.Controls.Add(this.TxtDktrEmail);
			this.GroupBoxDktrContrls.Controls.Add(this.TxtDktrSydi);
			this.GroupBoxDktrContrls.Controls.Add(this.LblDktrEmail);
			this.GroupBoxDktrContrls.Controls.Add(this.TxtMskdDktrTlfnNo);
			this.GroupBoxDktrContrls.Controls.Add(this.TxtDktrDogmYri);
			this.GroupBoxDktrContrls.Controls.Add(this.LblDktrSyadi);
			this.GroupBoxDktrContrls.Controls.Add(this.LblDktrDgmTrh);
			this.GroupBoxDktrContrls.Controls.Add(this.LblDktrDgmYri);
			this.GroupBoxDktrContrls.Controls.Add(this.dateTimePickerDktrDogmTrh);
			this.GroupBoxDktrContrls.Controls.Add(this.TxtDktrTcKmlkNo);
			this.GroupBoxDktrContrls.Controls.Add(this.LblDktrTcKmlkNo);
			this.GroupBoxDktrContrls.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBoxDktrContrls.Location = new System.Drawing.Point(3, 3);
			this.GroupBoxDktrContrls.Name = "GroupBoxDktrContrls";
			this.GroupBoxDktrContrls.Size = new System.Drawing.Size(941, 475);
			this.GroupBoxDktrContrls.TabIndex = 45;
			this.GroupBoxDktrContrls.TabStop = false;
			// 
			// TxtDoktorSifre
			// 
			this.TxtDoktorSifre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtDoktorSifre.Location = new System.Drawing.Point(236, 187);
			this.TxtDoktorSifre.Name = "TxtDoktorSifre";
			this.TxtDoktorSifre.Size = new System.Drawing.Size(208, 32);
			this.TxtDoktorSifre.TabIndex = 51;
			this.TxtDoktorSifre.Tag = "*";
			this.TxtDoktorSifre.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(125, 186);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 30);
			this.label2.TabIndex = 50;
			this.label2.Text = "Şifre";
			// 
			// BtnPage2DoktorSec
			// 
			this.BtnPage2DoktorSec.BackColor = System.Drawing.Color.Cyan;
			this.BtnPage2DoktorSec.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnPage2DoktorSec.Location = new System.Drawing.Point(635, 167);
			this.BtnPage2DoktorSec.Name = "BtnPage2DoktorSec";
			this.BtnPage2DoktorSec.Size = new System.Drawing.Size(153, 52);
			this.BtnPage2DoktorSec.TabIndex = 49;
			this.BtnPage2DoktorSec.Text = "Doktor Seç";
			this.BtnPage2DoktorSec.UseVisualStyleBackColor = false;
			this.BtnPage2DoktorSec.Click += new System.EventHandler(this.BtnPage2DoktorSec_Click);
			// 
			// LblDktrBrans
			// 
			this.LblDktrBrans.AutoSize = true;
			this.LblDktrBrans.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblDktrBrans.Location = new System.Drawing.Point(519, 33);
			this.LblDktrBrans.Name = "LblDktrBrans";
			this.LblDktrBrans.Size = new System.Drawing.Size(71, 30);
			this.LblDktrBrans.TabIndex = 44;
			this.LblDktrBrans.Text = "Branşı";
			// 
			// LblDktrAdi
			// 
			this.LblDktrAdi.AutoSize = true;
			this.LblDktrAdi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblDktrAdi.Location = new System.Drawing.Point(133, 28);
			this.LblDktrAdi.Name = "LblDktrAdi";
			this.LblDktrAdi.Size = new System.Drawing.Size(45, 30);
			this.LblDktrAdi.TabIndex = 18;
			this.LblDktrAdi.Text = "Adı";
			// 
			// CmBoxDktrBrans
			// 
			this.CmBoxDktrBrans.DisplayMember = "BransAdi";
			this.CmBoxDktrBrans.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CmBoxDktrBrans.FormattingEnabled = true;
			this.CmBoxDktrBrans.Location = new System.Drawing.Point(615, 31);
			this.CmBoxDktrBrans.Name = "CmBoxDktrBrans";
			this.CmBoxDktrBrans.Size = new System.Drawing.Size(205, 33);
			this.CmBoxDktrBrans.TabIndex = 43;
			this.CmBoxDktrBrans.Tag = "*";
			this.CmBoxDktrBrans.ValueMember = "Id";
			// 
			// TxtDktrAdi
			// 
			this.TxtDktrAdi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtDktrAdi.Location = new System.Drawing.Point(233, 26);
			this.TxtDktrAdi.Name = "TxtDktrAdi";
			this.TxtDktrAdi.Size = new System.Drawing.Size(206, 32);
			this.TxtDktrAdi.TabIndex = 19;
			this.TxtDktrAdi.Tag = "*";
			// 
			// LblDktrTelNo
			// 
			this.LblDktrTelNo.AutoSize = true;
			this.LblDktrTelNo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblDktrTelNo.Location = new System.Drawing.Point(98, 299);
			this.LblDktrTelNo.Name = "LblDktrTelNo";
			this.LblDktrTelNo.Size = new System.Drawing.Size(75, 30);
			this.LblDktrTelNo.TabIndex = 20;
			this.LblDktrTelNo.Text = "Tel No";
			// 
			// TxtDktrEmail
			// 
			this.TxtDktrEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtDktrEmail.Location = new System.Drawing.Point(234, 417);
			this.TxtDktrEmail.Name = "TxtDktrEmail";
			this.TxtDktrEmail.Size = new System.Drawing.Size(222, 32);
			this.TxtDktrEmail.TabIndex = 41;
			// 
			// TxtDktrSydi
			// 
			this.TxtDktrSydi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtDktrSydi.Location = new System.Drawing.Point(234, 83);
			this.TxtDktrSydi.Name = "TxtDktrSydi";
			this.TxtDktrSydi.Size = new System.Drawing.Size(206, 32);
			this.TxtDktrSydi.TabIndex = 21;
			this.TxtDktrSydi.Tag = "*";
			// 
			// LblDktrEmail
			// 
			this.LblDktrEmail.AutoSize = true;
			this.LblDktrEmail.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblDktrEmail.Location = new System.Drawing.Point(115, 409);
			this.LblDktrEmail.Name = "LblDktrEmail";
			this.LblDktrEmail.Size = new System.Drawing.Size(64, 30);
			this.LblDktrEmail.TabIndex = 40;
			this.LblDktrEmail.Text = "Email";
			// 
			// TxtMskdDktrTlfnNo
			// 
			this.TxtMskdDktrTlfnNo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtMskdDktrTlfnNo.Location = new System.Drawing.Point(236, 297);
			this.TxtMskdDktrTlfnNo.Mask = "(999) 000-0000";
			this.TxtMskdDktrTlfnNo.Name = "TxtMskdDktrTlfnNo";
			this.TxtMskdDktrTlfnNo.Size = new System.Drawing.Size(208, 32);
			this.TxtMskdDktrTlfnNo.TabIndex = 22;
			// 
			// TxtDktrDogmYri
			// 
			this.TxtDktrDogmYri.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtDktrDogmYri.Location = new System.Drawing.Point(236, 239);
			this.TxtDktrDogmYri.Name = "TxtDktrDogmYri";
			this.TxtDktrDogmYri.Size = new System.Drawing.Size(206, 32);
			this.TxtDktrDogmYri.TabIndex = 39;
			// 
			// LblDktrSyadi
			// 
			this.LblDktrSyadi.AutoSize = true;
			this.LblDktrSyadi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblDktrSyadi.Location = new System.Drawing.Point(104, 78);
			this.LblDktrSyadi.Name = "LblDktrSyadi";
			this.LblDktrSyadi.Size = new System.Drawing.Size(78, 30);
			this.LblDktrSyadi.TabIndex = 23;
			this.LblDktrSyadi.Text = "Soyadı";
			// 
			// LblDktrDgmTrh
			// 
			this.LblDktrDgmTrh.AutoSize = true;
			this.LblDktrDgmTrh.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblDktrDgmTrh.Location = new System.Drawing.Point(47, 344);
			this.LblDktrDgmTrh.Name = "LblDktrDgmTrh";
			this.LblDktrDgmTrh.Size = new System.Drawing.Size(142, 30);
			this.LblDktrDgmTrh.TabIndex = 38;
			this.LblDktrDgmTrh.Text = "Dogum Tarihi";
			// 
			// LblDktrDgmYri
			// 
			this.LblDktrDgmYri.AutoSize = true;
			this.LblDktrDgmYri.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblDktrDgmYri.Location = new System.Drawing.Point(63, 241);
			this.LblDktrDgmYri.Name = "LblDktrDgmYri";
			this.LblDktrDgmYri.Size = new System.Drawing.Size(126, 30);
			this.LblDktrDgmYri.TabIndex = 25;
			this.LblDktrDgmYri.Text = "Dogum Yeri";
			// 
			// dateTimePickerDktrDogmTrh
			// 
			this.dateTimePickerDktrDogmTrh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dateTimePickerDktrDogmTrh.Location = new System.Drawing.Point(234, 349);
			this.dateTimePickerDktrDogmTrh.Name = "dateTimePickerDktrDogmTrh";
			this.dateTimePickerDktrDogmTrh.Size = new System.Drawing.Size(306, 32);
			this.dateTimePickerDktrDogmTrh.TabIndex = 36;
			// 
			// TxtDktrTcKmlkNo
			// 
			this.TxtDktrTcKmlkNo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtDktrTcKmlkNo.Location = new System.Drawing.Point(236, 132);
			this.TxtDktrTcKmlkNo.MaxLength = 11;
			this.TxtDktrTcKmlkNo.Name = "TxtDktrTcKmlkNo";
			this.TxtDktrTcKmlkNo.Size = new System.Drawing.Size(206, 32);
			this.TxtDktrTcKmlkNo.TabIndex = 35;
			this.TxtDktrTcKmlkNo.Tag = "*";
			// 
			// LblDktrTcKmlkNo
			// 
			this.LblDktrTcKmlkNo.AutoSize = true;
			this.LblDktrTcKmlkNo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblDktrTcKmlkNo.Location = new System.Drawing.Point(47, 127);
			this.LblDktrTcKmlkNo.Name = "LblDktrTcKmlkNo";
			this.LblDktrTcKmlkNo.Size = new System.Drawing.Size(148, 30);
			this.LblDktrTcKmlkNo.TabIndex = 34;
			this.LblDktrTcKmlkNo.Text = "T.C. Kimlik No";
			// 
			// TxtDktrAra
			// 
			this.TxtDktrAra.Location = new System.Drawing.Point(385, 9);
			this.TxtDktrAra.Name = "TxtDktrAra";
			this.TxtDktrAra.Size = new System.Drawing.Size(209, 32);
			this.TxtDktrAra.TabIndex = 31;
			this.TxtDktrAra.TextChanged += new System.EventHandler(this.TxtDktrAra_TextChanged);
			// 
			// LblDktrAra
			// 
			this.LblDktrAra.AutoSize = true;
			this.LblDktrAra.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblDktrAra.Location = new System.Drawing.Point(308, 9);
			this.LblDktrAra.Name = "LblDktrAra";
			this.LblDktrAra.Size = new System.Drawing.Size(46, 30);
			this.LblDktrAra.TabIndex = 30;
			this.LblDktrAra.Text = "Ara";
			// 
			// dataGridViewDktr_islmlri
			// 
			this.dataGridViewDktr_islmlri.AllowUserToDeleteRows = false;
			this.dataGridViewDktr_islmlri.AutoGenerateColumns = false;
			this.dataGridViewDktr_islmlri.BackgroundColor = System.Drawing.Color.Silver;
			this.dataGridViewDktr_islmlri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDktr_islmlri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.bransIdDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.tCDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.telNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dogumYeriDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn});
			this.dataGridViewDktr_islmlri.DataSource = this.doktorBindingSource;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewDktr_islmlri.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewDktr_islmlri.Location = new System.Drawing.Point(3, 48);
			this.dataGridViewDktr_islmlri.Name = "dataGridViewDktr_islmlri";
			this.dataGridViewDktr_islmlri.ReadOnly = true;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Brown;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridViewDktr_islmlri.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewDktr_islmlri.RowTemplate.Height = 25;
			this.dataGridViewDktr_islmlri.RowTemplate.ReadOnly = true;
			this.dataGridViewDktr_islmlri.Size = new System.Drawing.Size(941, 346);
			this.dataGridViewDktr_islmlri.TabIndex = 17;
			// 
			// doktorBindingSource
			// 
			this.doktorBindingSource.DataSource = typeof(Entities.Concrete.Doktor);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TabPageDoktorSecme);
			this.tabControl1.Controls.Add(this.TabPageDoktorDuzenleme);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(955, 519);
			this.tabControl1.TabIndex = 3;
			// 
			// TabPageDoktorSecme
			// 
			this.TabPageDoktorSecme.BackColor = System.Drawing.Color.Silver;
			this.TabPageDoktorSecme.Controls.Add(this.BtnPage1DoktorSec);
			this.TabPageDoktorSecme.Controls.Add(this.dataGridViewDktr_islmlri);
			this.TabPageDoktorSecme.Controls.Add(this.TxtDktrAra);
			this.TabPageDoktorSecme.Controls.Add(this.LblDktrAra);
			this.TabPageDoktorSecme.Location = new System.Drawing.Point(4, 34);
			this.TabPageDoktorSecme.Name = "TabPageDoktorSecme";
			this.TabPageDoktorSecme.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageDoktorSecme.Size = new System.Drawing.Size(947, 481);
			this.TabPageDoktorSecme.TabIndex = 0;
			this.TabPageDoktorSecme.Text = "Doktor Bilgi Görüntüleme";
			// 
			// BtnPage1DoktorSec
			// 
			this.BtnPage1DoktorSec.BackColor = System.Drawing.Color.Cyan;
			this.BtnPage1DoktorSec.Location = new System.Drawing.Point(420, 418);
			this.BtnPage1DoktorSec.Name = "BtnPage1DoktorSec";
			this.BtnPage1DoktorSec.Size = new System.Drawing.Size(129, 46);
			this.BtnPage1DoktorSec.TabIndex = 32;
			this.BtnPage1DoktorSec.Text = "Doktor Seç";
			this.BtnPage1DoktorSec.UseVisualStyleBackColor = false;
			this.BtnPage1DoktorSec.Click += new System.EventHandler(this.BtnPage1DoktorSec_Click);
			// 
			// TabPageDoktorDuzenleme
			// 
			this.TabPageDoktorDuzenleme.BackColor = System.Drawing.Color.Silver;
			this.TabPageDoktorDuzenleme.Controls.Add(this.GroupBoxDktrContrls);
			this.TabPageDoktorDuzenleme.Location = new System.Drawing.Point(4, 34);
			this.TabPageDoktorDuzenleme.Name = "TabPageDoktorDuzenleme";
			this.TabPageDoktorDuzenleme.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageDoktorDuzenleme.Size = new System.Drawing.Size(947, 481);
			this.TabPageDoktorDuzenleme.TabIndex = 1;
			this.TabPageDoktorDuzenleme.Text = "Doktor Bilgi Ekleme ve Düzenleme";
			// 
			// ıdDataGridViewTextBoxColumn
			// 
			this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
			this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
			this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bransIdDataGridViewTextBoxColumn
			// 
			this.bransIdDataGridViewTextBoxColumn.DataPropertyName = "BransId";
			this.bransIdDataGridViewTextBoxColumn.HeaderText = "BransId";
			this.bransIdDataGridViewTextBoxColumn.Name = "bransIdDataGridViewTextBoxColumn";
			this.bransIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sifreDataGridViewTextBoxColumn
			// 
			this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
			this.sifreDataGridViewTextBoxColumn.HeaderText = "Doktor\'un Şifresi";
			this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
			this.sifreDataGridViewTextBoxColumn.ReadOnly = true;
			this.sifreDataGridViewTextBoxColumn.Visible = false;
			// 
			// tCDataGridViewTextBoxColumn
			// 
			this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
			this.tCDataGridViewTextBoxColumn.HeaderText = "Doktor TC";
			this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
			this.tCDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// adiDataGridViewTextBoxColumn
			// 
			this.adiDataGridViewTextBoxColumn.DataPropertyName = "Adi";
			this.adiDataGridViewTextBoxColumn.HeaderText = "Doktor Adı";
			this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
			this.adiDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// soyadiDataGridViewTextBoxColumn
			// 
			this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "Soyadi";
			this.soyadiDataGridViewTextBoxColumn.HeaderText = "Doktor Soyadı";
			this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
			this.soyadiDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// telNoDataGridViewTextBoxColumn
			// 
			this.telNoDataGridViewTextBoxColumn.DataPropertyName = "TelNo";
			this.telNoDataGridViewTextBoxColumn.HeaderText = "Doktor Telefon No";
			this.telNoDataGridViewTextBoxColumn.Name = "telNoDataGridViewTextBoxColumn";
			this.telNoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Doktor E-mail";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dogumYeriDataGridViewTextBoxColumn
			// 
			this.dogumYeriDataGridViewTextBoxColumn.DataPropertyName = "DogumYeri";
			this.dogumYeriDataGridViewTextBoxColumn.HeaderText = "Doktor Dogum Yeri";
			this.dogumYeriDataGridViewTextBoxColumn.Name = "dogumYeriDataGridViewTextBoxColumn";
			this.dogumYeriDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dogumTarihiDataGridViewTextBoxColumn
			// 
			this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
			this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doktor Dogum Tarihi";
			this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
			this.dogumTarihiDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// DoktorEkleme
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(955, 519);
			this.Controls.Add(this.tabControl1);
			this.Name = "DoktorEkleme";
			this.Text = "Doktor Ekleme  ve Düzenleme";
			this.Load += new System.EventHandler(this.S_DoctorForm_Load);
			this.GroupBoxDktrContrls.ResumeLayout(false);
			this.GroupBoxDktrContrls.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.durumBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDktr_islmlri)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.doktorBindingSource)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.TabPageDoktorSecme.ResumeLayout(false);
			this.TabPageDoktorSecme.PerformLayout();
			this.TabPageDoktorDuzenleme.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Button BtnDktrSil;
		private Button BtnDktrKydt;
		private Button BtnDktrGnclle;
		private Button BtnDktrCntrlTmzle;
		private TextBox TxtDktrEmail;
		private Label LblDktrEmail;
		private TextBox TxtDktrDogmYri;
		private Label LblDktrDgmTrh;
		private DateTimePicker dateTimePickerDktrDogmTrh;
		private TextBox TxtDktrTcKmlkNo;
		private Label LblDktrTcKmlkNo;
		private Label LblDktrAra;
		private Label LblDktrDgmYri;
		private Label LblDktrSyadi;
		private MaskedTextBox TxtMskdDktrTlfnNo;
		private TextBox TxtDktrSydi;
		private Label LblDktrTelNo;
		private TextBox TxtDktrAdi;
		private Label LblDktrAdi;
		private DataGridView dataGridViewDktr_islmlri;
		private Label LblDktrBrans;
		private ComboBox CmBoxDktrBrans;
		private DataGridViewTextBoxColumn dktrIdDataGridViewTextBoxColumn;
		private GroupBox GroupBoxDktrContrls;
		private TextBox TxtDktrAra;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn DurumId;
		private DataGridViewTextBoxColumn TC;
		private DataGridViewTextBoxColumn Adi;
		private DataGridViewTextBoxColumn Soyadi;
		private DataGridViewTextBoxColumn TelNo;
		private DataGridViewTextBoxColumn Email;
		private DataGridViewTextBoxColumn DogumYeri;
		private DataGridViewTextBoxColumn DogumTarihi;
		private BindingSource durumBindingSource;
		private DataGridViewTextBoxColumn DktrId;
		private DataGridViewTextBoxColumn DktrDurumId;
		private DataGridViewTextBoxColumn DktrTC;
		private DataGridViewTextBoxColumn DktrAdi;
		private DataGridViewTextBoxColumn DktrSoyadi;
		private DataGridViewTextBoxColumn DktrTelNo;
		private DataGridViewTextBoxColumn DktrEmail;
		private DataGridViewTextBoxColumn DktrDogumYeri;
		private DataGridViewTextBoxColumn DktrDogumTarihi;
		private TabControl tabControl1;
		private TabPage TabPageDoktorSecme;
		private TabPage TabPageDoktorDuzenleme;
		private Button BtnPage1DoktorSec;
		private Button BtnPage2DoktorSec;
		private TextBox TxtDoktorSifre;
		private Label label2;
		private BindingSource doktorBindingSource;
		private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bransIdDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn telNoDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dogumYeriDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
	}
}