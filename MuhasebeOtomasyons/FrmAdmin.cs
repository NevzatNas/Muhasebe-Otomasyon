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
using System.Xml;

namespace MuhasebeOtomasyons
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            XmlTextReader oku = new XmlTextReader("http://ip-api.com/xml");
            while (oku.Read())
            {
                if (oku.NodeType == XmlNodeType.Element)
                {
                    if (oku.Name == "country")
                    {
                        oku.Read();
                        textEdit1.Text = "Ülke:" + oku.Value.ToString();
                    }
                    if (oku.Name == "regionName")
                    {
                        oku.Read();
                        textEdit2.Text = "Şehir:" + oku.Value.ToString();
                    }
                    if (oku.Name == "city")
                    {
                        oku.Read();
                        textEdit3.Text = "Semt:" + oku.Value.ToString();
                    }
                    if (oku.Name == "zip")
                    {
                        oku.Read();
                        textEdit4.Text = "Posta Kodu:" + oku.Value.ToString();
                    }
                }
            }
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBL_ADMİN where KULLANICIADI=@p1 and SIFRE=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaModul frm = new FrmAnaModul();
                frm.kullanici = txtAd.Text;

                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
