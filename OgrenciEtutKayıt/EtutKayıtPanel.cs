using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace OgrenciEtutKayıt
{
    public partial class EtutKayıtPanel : Form
    {
        public EtutKayıtPanel()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N96LM12\SQLEXPRESS;Initial Catalog='EtutTest';Integrated Security=True");

        void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_dersler", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //ETÜT OLUŞTUR KISMINDAKİ COMBOBOX DERS EKLEMESİ
            comboBoxDers.ValueMember = "DERSID";
            comboBoxDers.DisplayMember = "DERSAD";
            comboBoxDers.DataSource = dt;
            
            //ÖĞRETMEN KAYDET KISMINDAKİ DERS EKLEMESİ
            comboBoxOgrtDers.ValueMember = "DERSID";
            comboBoxOgrtDers.DisplayMember = "DERSAD";
            comboBoxOgrtDers.DataSource = dt;
        }

        public void temizlebuton()
        {
           //TEMİZLEME METODU
            
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            textBoxSinif.Clear();
            maskedTextBoxTelefon.Clear();
            textBoxMail.Clear();
            maskedTextBoxTCNo.Clear();
            textBoxogrenciid.Clear();
            pictureBox1.ImageLocation = null;
            textBoxAd.Focus();
        }

        //etüt listesi
        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute etut", con); //sadece etütü çagırsın
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        void ogrenciler()
        {
            //ÖĞRENCİ VERİLERİNİN DATAGRİDE ÇEKİLMESİ
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_ogrenci", con);
            DataTable dt4 = new DataTable();
            da.Fill(dt4);
            dataGridView2.DataSource = dt4;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
            ogrenciler();
            

        }

        private void comboBoxDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from tbl_ogretmen where bransıd=" + comboBoxDers.SelectedValue, con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxOgretmen.ValueMember = "OgretmenID";
            comboBoxOgretmen.DisplayMember = "AD";
            comboBoxOgretmen.DataSource = dt2;


        }

        private void buttonEtutOlustur_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_etut (DERSID,OGRETMENID,TARIH,SAAT) values(@p1,@p2,@p3,@p4)", con);
            komut.Parameters.AddWithValue("@p1", comboBoxDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", comboBoxOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxTarih.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxSaat.Text);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Etüt Oluşturuldu!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            etutlistesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DATAGRİDDEN SEÇİLEN ÖĞRETMEN ID SİNİN TEXTBOXA AKTARILMASI 
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBoxEtutID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); 
        }

        private void buttonEtutVer_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Update tbl_etut set ogrencııd=@p1,durum=@p2 where ıd=@p3", con);
            komut.Parameters.AddWithValue("@p1", textBoxOgrenci.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", textBoxEtutID.Text);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Etüt Öğrenciye verildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            etutlistesi();

        }

        private void buttonFotograf_Click(object sender, EventArgs e)
        {
            //OPENFILEDIALOG ILE FOTOGRAF ALMA
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            MessageBox.Show("Fotoğraf Başarıyla Yüklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)

        {
            con.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_ogrenci (ad,soyad,sınıf,fotograf,telefon,maıl,tcno) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", con);
            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", textBoxSinif.Text);
            komut.Parameters.AddWithValue("@p4", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p5", maskedTextBoxTelefon.Text);
            komut.Parameters.AddWithValue("@p6", textBoxMail.Text);
            komut.Parameters.AddWithValue("@p7", maskedTextBoxTCNo.Text);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Öğrenci Sisteme Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrenciler();//DATAGRIDLERIN YENILENMESI


        }


        private void buttonOgrtEkle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_ogretmen (AD,SOYAD,BRANSID) values (@p1,@p2,@p3)", con);
            komut.Parameters.AddWithValue("@p1", textBoxOgrtAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxOgrtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxOgrtDers.SelectedValue);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Öğretmen Başarıyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            con.Close();
            derslistesi();//DATAGRIDLERIN YENILENMESI


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komutsil = new SqlCommand("delete from tbl_ogrenci where ogrenciıd=@p1", con);
            komutsil.Parameters.AddWithValue("@p1", textBoxogrenciid.Text);
            komutsil.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Silindi !","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            ogrenciler();//DATAGRIDLERIN YENILENMESI

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ÖĞRENCİ BİLGİLERİNİN TEXTBOXLARA ÇEKİLMESİ
            
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBoxogrenciid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            textBoxAd.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            maskedTextBoxTelefon.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            textBoxSinif.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            pictureBox1.ImageLocation = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
            textBoxMail.Text = dataGridView2.Rows[secilen].Cells[6].Value.ToString();
            maskedTextBoxTCNo.Text = dataGridView2.Rows[secilen].Cells[7].Value.ToString();


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DEĞİŞTİRİLEN BİLGİLERİN UPDATE SORGUSU İLE GÜNCELLENMESİ
            
            con.Open();
            SqlCommand komutguncelle = new SqlCommand("Update tbl_ogrenci set ad=@a1,soyad=@a2,sınıf=@a3,fotograf=@a4,telefon=@a5,maıl=@a6,tcno=@a7 where ogrenciıd=@a8", con);
            komutguncelle.Parameters.AddWithValue("@a1", textBoxAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", textBoxSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", textBoxSinif.Text);
            komutguncelle.Parameters.AddWithValue("@a4", pictureBox1.ImageLocation);
            komutguncelle.Parameters.AddWithValue("@a5", maskedTextBoxTelefon.Text);
            komutguncelle.Parameters.AddWithValue("@a6", textBoxMail.Text);
            komutguncelle.Parameters.AddWithValue("@a7", maskedTextBoxTCNo.Text);
            komutguncelle.Parameters.AddWithValue("@a8", textBoxogrenciid.Text);
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Bilgiler Güncellendi!");

            con.Close();
            ogrenciler();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            temizlebuton();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonRaporla_Click(object sender, EventArgs e)
        {
            //RAPORLA BUTONUNA BASILDIĞINDA CRYSTAL REPORTWİEW FORMUNUN AÇILMASI
            FrmRaporlar a = new FrmRaporlar();
            a.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
