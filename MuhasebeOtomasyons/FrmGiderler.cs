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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void giderListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER Order By ID Asc ", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            CmbAy.Text = "";
            CmbYil.Text = "";
            TxtGaz.Text = "";
            TxtEkstra.Text = "";
            TxtElektrik.Text = "";
            Txtid.Text = "";
            TxtInternet.Text = "";
            TxtMaas.Text = "";
            TxtSu.Text = "";
            RichNotlar.Text = "";
        }

        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderListesi();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER (ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR,AY,YIL) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToDecimal(TxtElektrik.Text));
            komut.Parameters.AddWithValue("@p2", Convert.ToDecimal(TxtSu.Text));
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtGaz.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToDecimal(TxtInternet.Text));
            komut.Parameters.AddWithValue("@p5", Convert.ToDecimal(TxtMaas.Text));
            komut.Parameters.AddWithValue("@p6", Convert.ToDecimal(TxtEkstra.Text));
            komut.Parameters.AddWithValue("@p7", RichNotlar.Text);
            komut.Parameters.AddWithValue("@p8", CmbAy.Text);
            komut.Parameters.AddWithValue("@p9", CmbYil.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Listeye Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListesi();
            temizle();
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txtid.Text = dr["ID"].ToString();
                CmbAy.Text = dr["AY"].ToString();
                CmbYil.Text = dr["YIL"].ToString();
                TxtElektrik.Text = dr["ELEKTRIK"].ToString();
                TxtSu.Text = dr["SU"].ToString();
                TxtGaz.Text = dr["DOGALGAZ"].ToString();
                TxtInternet.Text = dr["INTERNET"].ToString();
                TxtMaas.Text = dr["MAASLAR"].ToString();
                TxtEkstra.Text = dr["EKSTRA"].ToString();
                RichNotlar.Text = dr["NOTLAR"].ToString();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Gider listeden silinsin mi?", "Gider Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from TBL_GIDERLER where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Gider Listeden Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                giderListesi();
                temizle();
            }
            else if (secim == DialogResult.No)
            {
                giderListesi();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_GIDERLER set AY=@p8,YIL=@p9,ELEKTRIK=@p1,SU=@p2,DOGALGAZ=@p3,INTERNET=@p4,MAASLAR=@p5,EKSTRA=@p6,NOTLAR=@p7 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p8", CmbAy.Text);
            komut.Parameters.AddWithValue("@p9", CmbYil.Text);
            komut.Parameters.AddWithValue("@p1", Convert.ToDecimal(TxtElektrik.Text));
            komut.Parameters.AddWithValue("@p2", Convert.ToDecimal(TxtSu.Text));
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtGaz.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToDecimal(TxtInternet.Text));
            komut.Parameters.AddWithValue("@p5", Convert.ToDecimal(TxtMaas.Text));
            komut.Parameters.AddWithValue("@p6", Convert.ToDecimal(TxtEkstra.Text));
            komut.Parameters.AddWithValue("@p7", RichNotlar.Text);
            komut.Parameters.AddWithValue("@p10", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Listesi Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListesi();
            temizle();
        }
    }
}
