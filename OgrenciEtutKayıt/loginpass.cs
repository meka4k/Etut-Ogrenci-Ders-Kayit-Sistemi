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

namespace OgrenciEtutKayıt
{
    public partial class loginpass : Form
    {
        SqlConnection con;
        DataSet ds;
        SqlDataReader dr;
        SqlCommand cmd;
        
        public static string Sqlcon=(@"Data Source=DESKTOP-N96LM12\SQLEXPRESS;Initial Catalog='EtutTest';Integrated Security=True");
        public int denemeSayac = 0;
        public loginpass()
        {
            InitializeComponent();
           
           // da=new SqlDataAdapter("Select * from tbl_ogrenci ")
        }
            

        private void buttoncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttongiris_Click(object sender, EventArgs e)
        {
            // login();
            if(veritabani.loginKontrol(textBoxgiris.Text, textBoxcikis.Text))
            {
                MessageBox.Show("Giriş Başarılı!");
                this.Hide();
                EtutKayıtPanel a = new EtutKayıtPanel();
                a.Show();
            }
            else
            {
                MessageBox.Show("Kullancı Adı veya Şifre Hatalı!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBoxgiris.Clear();
                textBoxcikis.Clear();
                textBoxgiris.Focus();
                denemeSayac++;
                if (denemeSayac == 3)
                {
                    MessageBox.Show("3 Defa Yanlış Girdiğiniz için Program Kapatılıyor...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
        }

        public void login()
        {
            string sorgu = "select * from tbl_login where kullanici=@user and sifre=@pass";
            con = new SqlConnection(Sqlcon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBoxgiris.Text);
            cmd.Parameters.AddWithValue("@pass", veritabani.MD5Sifrele(textBoxcikis.Text));

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı!");
            }
            else
            {
                MessageBox.Show("Kullancı Adı veya Şifre Hatalı!");
                textBoxgiris.Clear();
                textBoxcikis.Clear();
                textBoxgiris.Focus();
            }
            con.Close();


        }

        private void loginpass_Load(object sender, EventArgs e)
        {

        }
    }
}
