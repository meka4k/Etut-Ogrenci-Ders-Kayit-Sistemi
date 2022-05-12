
namespace OgrenciEtutKayıt
{
    partial class EtutKayıtPanel
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EtutKayıtPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEtutOlustur = new System.Windows.Forms.Button();
            this.LabelSaat = new System.Windows.Forms.Label();
            this.labelTarih = new System.Windows.Forms.Label();
            this.labelOgretmen = new System.Windows.Forms.Label();
            this.labelDers = new System.Windows.Forms.Label();
            this.maskedTextBoxSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTarih = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxOgretmen = new System.Windows.Forms.ComboBox();
            this.comboBoxDers = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEtutVer = new System.Windows.Forms.Button();
            this.labelOgrenci = new System.Windows.Forms.Label();
            this.labelEtutID = new System.Windows.Forms.Label();
            this.textBoxOgrenci = new System.Windows.Forms.TextBox();
            this.textBoxEtutID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ButtonRaporla = new System.Windows.Forms.Button();
            this.buttontemizle = new System.Windows.Forms.Button();
            this.buttonFotograf = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kapatmabuton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxTCNo = new System.Windows.Forms.MaskedTextBox();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelSinif = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.maskedTextBoxTelefon = new System.Windows.Forms.MaskedTextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxSinif = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonOgrtEkle = new System.Windows.Forms.Button();
            this.labelOgrtDers = new System.Windows.Forms.Label();
            this.labelOgrtSoyad = new System.Windows.Forms.Label();
            this.LabelOgrtAd = new System.Windows.Forms.Label();
            this.comboBoxOgrtDers = new System.Windows.Forms.ComboBox();
            this.textBoxOgrtSoyad = new System.Windows.Forms.TextBox();
            this.textBoxOgrtAd = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxogrenciid = new System.Windows.Forms.TextBox();
            this.buttonguncelle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.buttonEtutOlustur);
            this.groupBox1.Controls.Add(this.LabelSaat);
            this.groupBox1.Controls.Add(this.labelTarih);
            this.groupBox1.Controls.Add(this.labelOgretmen);
            this.groupBox1.Controls.Add(this.labelDers);
            this.groupBox1.Controls.Add(this.maskedTextBoxSaat);
            this.groupBox1.Controls.Add(this.maskedTextBoxTarih);
            this.groupBox1.Controls.Add(this.comboBoxOgretmen);
            this.groupBox1.Controls.Add(this.comboBoxDers);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etüt Kayıt Paneli";
            // 
            // buttonEtutOlustur
            // 
            this.buttonEtutOlustur.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEtutOlustur.Location = new System.Drawing.Point(108, 148);
            this.buttonEtutOlustur.Name = "buttonEtutOlustur";
            this.buttonEtutOlustur.Size = new System.Drawing.Size(103, 23);
            this.buttonEtutOlustur.TabIndex = 8;
            this.buttonEtutOlustur.Text = "Etüt Oluştur";
            this.buttonEtutOlustur.UseVisualStyleBackColor = true;
            this.buttonEtutOlustur.Click += new System.EventHandler(this.buttonEtutOlustur_Click);
            // 
            // LabelSaat
            // 
            this.LabelSaat.AutoSize = true;
            this.LabelSaat.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSaat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelSaat.Location = new System.Drawing.Point(45, 117);
            this.LabelSaat.Name = "LabelSaat";
            this.LabelSaat.Size = new System.Drawing.Size(38, 17);
            this.LabelSaat.TabIndex = 7;
            this.LabelSaat.Text = "Saat:";
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarih.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTarih.Location = new System.Drawing.Point(38, 91);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(46, 17);
            this.labelTarih.TabIndex = 6;
            this.labelTarih.Text = "Tarih:";
            // 
            // labelOgretmen
            // 
            this.labelOgretmen.AutoSize = true;
            this.labelOgretmen.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOgretmen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOgretmen.Location = new System.Drawing.Point(15, 55);
            this.labelOgretmen.Name = "labelOgretmen";
            this.labelOgretmen.Size = new System.Drawing.Size(69, 17);
            this.labelOgretmen.TabIndex = 5;
            this.labelOgretmen.Text = "Öğretmen:";
            // 
            // labelDers
            // 
            this.labelDers.AutoSize = true;
            this.labelDers.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDers.Location = new System.Drawing.Point(45, 25);
            this.labelDers.Name = "labelDers";
            this.labelDers.Size = new System.Drawing.Size(39, 17);
            this.labelDers.TabIndex = 4;
            this.labelDers.Text = "Ders:";
            // 
            // maskedTextBoxSaat
            // 
            this.maskedTextBoxSaat.Location = new System.Drawing.Point(90, 114);
            this.maskedTextBoxSaat.Mask = "00:00";
            this.maskedTextBoxSaat.Name = "maskedTextBoxSaat";
            this.maskedTextBoxSaat.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxSaat.TabIndex = 3;
            this.maskedTextBoxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxTarih
            // 
            this.maskedTextBoxTarih.Location = new System.Drawing.Point(90, 88);
            this.maskedTextBoxTarih.Mask = "00/00/0000";
            this.maskedTextBoxTarih.Name = "maskedTextBoxTarih";
            this.maskedTextBoxTarih.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxTarih.TabIndex = 2;
            this.maskedTextBoxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxOgretmen
            // 
            this.comboBoxOgretmen.FormattingEnabled = true;
            this.comboBoxOgretmen.Location = new System.Drawing.Point(90, 52);
            this.comboBoxOgretmen.Name = "comboBoxOgretmen";
            this.comboBoxOgretmen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOgretmen.TabIndex = 1;
            // 
            // comboBoxDers
            // 
            this.comboBoxDers.FormattingEnabled = true;
            this.comboBoxDers.Location = new System.Drawing.Point(90, 25);
            this.comboBoxDers.Name = "comboBoxDers";
            this.comboBoxDers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDers.TabIndex = 0;
            this.comboBoxDers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDers_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.buttonEtutVer);
            this.groupBox2.Controls.Add(this.labelOgrenci);
            this.groupBox2.Controls.Add(this.labelEtutID);
            this.groupBox2.Controls.Add(this.textBoxOgrenci);
            this.groupBox2.Controls.Add(this.textBoxEtutID);
            this.groupBox2.Location = new System.Drawing.Point(284, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğretmen Etüt Oluşturma Paneli";
            // 
            // buttonEtutVer
            // 
            this.buttonEtutVer.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEtutVer.Location = new System.Drawing.Point(147, 83);
            this.buttonEtutVer.Name = "buttonEtutVer";
            this.buttonEtutVer.Size = new System.Drawing.Size(103, 23);
            this.buttonEtutVer.TabIndex = 9;
            this.buttonEtutVer.Text = "Etüt Ver";
            this.buttonEtutVer.UseVisualStyleBackColor = true;
            this.buttonEtutVer.Click += new System.EventHandler(this.buttonEtutVer_Click);
            // 
            // labelOgrenci
            // 
            this.labelOgrenci.AutoSize = true;
            this.labelOgrenci.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOgrenci.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOgrenci.Location = new System.Drawing.Point(52, 57);
            this.labelOgrenci.Name = "labelOgrenci";
            this.labelOgrenci.Size = new System.Drawing.Size(58, 17);
            this.labelOgrenci.TabIndex = 6;
            this.labelOgrenci.Text = "Öğrenci:";
            // 
            // labelEtutID
            // 
            this.labelEtutID.AutoSize = true;
            this.labelEtutID.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtutID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEtutID.Location = new System.Drawing.Point(50, 22);
            this.labelEtutID.Name = "labelEtutID";
            this.labelEtutID.Size = new System.Drawing.Size(60, 17);
            this.labelEtutID.TabIndex = 5;
            this.labelEtutID.Text = "Etüt ID:";
            // 
            // textBoxOgrenci
            // 
            this.textBoxOgrenci.Location = new System.Drawing.Point(118, 54);
            this.textBoxOgrenci.Name = "textBoxOgrenci";
            this.textBoxOgrenci.Size = new System.Drawing.Size(132, 20);
            this.textBoxOgrenci.TabIndex = 1;
            // 
            // textBoxEtutID
            // 
            this.textBoxEtutID.Enabled = false;
            this.textBoxEtutID.Location = new System.Drawing.Point(118, 19);
            this.textBoxEtutID.Name = "textBoxEtutID";
            this.textBoxEtutID.Size = new System.Drawing.Size(132, 20);
            this.textBoxEtutID.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.ButtonRaporla);
            this.groupBox3.Controls.Add(this.buttontemizle);
            this.groupBox3.Controls.Add(this.buttonFotograf);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.maskedTextBoxTCNo);
            this.groupBox3.Controls.Add(this.buttonOgrenciEkle);
            this.groupBox3.Controls.Add(this.labelMail);
            this.groupBox3.Controls.Add(this.labelTelefon);
            this.groupBox3.Controls.Add(this.labelSinif);
            this.groupBox3.Controls.Add(this.labelSoyad);
            this.groupBox3.Controls.Add(this.labelAd);
            this.groupBox3.Controls.Add(this.maskedTextBoxTelefon);
            this.groupBox3.Controls.Add(this.textBoxMail);
            this.groupBox3.Controls.Add(this.textBoxSinif);
            this.groupBox3.Controls.Add(this.textBoxSoyad);
            this.groupBox3.Controls.Add(this.textBoxAd);
            this.groupBox3.Location = new System.Drawing.Point(12, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 210);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci Kayıt Paneli";
            // 
            // ButtonRaporla
            // 
            this.ButtonRaporla.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRaporla.Location = new System.Drawing.Point(526, 176);
            this.ButtonRaporla.Name = "ButtonRaporla";
            this.ButtonRaporla.Size = new System.Drawing.Size(67, 30);
            this.ButtonRaporla.TabIndex = 14;
            this.ButtonRaporla.Text = "Raporlar";
            this.ButtonRaporla.UseVisualStyleBackColor = true;
            this.ButtonRaporla.Click += new System.EventHandler(this.ButtonRaporla_Click);
            // 
            // buttontemizle
            // 
            this.buttontemizle.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontemizle.Location = new System.Drawing.Point(6, 177);
            this.buttontemizle.Name = "buttontemizle";
            this.buttontemizle.Size = new System.Drawing.Size(79, 24);
            this.buttontemizle.TabIndex = 13;
            this.buttontemizle.Text = "Temizle";
            this.buttontemizle.UseVisualStyleBackColor = true;
            this.buttontemizle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonFotograf
            // 
            this.buttonFotograf.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFotograf.Location = new System.Drawing.Point(390, 178);
            this.buttonFotograf.Name = "buttonFotograf";
            this.buttonFotograf.Size = new System.Drawing.Size(112, 25);
            this.buttonFotograf.TabIndex = 6;
            this.buttonFotograf.Text = "Fotoğraf Yükle";
            this.buttonFotograf.UseVisualStyleBackColor = true;
            this.buttonFotograf.Click += new System.EventHandler(this.buttonFotograf_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Controls.Add(this.kapatmabuton);
            this.groupBox7.Location = new System.Drawing.Point(347, 14);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(223, 143);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kapatmabuton
            // 
            this.kapatmabuton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.kapatmabuton.Location = new System.Drawing.Point(134, 81);
            this.kapatmabuton.Name = "kapatmabuton";
            this.kapatmabuton.Size = new System.Drawing.Size(59, 20);
            this.kapatmabuton.TabIndex = 11;
            this.kapatmabuton.Text = "Kapat";
            this.kapatmabuton.UseVisualStyleBackColor = true;
            this.kapatmabuton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "TC No:";
            // 
            // maskedTextBoxTCNo
            // 
            this.maskedTextBoxTCNo.Location = new System.Drawing.Point(75, 148);
            this.maskedTextBoxTCNo.Mask = "0000000000";
            this.maskedTextBoxTCNo.Name = "maskedTextBoxTCNo";
            this.maskedTextBoxTCNo.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBoxTCNo.TabIndex = 5;
            this.maskedTextBoxTCNo.ValidatingType = typeof(int);
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(108, 179);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(103, 23);
            this.buttonOgrenciEkle.TabIndex = 10;
            this.buttonOgrenciEkle.Text = "Öğrenci Ekle";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = true;
            this.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEkle_Click);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMail.Location = new System.Drawing.Point(30, 125);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(41, 17);
            this.labelMail.TabIndex = 9;
            this.labelMail.Text = "Mail:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTelefon.Location = new System.Drawing.Point(14, 99);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(57, 17);
            this.labelTelefon.TabIndex = 8;
            this.labelTelefon.Text = "Telefon:";
            // 
            // labelSinif
            // 
            this.labelSinif.AutoSize = true;
            this.labelSinif.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSinif.Location = new System.Drawing.Point(29, 73);
            this.labelSinif.Name = "labelSinif";
            this.labelSinif.Size = new System.Drawing.Size(42, 17);
            this.labelSinif.TabIndex = 7;
            this.labelSinif.Text = "Sınıf:";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoyad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSoyad.Location = new System.Drawing.Point(24, 47);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(47, 17);
            this.labelSoyad.TabIndex = 6;
            this.labelSoyad.Text = "Soyad:";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAd.Location = new System.Drawing.Point(43, 17);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(28, 17);
            this.labelAd.TabIndex = 5;
            this.labelAd.Text = "Ad:";
            // 
            // maskedTextBoxTelefon
            // 
            this.maskedTextBoxTelefon.Location = new System.Drawing.Point(75, 96);
            this.maskedTextBoxTelefon.Mask = "(999) 000-0000";
            this.maskedTextBoxTelefon.Name = "maskedTextBoxTelefon";
            this.maskedTextBoxTelefon.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBoxTelefon.TabIndex = 3;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(75, 122);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(132, 20);
            this.textBoxMail.TabIndex = 4;
            // 
            // textBoxSinif
            // 
            this.textBoxSinif.Location = new System.Drawing.Point(75, 70);
            this.textBoxSinif.Name = "textBoxSinif";
            this.textBoxSinif.Size = new System.Drawing.Size(132, 20);
            this.textBoxSinif.TabIndex = 2;
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(75, 44);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(132, 20);
            this.textBoxSoyad.TabIndex = 1;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(75, 14);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(132, 20);
            this.textBoxAd.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.buttonOgrtEkle);
            this.groupBox4.Controls.Add(this.labelOgrtDers);
            this.groupBox4.Controls.Add(this.labelOgrtSoyad);
            this.groupBox4.Controls.Add(this.LabelOgrtAd);
            this.groupBox4.Controls.Add(this.comboBoxOgrtDers);
            this.groupBox4.Controls.Add(this.textBoxOgrtSoyad);
            this.groupBox4.Controls.Add(this.textBoxOgrtAd);
            this.groupBox4.Location = new System.Drawing.Point(12, 516);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(604, 210);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Öğretmen Kayıt Paneli";
            // 
            // buttonOgrtEkle
            // 
            this.buttonOgrtEkle.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOgrtEkle.Location = new System.Drawing.Point(193, 124);
            this.buttonOgrtEkle.Name = "buttonOgrtEkle";
            this.buttonOgrtEkle.Size = new System.Drawing.Size(172, 23);
            this.buttonOgrtEkle.TabIndex = 9;
            this.buttonOgrtEkle.Text = "Öğretmen Ekle";
            this.buttonOgrtEkle.UseVisualStyleBackColor = true;
            this.buttonOgrtEkle.Click += new System.EventHandler(this.buttonOgrtEkle_Click);
            // 
            // labelOgrtDers
            // 
            this.labelOgrtDers.AutoSize = true;
            this.labelOgrtDers.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOgrtDers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOgrtDers.Location = new System.Drawing.Point(136, 93);
            this.labelOgrtDers.Name = "labelOgrtDers";
            this.labelOgrtDers.Size = new System.Drawing.Size(39, 17);
            this.labelOgrtDers.TabIndex = 7;
            this.labelOgrtDers.Text = "Ders:";
            // 
            // labelOgrtSoyad
            // 
            this.labelOgrtSoyad.AutoSize = true;
            this.labelOgrtSoyad.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOgrtSoyad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOgrtSoyad.Location = new System.Drawing.Point(128, 62);
            this.labelOgrtSoyad.Name = "labelOgrtSoyad";
            this.labelOgrtSoyad.Size = new System.Drawing.Size(47, 17);
            this.labelOgrtSoyad.TabIndex = 6;
            this.labelOgrtSoyad.Text = "Soyad:";
            // 
            // LabelOgrtAd
            // 
            this.LabelOgrtAd.AutoSize = true;
            this.LabelOgrtAd.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOgrtAd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelOgrtAd.Location = new System.Drawing.Point(147, 32);
            this.LabelOgrtAd.Name = "LabelOgrtAd";
            this.LabelOgrtAd.Size = new System.Drawing.Size(28, 17);
            this.LabelOgrtAd.TabIndex = 5;
            this.LabelOgrtAd.Text = "Ad:";
            // 
            // comboBoxOgrtDers
            // 
            this.comboBoxOgrtDers.FormattingEnabled = true;
            this.comboBoxOgrtDers.Location = new System.Drawing.Point(181, 89);
            this.comboBoxOgrtDers.Name = "comboBoxOgrtDers";
            this.comboBoxOgrtDers.Size = new System.Drawing.Size(184, 21);
            this.comboBoxOgrtDers.TabIndex = 4;
            // 
            // textBoxOgrtSoyad
            // 
            this.textBoxOgrtSoyad.Location = new System.Drawing.Point(181, 59);
            this.textBoxOgrtSoyad.Name = "textBoxOgrtSoyad";
            this.textBoxOgrtSoyad.Size = new System.Drawing.Size(184, 20);
            this.textBoxOgrtSoyad.TabIndex = 3;
            // 
            // textBoxOgrtAd
            // 
            this.textBoxOgrtAd.Location = new System.Drawing.Point(181, 30);
            this.textBoxOgrtAd.Name = "textBoxOgrtAd";
            this.textBoxOgrtAd.Size = new System.Drawing.Size(184, 20);
            this.textBoxOgrtAd.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.textBoxogrenciid);
            this.groupBox5.Controls.Add(this.buttonguncelle);
            this.groupBox5.Controls.Add(this.buttonsil);
            this.groupBox5.Location = new System.Drawing.Point(284, 190);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(332, 104);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(54, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Öğrenci İD:";
            // 
            // textBoxogrenciid
            // 
            this.textBoxogrenciid.Location = new System.Drawing.Point(136, 62);
            this.textBoxogrenciid.Name = "textBoxogrenciid";
            this.textBoxogrenciid.Size = new System.Drawing.Size(132, 20);
            this.textBoxogrenciid.TabIndex = 11;
            // 
            // buttonguncelle
            // 
            this.buttonguncelle.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguncelle.Location = new System.Drawing.Point(136, 25);
            this.buttonguncelle.Name = "buttonguncelle";
            this.buttonguncelle.Size = new System.Drawing.Size(135, 29);
            this.buttonguncelle.TabIndex = 10;
            this.buttonguncelle.Text = "Tabloyu Güncelle";
            this.buttonguncelle.UseVisualStyleBackColor = true;
            this.buttonguncelle.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsil.Location = new System.Drawing.Point(17, 27);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(109, 29);
            this.buttonsil.TabIndex = 9;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox6.Location = new System.Drawing.Point(622, 73);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(585, 317);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ÖĞRETMEN PANELİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dataGridView2);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.ForeColor = System.Drawing.Color.Salmon;
            this.groupBox8.Location = new System.Drawing.Point(625, 422);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(585, 304);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ÖĞRENCİ PANELİ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(579, 284);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem1.Text = "Dosya";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dToolStripMenuItem.Text = "Programdan Çık";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(309, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(602, 45);
            this.label3.TabIndex = 10;
            this.label3.Text = "Öğrenci Etüt Kayıt Sistemi";
            // 
            // EtutKayıtPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.kapatmabuton;
            this.ClientSize = new System.Drawing.Size(1224, 733);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "EtutKayıtPanel";
            this.Text = "EtutSistem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSaat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTarih;
        private System.Windows.Forms.ComboBox comboBoxOgretmen;
        private System.Windows.Forms.ComboBox comboBoxDers;
        private System.Windows.Forms.TextBox textBoxOgrenci;
        private System.Windows.Forms.TextBox textBoxEtutID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefon;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxSinif;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonEtutOlustur;
        private System.Windows.Forms.Label LabelSaat;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Label labelOgretmen;
        private System.Windows.Forms.Label labelDers;
        private System.Windows.Forms.Button buttonEtutVer;
        private System.Windows.Forms.Label labelOgrenci;
        private System.Windows.Forms.Label labelEtutID;
        private System.Windows.Forms.Button buttonOgrenciEkle;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelSinif;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Button buttonOgrtEkle;
        private System.Windows.Forms.Label labelOgrtDers;
        private System.Windows.Forms.Label labelOgrtSoyad;
        private System.Windows.Forms.Label LabelOgrtAd;
        private System.Windows.Forms.ComboBox comboBoxOgrtDers;
        private System.Windows.Forms.TextBox textBoxOgrtSoyad;
        private System.Windows.Forms.TextBox textBoxOgrtAd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonFotograf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTCNo;
        private System.Windows.Forms.Button buttonguncelle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxogrenciid;
        private System.Windows.Forms.Button buttontemizle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonRaporla;
        private System.Windows.Forms.Button kapatmabuton;
    }
}

