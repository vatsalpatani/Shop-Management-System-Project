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

namespace SMS
{
    public partial class ProductDelete : Form
    {
        databasequery query = new databasequery();
        public ProductDelete()
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

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
                else
                {
                    MessageBox.Show("No Data Avilable", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ProductName.Clear();
                    ProductID.Clear();
                    ProductName.Focus();
                }
                loaddata();
            }
        }

        private void ProductDelete_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (ProductID.Text == "")
            {
                MessageBox.Show("Please Enter Id", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductID.Focus();
            }
            else
            {
                string qtp = "delete";
                string tbnm = "Products";
                string qty = "where pid = '" + ProductID.Text + "'";
                query.crud(qtp, tbnm, qty);
                MessageBox.Show("Product Delete Successfully ...!!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
                ProductID.Text = ProductName.Text = string.Empty;
            }
        }
    }
}
