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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void notListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_NOTLAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            TxtBaslik.Text = "";
            TxtHitap.Text = "";
            Txtid.Text = "";
            TxtOlusturan.Text = "";
            MskSaat.Text = "";
            MskTarih.Text = "";
            RichDetay.Text = "";
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            notListele();
            temizle();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR (NOTTARIH,NOTSAAT,NOTBASLIK,NOTDETAY,NOTOLUSTURAN,HITAP) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTarih.Text);
            komut.Parameters.AddWithValue("@p2", MskSaat.Text);
            komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", RichDetay.Text);
            komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", TxtHitap.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            notListele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtBaslik.Text = dr["NOTBASLIK"].ToString();
                TxtHitap.Text = dr["HITAP"].ToString();
                Txtid.Text = dr["NOTID"].ToString();
                TxtOlusturan.Text = dr["NOTOLUSTURAN"].ToString();
                MskSaat.Text = dr["NOTSAAT"].ToString();
                MskTarih.Text = dr["NOTTARIH"].ToString();
                RichDetay.Text = dr["NOTDETAY"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Not silinsin mi?", "Not Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from tbl_notlar where NOTID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.ExecuteNonQuery();
                notListele();
                MessageBox.Show("Not Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                temizle();
            }
            else if (secim == DialogResult.No)
            {
                notListele();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_NOTLAR set NOTTARIH=@p1,NOTSAAT=@p2,NOTBASLIK=@p3,NOTDETAY=@p4,NOTOLUSTURAN=@p5,HITAP=@p6 where NOTID=@p7", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTarih.Text);
            komut.Parameters.AddWithValue("@p2", MskSaat.Text);
            komut.Parameters.AddWithValue("@p3", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", RichDetay.Text);
            komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", TxtHitap.Text);
            komut.Parameters.AddWithValue("@p7", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            notListele();
            MessageBox.Show("Not Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }
    }
}
