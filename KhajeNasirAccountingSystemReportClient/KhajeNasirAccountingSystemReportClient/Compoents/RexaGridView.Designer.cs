﻿namespace KhajeNasirAccountingSystemReportClient.Compoents
{
    partial class RexaGridView
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RexaGridView
            // 
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridColor = System.Drawing.Color.Black;
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ShowEditingIcon = false;
            this.ShowRowErrors = false;
            this.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.RexaGridView_DataBindingComplete);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
