namespace SMS
{
    partial class CustomerUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerUpdate));
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.CustPhno = new System.Windows.Forms.TextBox();
            this.PhoneNoLabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.CustNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.divider = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(622, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "UPDATE CUSTOMERS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1650, 43);
            this.panel1.TabIndex = 67;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(205, 284);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(145, 31);
            this.updateButton.TabIndex = 66;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(13, 284);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 31);
            this.clearButton.TabIndex = 65;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 64;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(148, 237);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(209, 23);
            this.Email.TabIndex = 63;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(10, 237);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 62;
            this.EmailLabel.Text = "Email";
            // 
            // customerAddress
            // 
            this.customerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddress.Location = new System.Drawing.Point(148, 149);
            this.customerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.customerAddress.Multiline = true;
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(209, 71);
            this.customerAddress.TabIndex = 61;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(10, 149);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 60;
            this.addressLabel.Text = "Address";
            // 
            // CustPhno
            // 
            this.CustPhno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustPhno.Location = new System.Drawing.Point(148, 110);
            this.CustPhno.Margin = new System.Windows.Forms.Padding(2);
            this.CustPhno.Name = "CustPhno";
            this.CustPhno.Size = new System.Drawing.Size(209, 23);
            this.CustPhno.TabIndex = 59;
            // 
            // PhoneNoLabel
            // 
            this.PhoneNoLabel.AutoSize = true;
            this.PhoneNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNoLabel.Location = new System.Drawing.Point(10, 110);
            this.PhoneNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneNoLabel.Name = "PhoneNoLabel";
            this.PhoneNoLabel.Size = new System.Drawing.Size(101, 17);
            this.PhoneNoLabel.TabIndex = 58;
            this.PhoneNoLabel.Text = "Phone number";
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(148, 66);
            this.customerName.Margin = new System.Windows.Forms.Padding(2);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(209, 23);
            this.customerName.TabIndex = 56;
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameLabel.Location = new System.Drawing.Point(10, 66);
            this.CustNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(109, 17);
            this.CustNameLabel.TabIndex = 57;
            this.CustNameLabel.Text = "Customer Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.CustomerIdLabel);
            this.panel2.Controls.Add(this.customerID);
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.clearButton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.EmailLabel);
            this.panel2.Controls.Add(this.customerAddress);
            this.panel2.Controls.Add(this.addressLabel);
            this.panel2.Controls.Add(this.CustPhno);
            this.panel2.Controls.Add(this.PhoneNoLabel);
            this.panel2.Controls.Add(this.customerName);
            this.panel2.Controls.Add(this.CustNameLabel);
            this.panel2.Location = new System.Drawing.Point(81, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 336);
            this.panel2.TabIndex = 69;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(735, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 405);
            this.dataGridView1.TabIndex = 82;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(656, 44);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(5, 553);
            this.divider.TabIndex = 81;
            // 
            // customerID
            // 
            this.customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.Location = new System.Drawing.Point(149, 22);
            this.customerID.Margin = new System.Windows.Forms.Padding(2);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(108, 23);
            this.customerID.TabIndex = 55;
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdLabel.Location = new System.Drawing.Point(11, 22);
            this.CustomerIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(85, 17);
            this.CustomerIdLabel.TabIndex = 68;
            this.CustomerIdLabel.Text = "Customer ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(285, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 31);
            this.button1.TabIndex = 69;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "CustomerUpdate";
            this.Text = "CustomerUpdate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox CustPhno;
        private System.Windows.Forms.Label PhoneNoLabel;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label CustNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Button button1;
    }
}