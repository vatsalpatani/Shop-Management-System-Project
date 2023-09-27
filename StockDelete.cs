using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class StockDelete : Form
    {
        databasequery query = new databasequery();
        public StockDelete()
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

        private void StockDelete_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (ProductID.Text == "")
            {
                MessageBox.Show("Please Enter Product ID", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string sql = "select * from Products where pid = '" + ProductID.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, query.cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ProductName.Text = query.dt.Rows[0][0].ToString();
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

        private void cleardata()
        {
            ProductID.Clear();
            ProductName.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductID.Focus();
            }
            else
            {
                string qtp = "delete";
                string tbnm = "Products";
                string qty = "where pname = '" + ProductName.Text + "'";
                query.crud(qtp, tbnm, qty);
                MessageBox.Show("Stock Delete Successfully ...!!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
                ProductID.Text = ProductName.Text = string.Empty;
            }
        }
    }
}
