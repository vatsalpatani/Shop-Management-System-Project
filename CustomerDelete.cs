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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SMS
{
    public partial class CustomerDelete : Form
    {
        databasequery query = new databasequery();
        public CustomerDelete()
        {
            InitializeComponent();
        }

        private void loaddata()
        {
            string qtp = "select";
            string tbnm = "Customers";
            string qty = "";
            query.crud(qtp, tbnm, qty);
            if (query.dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = query.dt;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (CustomerName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustomerName.Focus();
            }
            else
            {
                string qtp = "select";
                string tbnm = "Customers";
                string qty = "where cname = '" + CustomerName.Text + "'";
                query.crud(qtp, tbnm, qty);
                if (query.dt.Rows.Count > 0)
                {
                    CustomerID.Text = query.dt.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("No Data Avilable", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CustomerName.Clear();
                    CustomerID.Clear(); 
                    CustomerName.Focus();
                }
                loaddata();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (CustomerID.Text == "")
            {
                MessageBox.Show("Please Enter Id", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustomerID.Focus();
            }
            else
            {
                string qtp = "delete";
                string tbnm = "Customers";
                string qty = "where cid = '" + CustomerID.Text + "'";
                query.crud(qtp, tbnm, qty);
                MessageBox.Show("Customer Delete Successfully ...!!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
                CustomerID.Text = CustomerName.Text = string.Empty;
            }
        }

        private void CustomerDelete_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
