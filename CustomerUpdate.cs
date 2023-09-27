using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class CustomerUpdate : Form
    {
        databasequery query = new databasequery();
        public CustomerUpdate()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        System.Text.RegularExpressions.Regex expr;

        public bool email(string email)
        {
            expr = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
            if (expr.IsMatch(email))
            {
                return true;
            }
            else return false;
        }
        public bool phone(string no)
        {
            expr = new Regex(@"^\d{10}$");
            if (expr.IsMatch(no))
            {
                return true;
            }
            else return false;
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

        private void cleardata()
        {
            customerID.Text = customerAddress.Text = customerName.Text = CustPhno.Text = Email.Text = string.Empty;
        }

        private void CustomerUpdate_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (customerID.Text == "")
            {
                MessageBox.Show("Please Enter Id", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerID.Focus();
            }
            else
            {
                string qtp = "select";
                string tbnm = "Customers";
                string qty = "where cid = '" + customerID.Text +"'";
                query.crud(qtp, tbnm, qty);
                if (query.dt.Rows.Count > 0)
                {
                    customerName.Text = query.dt.Rows[0][1].ToString();
                    customerAddress.Text = query.dt.Rows[0][2].ToString();
                    CustPhno.Text = query.dt.Rows[0][3].ToString();
                    Email.Text = query.dt.Rows[0][4].ToString(); 
                }
                else
                {
                    MessageBox.Show("No Data Avilable", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerID.Clear();
                    customerID.Focus();
                }
                loaddata();
            }
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            if (customerName.Text == "" || Email.Text == "" || customerAddress.Text == "" || CustPhno.Text == "" || customerID.Text == "")
            {
                MessageBox.Show("Please provide All Information", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerID.Focus();
            }
            else if (!phone(CustPhno.Text))
            {
                MessageBox.Show("Enter Proper Mobile Number", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustPhno.Clear();
                CustPhno.Focus();
            }
            else if (!email(Email.Text))
            {
                MessageBox.Show("Enter Proper Email Address", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Email.Clear();
                Email.Focus();
            }
            else
            {
                string tbnm = "Customers";
                string qtp = "update";
                string data = "cname = '" + customerName.Text + "', caddress = '" + customerAddress.Text + "', cphno = '" + CustPhno.Text + "', cemail = '" + Email.Text + "' where cid = '" + customerID.Text + "'";
                query.crud(qtp, tbnm, data);
                MessageBox.Show("Customer Update Successfully ...!!!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
                loaddata();
            }
        }
    }
}
