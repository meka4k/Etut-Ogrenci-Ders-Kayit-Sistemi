using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace OgrenciEtutKayıt
{
    class veritabani
    {
        veritabani()
        {

        }
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static System.Data.DataSet ds;

        public static string Sqlcon = (@"Data Source=DESKTOP-N96LM12\SQLEXPRESS;Initial Catalog='EtutTest';Integrated Security=True");
        public static string MD5Sifrele(string sifrelenecekmetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekmetin);

            // dizinin hash degeri çıkarılıyor
            dizi = md5.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)

                sb.Append(item.ToString("x2").ToLower());




            return sb.ToString();

        }


        public static bool loginKontrol(string kullaniciadi, string sifre)
        {
            string sorgu = "select * from tbl_login where kullanici=@user and sifre=@pass";
            con = new SqlConnection(Sqlcon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullaniciadi);
            cmd.Parameters.AddWithValue("@pass", veritabani.MD5Sifrele(sifre));

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //MessageBox.Show("Giriş Başarılı!");
                con.Close();
                return true;
            }
            else
            {
                //MessageBox.Show("Kullancı Adı veya Şifre Hatalı!");
                con.Close();
                return false;                    
            }



        }


    }
    
}
