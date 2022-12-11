
namespace GUI_Dangnhap
{
    partial class FormDoanhThuTungSanPham
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SGLSTOREDataSet = new GUI_Dangnhap.SGLSTOREDataSet();
            this.ChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SanPhamTableAdapter = new GUI_Dangnhap.SGLSTOREDataSetTableAdapters.SanPhamTableAdapter();
            this.ChiTietHoaDonTableAdapter = new GUI_Dangnhap.SGLSTOREDataSetTableAdapters.ChiTietHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SGLSTOREDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SanPhamBindingSource
            // 
            this.SanPhamBindingSource.DataMember = "SanPham";
            this.SanPhamBindingSource.DataSource = this.SGLSTOREDataSet;
            // 
            // SGLSTOREDataSet
            // 
            this.SGLSTOREDataSet.DataSetName = "SGLSTOREDataSet";
            this.SGLSTOREDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChiTietHoaDonBindingSource
            // 
            this.ChiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.ChiTietHoaDonBindingSource.DataSource = this.SGLSTOREDataSet;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(814, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetSanPham";
            reportDataSource1.Value = this.SanPhamBindingSource;
            reportDataSource2.Name = "DataSetCTHD";
            reportDataSource2.Value = this.ChiTietHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_Dangnhap.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(859, 491);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // SanPhamTableAdapter
            // 
            this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // ChiTietHoaDonTableAdapter
            // 
            this.ChiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // FormDoanhThuTungSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 490);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoanhThuTungSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoanhThuTungSanPham";
            this.Load += new System.EventHandler(this.FormDoanhThuTungSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SGLSTOREDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnExit;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SanPhamBindingSource;
        private SGLSTOREDataSet SGLSTOREDataSet;
        private System.Windows.Forms.BindingSource ChiTietHoaDonBindingSource;
        private SGLSTOREDataSetTableAdapters.SanPhamTableAdapter SanPhamTableAdapter;
        private SGLSTOREDataSetTableAdapters.ChiTietHoaDonTableAdapter ChiTietHoaDonTableAdapter;
    }
}