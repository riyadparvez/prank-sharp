namespace Prank
{
    partial class SettingsForm
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
            this.okCancelPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.okCancelPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okCancelPanel
            // 
            this.okCancelPanel.BackColor = System.Drawing.Color.Transparent;
            this.okCancelPanel.Controls.Add(this.cancelButton);
            this.okCancelPanel.Controls.Add(this.okButton);
            this.okCancelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okCancelPanel.Location = new System.Drawing.Point(0, 215);
            this.okCancelPanel.Name = "okCancelPanel";
            this.okCancelPanel.Size = new System.Drawing.Size(284, 47);
            this.okCancelPanel.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(45, 11);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(153, 11);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // passwordPanel
            // 
            this.passwordPanel.Controls.Add(this.passwordTextBox);
            this.passwordPanel.Controls.Add(this.passwordLabel);
            this.passwordPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.passwordPanel.Location = new System.Drawing.Point(0, 179);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(284, 36);
            this.passwordPanel.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(36, 13);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(96, 10);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(132, 22);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.WordWrap = false;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.okCancelPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.okCancelPanel.ResumeLayout(false);
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel okCancelPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
    }
}