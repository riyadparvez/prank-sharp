﻿namespace Prank
{
    partial class PrankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrankForm));
            this.prankFormEventLog = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.prankFormEventLog)).BeginInit();
            this.SuspendLayout();
            // 
            // prankFormEventLog
            // 
            this.prankFormEventLog.SynchronizingObject = this;
            // 
            // PrankForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrankForm";
            this.Opacity = 0.01D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.PrankForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrankForm_FormClosing);
            this.Load += new System.EventHandler(this.PrankForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrankForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrankForm_KeyPress);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PrankForm_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.prankFormEventLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.EventLog prankFormEventLog;
    }
}

