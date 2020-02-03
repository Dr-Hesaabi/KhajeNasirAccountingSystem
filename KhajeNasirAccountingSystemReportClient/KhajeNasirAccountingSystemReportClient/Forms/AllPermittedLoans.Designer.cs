namespace KhajeNasirAccountingSystemReportClient.Forms
{
    partial class AllPermittedLoans
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
            this.AllPermittedLoansModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.AllPermittedLoansModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AllPermittedLoansModelBindingSource
            // 
            this.AllPermittedLoansModelBindingSource.DataSource = typeof(KhajeNasirAccountingSystemReportClient.MVVM.AllPermittedLoansModel);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MainDataSet";
            reportDataSource1.Value = this.AllPermittedLoansModelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KhajeNasirAccountingSystemReportClient.Reports.AllPermittedLoans.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(768, 468);
            this.reportViewer1.TabIndex = 0;
            // 
            // AllPermittedLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 468);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AllPermittedLoans";
            this.Text = "وام های تایید شده";
            this.Load += new System.EventHandler(this.AllPermittedLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllPermittedLoansModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AllPermittedLoansModelBindingSource;
    }
}