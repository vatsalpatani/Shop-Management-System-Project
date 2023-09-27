namespace SMS
{
    partial class ProductUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUpdate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VendorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.divider = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(548, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "UPDATE PRODUCTS";
            // 
            // productID
            // 
            this.productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productID.Location = new System.Drawing.Point(185, 43);
            this.productID.Margin = new System.Windows.Forms.Padding(2);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(94, 23);
            this.productID.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "Product ID";
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(221, 248);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(141, 31);
            this.Update.TabIndex = 80;
            this.Update.Text = "UPDATE";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(58, 248);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(129, 31);
            this.Clear.TabIndex = 79;
            this.Clear.Text = "CLEAR";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(185, 157);
            this.Amount.Margin = new System.Windows.Forms.Padding(2);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(188, 23);
            this.Amount.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Amount";
            // 
            // VendorID
            // 
            this.VendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorID.Location = new System.Drawing.Point(185, 118);
            this.VendorID.Margin = new System.Windows.Forms.Padding(2);
            this.VendorID.Name = "VendorID";
            this.VendorID.Size = new System.Drawing.Size(188, 23);
            this.VendorID.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Vendor ID";
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(185, 77);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(188, 23);
            this.ProductName.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Product Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.productID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Update);
            this.panel2.Controls.Add(this.Clear);
            this.panel2.Controls.Add(this.Amount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.VendorID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ProductName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(74, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 314);
            this.panel2.TabIndex = 82;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(707, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 405);
            this.dataGridView1.TabIndex = 84;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(628, 44);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(5, 553);
            this.divider.TabIndex = 83;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(305, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 24);
            this.button1.TabIndex = 82;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ProductUpdate";
            this.Text = "ProductUpdate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VendorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Button button1;
    }
}