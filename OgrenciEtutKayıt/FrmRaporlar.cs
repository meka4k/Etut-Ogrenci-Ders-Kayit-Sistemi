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
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public static string Sqlcon = (@"Data Source=DESKTOP-N96LM12\SQLEXPRESS;Initial Catalog='EtutTest';Integrated Security=True");

        public void RaporDoldur(string sql)
        {
            con = new SqlConnection(Sqlcon);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            crystalReport11.SetDataSource(ds.Tables[0]);
            crystalReportViewer2.ReportSource = crystalReport11;
            con.Close();
        }
        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            RaporDoldur("select * from tbl_ogrenci");
        }
    }
}
