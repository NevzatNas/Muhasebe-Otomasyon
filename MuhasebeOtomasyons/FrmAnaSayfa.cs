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

namespace MuhasebeOtomasyons
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        //stoklar
        void stoklar()
        {
            SqlDataAdapter da = new SqlDataAdapter("select UrunAd,Sum(Adet) as 'Adet' from TBL_URUNLER group by UrunAd having sum(adet) <= 20 order by sum(adet)", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        //ajanda
        void ajanda()
        {
            SqlDataAdapter da = new SqlDataAdapter("select top 10 NOTTARIH,NOTSAAT,NOTBASLIK from TBL_NOTLAR order by NOTID desc ", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }

        //firma hareketleri
        void firmahareketleri()
        {
            SqlDataAdapter da = new SqlDataAdapter("execute FirmaHareket2", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        //rehber
        void rehber()
        {
            SqlDataAdapter da = new SqlDataAdapter("select AD,TELEFON1 from TBL_FIRMALAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl4.DataSource = dt;
        }

        sqlbaglantisi bgl=new sqlbaglantisi();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            stoklar();
            ajanda();
            firmahareketleri();
            rehber();
            //webBrowser1.Navigate("https://www.youtube.com/watch?v=aULM7vv8llk");
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/kurlar_tr.html");
        }
    }
}
