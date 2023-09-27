using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SMS
{
    public partial class ProductUpdate : Form
    {
        databasequery query = new databasequery();
        public ProductUpdate()
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


        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void cleardata()
        {
            VendorID.Text = productID.Text = ProductName.Text = Amount.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (productID.Text == "")
            {
                MessageBox.Show("Please Enter Id", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productID.Focus();
            }
            else
            {
                string qtp = "select";
                string tbnm = "Products";
                string qty = "where pid = '" + productID.Text + "'";
                query.crud(qtp, tbnm, qty);
                if (query.dt.Rows.Count > 0)
                {
                    ProductName.Text = query.dt.Rows[0][1].ToString();
                    Amount.Text = query.dt.Rows[0][2].ToString();
                    VendorID.Text = query.dt.Rows[0][3].ToString();
                }
                else
                {
                    MessageBox.Show("No Data Avilable", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    productID.Clear();
                    productID.Focus();
                }
                loaddata();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "" || productID.Text == "" || Amount.Text == "" || VendorID.Text == "" )
            {
                MessageBox.Show("Please provide All Information", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productID.Focus();
            }
            else
            {
                string pvid = VendorID.Text;
                string qtp = "select";
                string tbnm = "Vendors";
                string data = "where vid = '" + pvid + "'";
                query.crud(qtp, tbnm, data);
                if (query.dt.Rows.Count > 0)
                {
                    string tbnm1 = "Products";
                    string qtp1 = "update";
                    string data1 = "pname = '" + ProductName.Text + "', pamount = '" + Amount.Text + "', vid = '" + VendorID.Text + "' where pid = '" + productID.Text + "'";
                    query.crud(qtp1, tbnm1, data1);
                    MessageBox.Show("Customer Update Successfully ...!!!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleardata();
                }
                else
                {
                    MessageBox.Show("Provided Vendor Id is Not Available", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VendorID.Clear();
                    VendorID.Focus();
                }
                loaddata();
            }
        }
    }
}
