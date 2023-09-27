using System;
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
    public partial class CustomerView : Form
    {
        databasequery query = new databasequery();
        public CustomerView()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void cleardata()
        {
            CustomerName.Text = CustID.Text = CustName.Text = PhoneNo.Text = Address.Text = Email.Text = string.Empty;
            loaddata();
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
            if(CustomerName.Text == "")
            {
                MessageBox.Show("Please Enter Customer Name", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustomerName.Focus();
            }
            else
            {
                string qtp = "select";
                string tbnm = "Customers";
                string qty = "where cname = '"+ CustomerName.Text +"'";
                query.crud(qtp, tbnm, qty);
                if (query.dt.Rows.Count > 0)
                {
                    CustID.Text = query.dt.Rows[0][0].ToString();
                    CustName.Text = query.dt.Rows[0][1].ToString(); 
                    Address.Text = query.dt.Rows[0][2].ToString();
                    PhoneNo.Text = query.dt.Rows[0][3].ToString();
                    Email.Text = query.dt.Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("No Data Avilable", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleardata();
                    CustomerName.Focus();
                    loaddata();
                }
            }
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        
    }
}
