using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SMS
{
    public partial class ProductView : Form
    {
        databasequery query = new databasequery();
        public ProductView()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            string qtp = "select";
            string tbnm = "Products";
            string qty = "";
            query.crud(qtp, tbnm, qty);
            if (query.dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = query.dt;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            cleardata();
            loaddata();
        }

        private void cleardata()
        {
            ProdName.Text = ProductName.Text = VendorID.Text = Amount.Text = ProductID.Text = string.Empty;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductName.Focus();
            }
            else
            {
                string qtp = "select";
                string tbnm = "Products";
                string qty = "where pname = '" + ProductName.Text + "'";
                query.crud(qtp, tbnm, qty);
                if (query.dt.Rows.Count > 0)
                {
                    ProductID.Text = query.dt.Rows[0][0].ToString();
                    ProdName.Text = query.dt.Rows[0][1].ToString();
                    Amount.Text = query.dt.Rows[0][2].ToString();
                    VendorID.Text = query.dt.Rows[0][3].ToString();
                }
                else
                {
                    MessageBox.Show("No Data Avilable", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleardata();
                    ProductName.Focus();
                    loaddata();
                }
            }
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
