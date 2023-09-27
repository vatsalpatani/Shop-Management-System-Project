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
    public partial class StockInsert : Form
    {
        public StockInsert()
        {
            InitializeComponent();
        }

        databasequery query = new databasequery();

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
            if (ProductNam.Text == "")
            {
                MessageBox.Show("Please Enter Product Name", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductId.Focus();
            }
            else
            {
                string sql = "select * from Products where pname = '" + ProductNam.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, query.cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    ProductId.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("No Data Avilable", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleardata();
                    ProductNam.Focus();
                    loaddata();
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            cleardata();
            ProductNam.Focus();
            
        }

        private void cleardata()
        {
            ProductId.Text = ProductNam.Text = Quantity.Text = string.Empty;
            loaddata();
        }

        private void StockInsert_Load(object sender, EventArgs e)
        {
            loaddata();
                        
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (ProductNam.Text == "" || ProductId.Text == "" || Quantity.Text == "")
            {
                MessageBox.Show("Please provide All Information", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Quantity.Focus();
            }
            else
            {
                string qtp = "select";
                string tbnm = "Stocks";
                string qty = "where pid = '" + ProductId.Text + "'";
                query.crud(qtp, tbnm, qty);
                if (query.dt.Rows.Count > 0)
                {
                    int quantity = Convert.ToInt32(query.dt.Rows[0][1]);
                    quantity += Convert.ToInt32(Quantity.Text);
                    string tbnm1 = "Stocks";
                    string qtp1 = "update";
                    string data1 = "quantity = '" + quantity + "' where pid = '" + ProductId.Text + "'";
                    query.crud(qtp1, tbnm1, data1);
                }
                else
                {
                    string tbnm1 = "Stocks";
                    string qtp1 = "insert";
                    string data1 = ProductId.Text + "','" + Quantity.Text;
                    query.crud(qtp1, tbnm1, data1);
                }
                MessageBox.Show("Stock Add Successfully ...!!!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cleardata();
                loaddata();
            }
        }
    }
}
