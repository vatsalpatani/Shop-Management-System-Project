namespace SMS
{
    partial class OrderDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDelete));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.OrderID = new System.Windows.Forms.TextBox();
            this.orderlbl = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(568, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DELETE ORDERS";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(161, 100);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 25);
            this.Delete.TabIndex = 46;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // OrderID
            // 
            this.OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderID.Location = new System.Drawing.Point(127, 58);
            this.OrderID.Margin = new System.Windows.Forms.Padding(2);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(135, 23);
            this.OrderID.TabIndex = 45;
            // 
            // orderlbl
            // 
            this.orderlbl.AutoSize = true;
            this.orderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderlbl.Location = new System.Drawing.Point(31, 58);
            this.orderlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderlbl.Name = "orderlbl";
            this.orderlbl.Size = new System.Drawing.Size(75, 17);
            this.orderlbl.TabIndex = 44;
            this.orderlbl.Text = "ORDER ID";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(31, 100);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(112, 25);
            this.clear.TabIndex = 43;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.OrderID);
            this.panel2.Controls.Add(this.orderlbl);
            this.panel2.Controls.Add(this.clear);
            this.panel2.Location = new System.Drawing.Point(124, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 200);
            this.panel2.TabIndex = 47;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(728, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 405);
            this.dataGridView1.TabIndex = 84;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(649, 43);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(5, 553);
            this.divider.TabIndex = 83;
            // 
            // OrderDelete
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
            this.Name = "OrderDelete";
            this.Text = "OrderDelete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderDelete_Load);
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
        private System.Windows.Forms.TextBox OrderID;
        private System.Windows.Forms.Label orderlbl;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label divider;
    }
}