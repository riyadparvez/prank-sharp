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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordConfirmationLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.shortcutsPanel = new System.Windows.Forms.Panel();
            this.unlockShortcutLabel = new System.Windows.Forms.Label();
            this.lockShortcutLabel = new System.Windows.Forms.Label();
            this.viewSettingsPanel = new System.Windows.Forms.Panel();
            this.colorLabel = new System.Windows.Forms.Label();
            this.transparencyLabel = new System.Windows.Forms.Label();
            this.lockScreenColorDialog = new System.Windows.Forms.ColorDialog();
            this.okCancelPanel.SuspendLayout();
            this.passwordPanel.SuspendLayout();
            this.shortcutsPanel.SuspendLayout();
            this.viewSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okCancelPanel
            // 
            this.okCancelPanel.BackColor = System.Drawing.Color.Transparent;
            this.okCancelPanel.Controls.Add(this.cancelButton);
            this.okCancelPanel.Controls.Add(this.okButton);
            this.okCancelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okCancelPanel.Location = new System.Drawing.Point(0, 339);
            this.okCancelPanel.Name = "okCancelPanel";
            this.okCancelPanel.Size = new System.Drawing.Size(284, 47);
            this.okCancelPanel.TabIndex = 0;
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
            // passwordPanel
            // 
            this.passwordPanel.Controls.Add(this.confirmPasswordTextBox);
            this.passwordPanel.Controls.Add(this.passwordConfirmationLabel);
            this.passwordPanel.Controls.Add(this.passwordTextBox);
            this.passwordPanel.Controls.Add(this.passwordLabel);
            this.passwordPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.passwordPanel.Location = new System.Drawing.Point(0, 271);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(284, 68);
            this.passwordPanel.TabIndex = 1;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(135, 37);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(132, 20);
            this.confirmPasswordTextBox.TabIndex = 4;
            // 
            // passwordConfirmationLabel
            // 
            this.passwordConfirmationLabel.AutoSize = true;
            this.passwordConfirmationLabel.Location = new System.Drawing.Point(23, 40);
            this.passwordConfirmationLabel.Name = "passwordConfirmationLabel";
            this.passwordConfirmationLabel.Size = new System.Drawing.Size(91, 13);
            this.passwordConfirmationLabel.TabIndex = 3;
            this.passwordConfirmationLabel.Text = "Confirm Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(135, 10);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(132, 22);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.WordWrap = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(61, 15);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            // 
            // shortcutsPanel
            // 
            this.shortcutsPanel.Controls.Add(this.unlockShortcutLabel);
            this.shortcutsPanel.Controls.Add(this.lockShortcutLabel);
            this.shortcutsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shortcutsPanel.Location = new System.Drawing.Point(0, 203);
            this.shortcutsPanel.Name = "shortcutsPanel";
            this.shortcutsPanel.Size = new System.Drawing.Size(284, 68);
            this.shortcutsPanel.TabIndex = 2;
            // 
            // unlockShortcutLabel
            // 
            this.unlockShortcutLabel.AutoSize = true;
            this.unlockShortcutLabel.Location = new System.Drawing.Point(26, 41);
            this.unlockShortcutLabel.Name = "unlockShortcutLabel";
            this.unlockShortcutLabel.Size = new System.Drawing.Size(84, 13);
            this.unlockShortcutLabel.TabIndex = 1;
            this.unlockShortcutLabel.Text = "Unlock Shortcut";
            // 
            // lockShortcutLabel
            // 
            this.lockShortcutLabel.AutoSize = true;
            this.lockShortcutLabel.Location = new System.Drawing.Point(34, 15);
            this.lockShortcutLabel.Name = "lockShortcutLabel";
            this.lockShortcutLabel.Size = new System.Drawing.Size(74, 13);
            this.lockShortcutLabel.TabIndex = 0;
            this.lockShortcutLabel.Text = "Lock Shortcut";
            // 
            // viewSettingsPanel
            // 
            this.viewSettingsPanel.Controls.Add(this.colorLabel);
            this.viewSettingsPanel.Controls.Add(this.transparencyLabel);
            this.viewSettingsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewSettingsPanel.Location = new System.Drawing.Point(0, 137);
            this.viewSettingsPanel.Name = "viewSettingsPanel";
            this.viewSettingsPanel.Size = new System.Drawing.Size(284, 66);
            this.viewSettingsPanel.TabIndex = 3;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(40, 19);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(31, 13);
            this.colorLabel.TabIndex = 1;
            this.colorLabel.Text = "Color";
            // 
            // transparencyLabel
            // 
            this.transparencyLabel.AutoSize = true;
            this.transparencyLabel.Location = new System.Drawing.Point(37, 47);
            this.transparencyLabel.Name = "transparencyLabel";
            this.transparencyLabel.Size = new System.Drawing.Size(72, 13);
            this.transparencyLabel.TabIndex = 0;
            this.transparencyLabel.Text = "Transparency";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 386);
            this.Controls.Add(this.viewSettingsPanel);
            this.Controls.Add(this.shortcutsPanel);
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
            this.shortcutsPanel.ResumeLayout(false);
            this.shortcutsPanel.PerformLayout();
            this.viewSettingsPanel.ResumeLayout(false);
            this.viewSettingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel okCancelPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passwordConfirmationLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Panel shortcutsPanel;
        private System.Windows.Forms.Label unlockShortcutLabel;
        private System.Windows.Forms.Label lockShortcutLabel;
        private System.Windows.Forms.Panel viewSettingsPanel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label transparencyLabel;
        private System.Windows.Forms.ColorDialog lockScreenColorDialog;
    }
}