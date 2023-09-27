namespace SMS
{
    partial class ProductDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDelete));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.ProdIDlbl = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductNamelbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.divider = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(985, 43);
            this.panel1.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(556, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "DELETE PRODUCTS";
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Red;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(271, 90);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(62, 29);
            this.Deletebtn.TabIndex = 63;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // ProductID
            // 
            this.ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(106, 93);
            this.ProductID.Margin = new System.Windows.Forms.Padding(2);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(146, 23);
            this.ProductID.TabIndex = 62;
            // 
            // ProdIDlbl
            // 
            this.ProdIDlbl.AutoSize = true;
            this.ProdIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIDlbl.Location = new System.Drawing.Point(2, 96);
            this.ProdIDlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProdIDlbl.Name = "ProdIDlbl";
            this.ProdIDlbl.Size = new System.Drawing.Size(74, 17);
            this.ProdIDlbl.TabIndex = 61;
            this.ProdIDlbl.Text = "Product ID";
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(271, 40);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(62, 29);
            this.Searchbtn.TabIndex = 60;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(106, 43);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(146, 23);
            this.ProductName.TabIndex = 59;
            // 
            // ProductNamelbl
            // 
            this.ProductNamelbl.AutoSize = true;
            this.ProductNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNamelbl.Location = new System.Drawing.Point(4, 45);
            this.ProductNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductNamelbl.Name = "ProductNamelbl";
            this.ProductNamelbl.Size = new System.Drawing.Size(98, 17);
            this.ProductNamelbl.TabIndex = 58;
            this.ProductNamelbl.Text = "Product Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Deletebtn);
            this.panel2.Controls.Add(this.ProductID);
            this.panel2.Controls.Add(this.ProdIDlbl);
            this.panel2.Controls.Add(this.Searchbtn);
            this.panel2.Controls.Add(this.ProductName);
            this.panel2.Controls.Add(this.ProductNamelbl);
            this.panel2.Location = new System.Drawing.Point(82, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 190);
            this.panel2.TabIndex = 64;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(712, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 405);
            this.dataGridView1.TabIndex = 82;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(633, 43);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(5, 553);
            this.divider.TabIndex = 81;
            // 
            // ProductDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ProductDelete";
            this.Text = "ProductDelete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductDelete_Load);
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
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Label ProdIDlbl;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label ProductNamelbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label divider;
    }
}