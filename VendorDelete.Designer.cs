namespace SMS
{
    partial class VendorDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorDelete));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.VendorID = new System.Windows.Forms.TextBox();
            this.VendorIDlbl = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.VendorName = new System.Windows.Forms.TextBox();
            this.Vendornamelbl = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(587, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DELETE VENDOR";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(324, 108);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 31);
            this.Delete.TabIndex = 52;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // VendorID
            // 
            this.VendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorID.Location = new System.Drawing.Point(121, 110);
            this.VendorID.Margin = new System.Windows.Forms.Padding(2);
            this.VendorID.Name = "VendorID";
            this.VendorID.Size = new System.Drawing.Size(151, 23);
            this.VendorID.TabIndex = 51;
            // 
            // VendorIDlbl
            // 
            this.VendorIDlbl.AutoSize = true;
            this.VendorIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorIDlbl.Location = new System.Drawing.Point(7, 110);
            this.VendorIDlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VendorIDlbl.Name = "VendorIDlbl";
            this.VendorIDlbl.Size = new System.Drawing.Size(71, 17);
            this.VendorIDlbl.TabIndex = 50;
            this.VendorIDlbl.Text = "Vendor ID";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(324, 65);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 29);
            this.Search.TabIndex = 54;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // VendorName
            // 
            this.VendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorName.Location = new System.Drawing.Point(121, 69);
            this.VendorName.Margin = new System.Windows.Forms.Padding(2);
            this.VendorName.Name = "VendorName";
            this.VendorName.Size = new System.Drawing.Size(151, 23);
            this.VendorName.TabIndex = 48;
            // 
            // Vendornamelbl
            // 
            this.Vendornamelbl.AutoSize = true;
            this.Vendornamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendornamelbl.Location = new System.Drawing.Point(11, 69);
            this.Vendornamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Vendornamelbl.Name = "Vendornamelbl";
            this.Vendornamelbl.Size = new System.Drawing.Size(95, 17);
            this.Vendornamelbl.TabIndex = 53;
            this.Vendornamelbl.Text = "Vendor Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.VendorID);
            this.panel2.Controls.Add(this.VendorIDlbl);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.VendorName);
            this.panel2.Controls.Add(this.Vendornamelbl);
            this.panel2.Location = new System.Drawing.Point(85, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 224);
            this.panel2.TabIndex = 55;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(738, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 405);
            this.dataGridView1.TabIndex = 86;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(659, 43);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(5, 553);
            this.divider.TabIndex = 85;
            // 
            // VendorDelete
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
            this.Name = "VendorDelete";
            this.Text = "VendorDelete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VendorDelete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox VendorID;
        private System.Windows.Forms.Label VendorIDlbl;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox VendorName;
        private System.Windows.Forms.Label Vendornamelbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label divider;
    }
}