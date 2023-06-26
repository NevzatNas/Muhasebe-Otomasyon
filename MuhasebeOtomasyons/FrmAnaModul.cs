using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeOtomasyons
{
    public partial class FrmAnaModul : Form
    {
        public FrmAnaModul()
        {
            InitializeComponent();
        }

        FrmUrunler fr;
        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr == null)
            {
                fr = new FrmUrunler();
                fr.MdiParent = this;
                fr.Show();
            }
           
        }

        FrmMusteriler fr1;
        private void BtnMusterıler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr1 == null)
            {
                fr1 = new FrmMusteriler();
                fr1.MdiParent = this;
                fr1.Show();
            }
        }

        FrmFirmalar fr2;
        private void BtnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new FrmFirmalar();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }

        FrmPersonel fr3;
        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new FrmPersonel();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }

        FrmRehber fr4;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null)
            {
                fr4 = new FrmRehber();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }

        FrmGiderler fr5;
        private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null)
            {
                fr5 = new FrmGiderler();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }

        FrmBankalar fr6;
        private void BtnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null)
            {
                fr6 = new FrmBankalar();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }

        public string kullanici;
        private void FrmAnaModul_Load(object sender, EventArgs e)
        {
            if (fr12 == null)
            {

                fr12 = new FrmAnaSayfa();

                fr12.MdiParent = this;
                fr12.Show();
            }

        }

        FrmFaturalar fr7;
        private void BtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null)
            {
                fr7 = new FrmFaturalar();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }

        FrmNotlar fr8;
        private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null)
            {
                fr8 = new FrmNotlar();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }

        FrmHareketler fr9;
        private void Btn_Hareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null)
            {
                fr9 = new FrmHareketler();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }

        FrmStoklar fr10;
        private void BtnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null)
            {
                fr10 = new FrmStoklar();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }

        FrmKasa fr11;
        private void BtnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null)
            {
                
                fr11 = new FrmKasa();
                fr11.ad = kullanici;
                fr11.MdiParent = this;
                fr11.Show();
            }
        }

        FrmAnaSayfa fr12;
        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null)
            {

                fr12 = new FrmAnaSayfa();
                
                fr12.MdiParent = this;
                fr12.Show();
            }
        }

        FrmRaporlar fr13;
        private void Btn_Raporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null)
            {

                fr13 = new FrmRaporlar();

                fr13.MdiParent = this;
                fr13.Show();
            }
        }

        FrmAyarlar fr14;
        private void BtnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null)
            {

                fr14 = new FrmAyarlar();

               
                fr14.Show();
            }
        }
    }
}
