namespace PD4
{
    partial class ManagementPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NewPasswordButton = new System.Windows.Forms.Button();
            this.PasswordSearchButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 79);
            this.panel1.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(22, 20);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(462, 41);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Password Management System";
            // 
            // NewPasswordButton
            // 
            this.NewPasswordButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.NewPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPasswordButton.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPasswordButton.ForeColor = System.Drawing.Color.White;
            this.NewPasswordButton.Location = new System.Drawing.Point(30, 107);
            this.NewPasswordButton.Name = "NewPasswordButton";
            this.NewPasswordButton.Size = new System.Drawing.Size(442, 58);
            this.NewPasswordButton.TabIndex = 10;
            this.NewPasswordButton.Text = "Add New Password";
            this.NewPasswordButton.UseVisualStyleBackColor = false;
            this.NewPasswordButton.Click += new System.EventHandler(this.NewPasswordButton_Click);
            // 
            // PasswordSearchButton
            // 
            this.PasswordSearchButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PasswordSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordSearchButton.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordSearchButton.ForeColor = System.Drawing.Color.White;
            this.PasswordSearchButton.Location = new System.Drawing.Point(30, 196);
            this.PasswordSearchButton.Name = "PasswordSearchButton";
            this.PasswordSearchButton.Size = new System.Drawing.Size(442, 58);
            this.PasswordSearchButton.TabIndex = 11;
            this.PasswordSearchButton.Text = "Update Password ";
            this.PasswordSearchButton.UseVisualStyleBackColor = false;
            this.PasswordSearchButton.Click += new System.EventHandler(this.PasswordSearchButton_Click);
            // 
            // ManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 274);
            this.Controls.Add(this.PasswordSearchButton);
            this.Controls.Add(this.NewPasswordButton);
            this.Controls.Add(this.panel1);
            this.Name = "ManagementPanel";
            this.Text = "ManagementPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementPanel_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label NameLabel;
        private Button NewPasswordButton;
        private Button PasswordSearchButton;
    }
}