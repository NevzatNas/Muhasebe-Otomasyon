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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_ADMİN", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            textEdit1.Text = "";
            textEdit2.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (btnislem.Text == "Kaydet")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_ADMİN values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textEdit1.Text);
                komut.Parameters.AddWithValue("@p2", textEdit2.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni Admin Sisteme Kaydedildi!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            if (btnislem.Text == "Güncelle")
            {
                SqlCommand komut2 = new SqlCommand("update TBL_ADMİN set SIFRE=@p1 where KULLANICIADI=@p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", textEdit2.Text);
                komut2.Parameters.AddWithValue("@p2", textEdit1.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                textEdit1.Text = dr["KULLANICIADI"].ToString();
                textEdit2.Text = dr["SIFRE"].ToString();
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (textEdit3.Text != "")
            {
                btnislem.Text = "Güncelle";
            }
            else
            {
                btnislem.Text = "Kaydet";
            }
        }
    }
}
