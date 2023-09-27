namespace SMS
{
    partial class StockInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInsert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductIdlbl = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.divider = new System.Windows.Forms.Label();
            this.ProductNam = new System.Windows.Forms.TextBox();
            this.ProductId = new System.Windows.Forms.TextBox();
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
            this.panel1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(615, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSERT STOCK";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(272, 233);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(104, 34);
            this.Add.TabIndex = 58;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(55, 233);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(104, 34);
            this.clear.TabIndex = 57;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Quantity
            // 
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(144, 172);
            this.Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(248, 23);
            this.Quantity.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Product Name";
            // 
            // ProductIdlbl
            // 
            this.ProductIdlbl.AutoSize = true;
            this.ProductIdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdlbl.Location = new System.Drawing.Point(32, 123);
            this.ProductIdlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductIdlbl.Name = "ProductIdlbl";
            this.ProductIdlbl.Size = new System.Drawing.Size(74, 17);
            this.ProductIdlbl.TabIndex = 51;
            this.ProductIdlbl.Text = "Product ID";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(303, 72);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(92, 30);
            this.search.TabIndex = 59;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProductId);
            this.panel2.Controls.Add(this.ProductNam);
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.Quantity);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ProductIdlbl);
            this.panel2.Controls.Add(this.search);
            this.panel2.Location = new System.Drawing.Point(103, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 314);
            this.panel2.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(752, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 405);
            this.dataGridView1.TabIndex = 82;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(673, 43);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(5, 553);
            this.divider.TabIndex = 81;
            // 
            // ProductNam
            // 
            this.ProductNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNam.Location = new System.Drawing.Point(144, 76);
            this.ProductNam.Margin = new System.Windows.Forms.Padding(2);
            this.ProductNam.Name = "ProductNam";
            this.ProductNam.Size = new System.Drawing.Size(146, 23);
            this.ProductNam.TabIndex = 60;
            // 
            // ProductId
            // 
            this.ProductId.BackColor = System.Drawing.SystemColors.Control;
            this.ProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductId.Location = new System.Drawing.Point(144, 123);
            this.ProductId.Margin = new System.Windows.Forms.Padding(2);
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Size = new System.Drawing.Size(248, 23);
            this.ProductId.TabIndex = 61;
            // 
            // StockInsert
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
            this.Name = "StockInsert";
            this.Text = "StockInsert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockInsert_Load);
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
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProductIdlbl;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.TextBox ProductId;
        private System.Windows.Forms.TextBox ProductNam;
    }
}