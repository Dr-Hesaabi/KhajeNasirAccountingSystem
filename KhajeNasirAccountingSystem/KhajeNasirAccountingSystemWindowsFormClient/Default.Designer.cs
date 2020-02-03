namespace KhajeNasirAccountingSystemWindowsFormClient
{
    partial class Default
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCoustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییررمزورودToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHome,
            this.MenuCoustomer,
            this.MenuPayment,
            this.MenuLoan,
            this.MenuCheck,
            this.MenuReport,
            this.تغییررمزورودToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(946, 27);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuHome
            // 
            this.MenuHome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MenuHome.Name = "MenuHome";
            this.MenuHome.Size = new System.Drawing.Size(104, 23);
            this.MenuHome.Text = "صفحه اصلی";
            this.MenuHome.Click += new System.EventHandler(this.MenuHome_Click);
            // 
            // MenuCoustomer
            // 
            this.MenuCoustomer.Name = "MenuCoustomer";
            this.MenuCoustomer.Size = new System.Drawing.Size(79, 23);
            this.MenuCoustomer.Text = "مشتریان";
            this.MenuCoustomer.Click += new System.EventHandler(this.MenuCoustomer_Click);
            // 
            // MenuPayment
            // 
            this.MenuPayment.Enabled = false;
            this.MenuPayment.Name = "MenuPayment";
            this.MenuPayment.Size = new System.Drawing.Size(49, 23);
            this.MenuPayment.Text = "واریز";
            // 
            // MenuLoan
            // 
            this.MenuLoan.Name = "MenuLoan";
            this.MenuLoan.Size = new System.Drawing.Size(98, 23);
            this.MenuLoan.Text = "حق عضویت";
            this.MenuLoan.Click += new System.EventHandler(this.MenuLoan_Click);
            // 
            // MenuCheck
            // 
            this.MenuCheck.Name = "MenuCheck";
            this.MenuCheck.Size = new System.Drawing.Size(47, 23);
            this.MenuCheck.Text = "چک";
            this.MenuCheck.Click += new System.EventHandler(this.MenuCheck_Click);
            // 
            // MenuReport
            // 
            this.MenuReport.Name = "MenuReport";
            this.MenuReport.Size = new System.Drawing.Size(80, 23);
            this.MenuReport.Text = "گزارشات";
            this.MenuReport.Click += new System.EventHandler(this.MenuReport_Click);
            // 
            // تغییررمزورودToolStripMenuItem
            // 
            this.تغییررمزورودToolStripMenuItem.Name = "تغییررمزورودToolStripMenuItem";
            this.تغییررمزورودToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.تغییررمزورودToolStripMenuItem.Text = "تغییر رمز ورود";
            this.تغییررمزورودToolStripMenuItem.Click += new System.EventHandler(this.تغییررمزورودToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 482);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(946, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "label1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(946, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Default";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Default";
            this.Load += new System.EventHandler(this.Default_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuHome;
        private System.Windows.Forms.ToolStripMenuItem MenuCoustomer;
        private System.Windows.Forms.ToolStripMenuItem MenuPayment;
        private System.Windows.Forms.ToolStripMenuItem MenuLoan;
        private System.Windows.Forms.ToolStripMenuItem MenuReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem MenuCheck;
        private System.Windows.Forms.ToolStripMenuItem تغییررمزورودToolStripMenuItem;
    }
}