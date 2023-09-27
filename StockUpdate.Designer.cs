namespace SMS
{
    partial class StockUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockUpdate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.ProductIDlbl = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(606, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE STOCK";
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(283, 216);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(104, 34);
            this.update.TabIndex = 59;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(98, 216);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(104, 34);
            this.clear.TabIndex = 58;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(156, 155);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(281, 23);
            this.Quantity.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Quantity";
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(156, 106);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Size = new System.Drawing.Size(281, 23);
            this.ProductName.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Product Name";
            // 
            // ProductID
            // 
            this.ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(156, 59);
            this.ProductID.Margin = new System.Windows.Forms.Padding(2);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(144, 23);
            this.ProductID.TabIndex = 53;
            // 
            // ProductIDlbl
            // 
            this.ProductIDlbl.AutoSize = true;
            this.ProductIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDlbl.Location = new System.Drawing.Point(48, 64);
            this.ProductIDlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductIDlbl.Name = "ProductIDlbl";
            this.ProductIDlbl.Size = new System.Drawing.Size(74, 17);
            this.ProductIDlbl.TabIndex = 52;
            this.ProductIDlbl.Text = "Product ID";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(333, 53);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(104, 34);
            this.search.TabIndex = 60;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.Quantity);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ProductName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ProductID);
            this.panel2.Controls.Add(this.ProductIDlbl);
            this.panel2.Controls.Add(this.search);
            this.panel2.Location = new System.Drawing.Point(90, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 297);
            this.panel2.TabIndex = 61;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(744, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 405);
            this.dataGridView1.TabIndex = 82;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(665, 43);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(5, 553);
            this.divider.TabIndex = 81;
            // 
            // StockUpdate
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
            this.Name = "StockUpdate";
            this.Text = "StockUpdate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockUpdate_Load);
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
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Label ProductIDlbl;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label divider;
    }
}