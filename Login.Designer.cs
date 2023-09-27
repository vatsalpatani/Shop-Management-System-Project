namespace SMS
{
    partial class Login
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
            this.NamePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.PwdLAbel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.NamePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.NamePanel.Controls.Add(this.label1);
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(1064, 82);
            this.NamePanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(585, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "SHOP MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Controls.Add(this.clearButton);
            this.panel2.Controls.Add(this.password);
            this.panel2.Controls.Add(this.userName);
            this.panel2.Controls.Add(this.PwdLAbel);
            this.panel2.Controls.Add(this.userNameLabel);
            this.panel2.Location = new System.Drawing.Point(458, 214);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 304);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "LOGIN";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.loginButton.Location = new System.Drawing.Point(229, 197);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(159, 48);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.LightCoral;
            this.clearButton.Location = new System.Drawing.Point(32, 197);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(148, 48);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(150, 119);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(239, 30);
            this.password.TabIndex = 3;
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(150, 50);
            this.userName.Margin = new System.Windows.Forms.Padding(2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(239, 30);
            this.userName.TabIndex = 2;
            // 
            // PwdLAbel
            // 
            this.PwdLAbel.AutoSize = true;
            this.PwdLAbel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwdLAbel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PwdLAbel.Location = new System.Drawing.Point(27, 120);
            this.PwdLAbel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PwdLAbel.Name = "PwdLAbel";
            this.PwdLAbel.Size = new System.Drawing.Size(93, 28);
            this.PwdLAbel.TabIndex = 1;
            this.PwdLAbel.Text = "Password";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userNameLabel.Location = new System.Drawing.Point(27, 50);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(108, 28);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 495);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.panel2);
            this.HelpButton = true;
            this.Name = "Login";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label PwdLAbel;
        private System.Windows.Forms.Label userNameLabel;
    }
}

