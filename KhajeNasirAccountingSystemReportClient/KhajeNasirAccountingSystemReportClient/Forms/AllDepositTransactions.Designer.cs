namespace KhajeNasirAccountingSystemReportClient.Forms
{
    partial class AllDepositTransactions
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
            this.AllDepositTransactionsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.AllDepositTransactionsModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AllDepositTransactionsModelBindingSource
            // 
            this.AllDepositTransactionsModelBindingSource.DataSource = typeof(KhajeNasirAccountingSystemReportClient.MVVM.AllDepositTransactionsModel);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MainDataSet";
            reportDataSource1.Value = this.AllDepositTransactionsModelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KhajeNasirAccountingSystemReportClient.Reports.AllDepositTransactions.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(869, 442);
            this.reportViewer1.TabIndex = 0;
            // 
            // AllDepositTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 442);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AllDepositTransactions";
            this.Text = "تمام تراکنش های واریز به صندوق";
            this.Load += new System.EventHandler(this.AllDepositTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllDepositTransactionsModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AllDepositTransactionsModelBindingSource;
    }
}