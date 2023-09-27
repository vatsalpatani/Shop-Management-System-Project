namespace SMS
{
    partial class OrderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewData = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.orderID = new System.Windows.Forms.TextBox();
            this.OrderIdlbl = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewData)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(638, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIEW ORDERS";
            // 
            // ViewData
            // 
            this.ViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ViewData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewData.Location = new System.Drawing.Point(37, 115);
            this.ViewData.Margin = new System.Windows.Forms.Padding(2);
            this.ViewData.Name = "ViewData";
            this.ViewData.RowTemplate.Height = 24;
            this.ViewData.Size = new System.Drawing.Size(857, 310);
            this.ViewData.TabIndex = 49;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(313, 61);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(64, 27);
            this.Search.TabIndex = 48;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // orderID
            // 
            this.orderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderID.Location = new System.Drawing.Point(134, 65);
            this.orderID.Margin = new System.Windows.Forms.Padding(2);
            this.orderID.Name = "orderID";
            this.orderID.Size = new System.Drawing.Size(162, 23);
            this.orderID.TabIndex = 47;
            // 
            // OrderIdlbl
            // 
            this.OrderIdlbl.AutoSize = true;
            this.OrderIdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdlbl.Location = new System.Drawing.Point(65, 65);
            this.OrderIdlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderIdlbl.Name = "OrderIdlbl";
            this.OrderIdlbl.Size = new System.Drawing.Size(62, 17);
            this.OrderIdlbl.TabIndex = 46;
            this.OrderIdlbl.Text = "Order ID";
            // 
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(406, 62);
            this.Print.Margin = new System.Windows.Forms.Padding(2);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(64, 27);
            this.Print.TabIndex = 51;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ViewData);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.orderID);
            this.Controls.Add(this.OrderIdlbl);
            this.Controls.Add(this.Print);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "OrderView";
            this.Text = "OrderView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ViewData;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox orderID;
        private System.Windows.Forms.Label OrderIdlbl;
        private System.Windows.Forms.Button Print;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}