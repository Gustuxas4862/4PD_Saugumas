namespace PD4
{
    partial class NewPasswordPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordInputField = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdatePasswordButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "New Password";
            // 
            // PasswordInputField
            // 
            this.PasswordInputField.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordInputField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordInputField.Location = new System.Drawing.Point(12, 108);
            this.PasswordInputField.Multiline = true;
            this.PasswordInputField.Name = "PasswordInputField";
            this.PasswordInputField.PlaceholderText = "Password";
            this.PasswordInputField.Size = new System.Drawing.Size(397, 65);
            this.PasswordInputField.TabIndex = 15;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(79, 13);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(265, 41);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Change Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 66);
            this.panel1.TabIndex = 17;
            // 
            // UpdatePasswordButton
            // 
            this.UpdatePasswordButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UpdatePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePasswordButton.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdatePasswordButton.ForeColor = System.Drawing.Color.White;
            this.UpdatePasswordButton.Location = new System.Drawing.Point(53, 199);
            this.UpdatePasswordButton.Name = "UpdatePasswordButton";
            this.UpdatePasswordButton.Size = new System.Drawing.Size(322, 58);
            this.UpdatePasswordButton.TabIndex = 25;
            this.UpdatePasswordButton.Text = "Update Password";
            this.UpdatePasswordButton.UseVisualStyleBackColor = false;
            this.UpdatePasswordButton.Click += new System.EventHandler(this.UpdatePasswordButton_Click);
            // 
            // NewPasswordPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 269);
            this.Controls.Add(this.UpdatePasswordButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordInputField);
            this.Name = "NewPasswordPanel";
            this.Text = "NewPasswordPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox PasswordInputField;
        private Label NameLabel;
        private Panel panel1;
        private Button UpdatePasswordButton;
    }
}