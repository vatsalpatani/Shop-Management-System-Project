using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SMS
{
    public partial class StockView : Form
    {
        databasequery query = new databasequery();
        public StockView()
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
                    Quantity.Text = query.dt.Rows[0][1].ToString();
                    string sql = "select * from Products where pid = '" + ProductID.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(sql, query.cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Productname.Text = dt.Rows[0][1].ToString();
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

        private void clear_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void cleardata()
        {
            ProductID.Text = Quantity.Text = Productname.Text = string.Empty;
        }

        private void StockView_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
