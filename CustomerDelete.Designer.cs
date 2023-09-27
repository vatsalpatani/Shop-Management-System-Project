namespace SMS
{
    partial class CustomerDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDelete));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.CustIDLabel = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustNameLabel = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(550, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "DELETE CUSTOMER DETAILS";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(283, 69);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(62, 29);
            this.Delete.TabIndex = 50;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(152, 73);
            this.CustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(76, 23);
            this.CustomerID.TabIndex = 49;
            // 
            // CustIDLabel
            // 
            this.CustIDLabel.AutoSize = true;
            this.CustIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustIDLabel.Location = new System.Drawing.Point(40, 77);
            this.CustIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(85, 17);
            this.CustIDLabel.TabIndex = 48;
            this.CustIDLabel.Text = "Customer ID";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(283, 20);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(62, 29);
            this.Search.TabIndex = 47;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(152, 26);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(76, 23);
            this.CustomerName.TabIndex = 45;
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameLabel.Location = new System.Drawing.Point(42, 26);
            this.CustNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(109, 17);
            this.CustNameLabel.TabIndex = 46;
            this.CustNameLabel.Text = "Customer Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.CustomerID);
            this.panel2.Controls.Add(this.CustIDLabel);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Controls.Add(this.CustomerName);
            this.panel2.Controls.Add(this.CustNameLabel);
            this.panel2.Location = new System.Drawing.Point(163, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 130);
            this.panel2.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(753, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 405);
            this.dataGridView1.TabIndex = 84;
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(674, 43);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(5, 553);
            this.divider.TabIndex = 83;
            // 
            // CustomerDelete
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
            this.Name = "CustomerDelete";
            this.Text = "CustomerDelete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerDelete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Label CustIDLabel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label CustNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label divider;
    }
}