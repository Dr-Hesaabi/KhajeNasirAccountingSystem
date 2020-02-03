namespace KhajeNasirAccountingSystemWindowsFormClient
{
    partial class Reports
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
            this.reportGUI1 = new KhajeNasirAccountingSystemReportClient.ReportGUI();
            this.SuspendLayout();
            // 
            // reportGUI1
            // 
            this.reportGUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportGUI1.ExePath = null;
            this.reportGUI1.Location = new System.Drawing.Point(0, 0);
            this.reportGUI1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.reportGUI1.Name = "reportGUI1";
            this.reportGUI1.Size = new System.Drawing.Size(379, 479);
            this.reportGUI1.TabIndex = 0;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(379, 479);
            this.Controls.Add(this.reportGUI1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reports";
            this.Text = "گزارش ها";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private KhajeNasirAccountingSystemReportClient.ReportGUI reportGUI1;
    }
}