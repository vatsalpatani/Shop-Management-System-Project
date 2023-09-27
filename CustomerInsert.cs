using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SMS
{
    public partial class CustomerInsert : Form
    {
        databasequery query = new databasequery();
        public CustomerInsert()
        {
            InitializeComponent();
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void cleardata()
        {
            CustomerAddress.Text = CustomerEmail.Text = phno.Text = CustomerName.Text = string.Empty;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (CustomerName.Text == "" || CustomerEmail.Text == "" || CustomerAddress.Text == "" || phno.Text == "")
            {
                MessageBox.Show("Please provide All Information", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustomerName.Focus();
            }
            else if (!phone(phno.Text))
            {
                MessageBox.Show("Enter Proper Mobile Number", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phno.Clear();
                phno.Focus();
            }
            else if (!email(CustomerEmail.Text))
            {
                MessageBox.Show("Enter Proper Email Address", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CustomerEmail.Clear();
                CustomerEmail.Focus();
            }
            else
            {
                string tbnm = "Customers";
                string qtp = "insert";
                string data = CustomerName.Text + "','" + CustomerAddress.Text + "','" + phno.Text + "','" + CustomerEmail.Text;
                query.crud(qtp, tbnm, data);
                MessageBox.Show("Customer Add Successfully ...!!!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
                loaddata();
            }
        }

        private void CustomerInsert_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
