namespace MuhasebeOtomasyons
{
    partial class FrmRaporlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlar));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.MuhasebeODBDataSet = new MuhasebeOtomasyons.MuhasebeODBDataSet();
            this.TBL_FIRMALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_FIRMALARTableAdapter = new MuhasebeOtomasyons.MuhasebeODBDataSetTableAdapters.TBL_FIRMALARTableAdapter();
            this.MuhasebeODBDataSet1 = new MuhasebeOtomasyons.MuhasebeODBDataSet1();
            this.TBL_MUSTERILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_MUSTERILERTableAdapter = new MuhasebeOtomasyons.MuhasebeODBDataSet1TableAdapters.TBL_MUSTERILERTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MuhasebeODBDataSet2 = new MuhasebeOtomasyons.MuhasebeODBDataSet2();
            this.TBL_FATURADETAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TBL_FATURADETAYTableAdapter = new MuhasebeOtomasyons.MuhasebeODBDataSet2TableAdapters.TBL_FATURADETAYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MuhasebeODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_FIRMALARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuhasebeODBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_MUSTERILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuhasebeODBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_FATURADETAYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1350, 561);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage6});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.reportViewer1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1348, 517);
            this.xtraTabPage1.Text = "MÜŞTERİ RAPORLARI";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TBL_MUSTERILERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MuhasebeOtomasyons.RaporMsteri.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1348, 517);
            this.reportViewer1.TabIndex = 0;
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.reportViewer2);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(1348, 517);
            this.xtraTabPage6.Text = "FATURA RAPORLARI";
            // 
            // MuhasebeODBDataSet
            // 
            this.MuhasebeODBDataSet.DataSetName = "MuhasebeODBDataSet";
            this.MuhasebeODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_FIRMALARBindingSource
            // 
            this.TBL_FIRMALARBindingSource.DataMember = "TBL_FIRMALAR";
            this.TBL_FIRMALARBindingSource.DataSource = this.MuhasebeODBDataSet;
            // 
            // TBL_FIRMALARTableAdapter
            // 
            this.TBL_FIRMALARTableAdapter.ClearBeforeFill = true;
            // 
            // MuhasebeODBDataSet1
            // 
            this.MuhasebeODBDataSet1.DataSetName = "MuhasebeODBDataSet1";
            this.MuhasebeODBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_MUSTERILERBindingSource
            // 
            this.TBL_MUSTERILERBindingSource.DataMember = "TBL_MUSTERILER";
            this.TBL_MUSTERILERBindingSource.DataSource = this.MuhasebeODBDataSet1;
            // 
            // TBL_MUSTERILERTableAdapter
            // 
            this.TBL_MUSTERILERTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TBL_FATURADETAYBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "MuhasebeOtomasyons.FaturaRapor.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1348, 517);
            this.reportViewer2.TabIndex = 0;
            // 
            // MuhasebeODBDataSet2
            // 
            this.MuhasebeODBDataSet2.DataSetName = "MuhasebeODBDataSet2";
            this.MuhasebeODBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TBL_FATURADETAYBindingSource
            // 
            this.TBL_FATURADETAYBindingSource.DataMember = "TBL_FATURADETAY";
            this.TBL_FATURADETAYBindingSource.DataSource = this.MuhasebeODBDataSet2;
            // 
            // TBL_FATURADETAYTableAdapter
            // 
            this.TBL_FATURADETAYTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 561);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FrmRaporlar";
            this.Text = "FrmRaporlar";
            this.Load += new System.EventHandler(this.FrmRaporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MuhasebeODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_FIRMALARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuhasebeODBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_MUSTERILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuhasebeODBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_FATURADETAYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TBL_FIRMALARBindingSource;
        private MuhasebeODBDataSet MuhasebeODBDataSet;
        private MuhasebeODBDataSetTableAdapters.TBL_FIRMALARTableAdapter TBL_FIRMALARTableAdapter;
        private System.Windows.Forms.BindingSource TBL_MUSTERILERBindingSource;
        private MuhasebeODBDataSet1 MuhasebeODBDataSet1;
        private MuhasebeODBDataSet1TableAdapters.TBL_MUSTERILERTableAdapter TBL_MUSTERILERTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource TBL_FATURADETAYBindingSource;
        private MuhasebeODBDataSet2 MuhasebeODBDataSet2;
        private MuhasebeODBDataSet2TableAdapters.TBL_FATURADETAYTableAdapter TBL_FATURADETAYTableAdapter;
    }
}