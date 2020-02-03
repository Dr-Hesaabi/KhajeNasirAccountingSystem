namespace KhajeNasirAccountingSystemReportClient.Forms
{
    partial class AllDepositsForPerson
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AllLoansForPersonModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AllLoansForPersonModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MainDataSet";
            reportDataSource1.Value = this.AllLoansForPersonModelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KhajeNasirAccountingSystemReportClient.Reports.AllDepositsForPerson.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(719, 342);
            this.reportViewer1.TabIndex = 0;
            // 
            // AllLoansForPersonModelBindingSource
            // 
            this.AllLoansForPersonModelBindingSource.DataSource = typeof(KhajeNasirAccountingSystemReportClient.MVVM.AllLoansForPersonModel);
            // 
            // AllDepositsForPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 342);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AllDepositsForPerson";
            this.Text = "تمام واریز های ";
            this.Load += new System.EventHandler(this.AllDepositsForPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllLoansForPersonModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AllLoansForPersonModelBindingSource;
    }
}