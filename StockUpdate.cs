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
using System.Data.Sql;
using System.Data.SqlClient;

namespace SMS
{
    public partial class StockUpdate : Form
    {
        databasequery query = new databasequery();

        public StockUpdate()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            string qtp = "select";
            string tbnm = "Stocks";
            string qty = "";
            query.crud(qtp, tbnm, qty);
            if (query.dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = query.dt;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (ProductID.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductID.Focus();
            }
            else
            {
                string qtp = "select";
                string tbnm = "Stocks";
                string qty = "where pid = '" + ProductID.Text + "'";
                query.crud(qtp, tbnm, qty);
                if (query.dt.Rows.Count > 0)
                {
                    Quantity.Text = query.dt.Rows[0][1].ToString();
                    string sql = "select * from Products where pid = '" + ProductID.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(sql ,query.cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ProductName.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("No Data Avilable", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleardata();
                    ProductID.Focus();
                    loaddata();
                }
            }
        }

        private void StockUpdate_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void cleardata()
        {
            ProductID.Text = Quantity.Text = ProductName.Text = string.Empty;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "" || ProductID.Text == "" || Quantity.Text == "" )
            {
                MessageBox.Show("Please provide All Information", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Quantity.Focus();
            }
            else
            {
                string pvid = ProductID.Text;
                string qtp = "select";
                string tbnm = "Products";
                string data = "where pid = '" + pvid + "'";
                query.crud(qtp, tbnm, data);
                if (query.dt.Rows.Count > 0)
                {
                    string tbnm1 = "Stocks";
                    string qtp1 = "update";
                    string data1 = "quantity = '" + Quantity.Text +  "' where pid = '" + ProductID.Text + "'";
                    query.crud(qtp1, tbnm1, data1);
                    MessageBox.Show("Stock Update Successfully ...!!!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleardata();
                }
                else
                {
                    MessageBox.Show("Provided Product Id is Not Available", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ProductID.Clear();
                    ProductID.Focus();
                }
                loaddata();
            }
        }
    }
}
