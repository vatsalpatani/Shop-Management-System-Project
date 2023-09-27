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
    public partial class VendorInsert : Form
    {
        databasequery query = new databasequery();
        public VendorInsert()
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
            string tbnm = "Vendors";
            string qty = "";
            query.crud(qtp, tbnm, qty);
            if (query.dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = query.dt;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void cleardata()
        {
            VendorAddress.Text =  VendorName.Text = PhoneNO.Text = Email.Text = string.Empty;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (VendorName.Text == "" || Email.Text == "" || VendorAddress.Text == "" || PhoneNO.Text == "")
            {
                MessageBox.Show("Please provide All Information", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VendorName.Focus();
            }
            else if (!phone(PhoneNO.Text))
            {
                MessageBox.Show("Enter Proper Mobile Number", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneNO.Clear();
                PhoneNO.Focus();
            }
            else if (!email(Email.Text))
            {
                MessageBox.Show("Enter Proper Email Address", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Email.Clear();
                Email.Focus();
            }
            else
            {
                string tbnm = "Vendors";
                string qtp = "insert";
                string data = VendorName.Text + "','" + VendorAddress.Text + "','" + PhoneNO.Text + "','" + Email.Text;
                query.crud(qtp, tbnm, data);
                MessageBox.Show("Vendor Add Successfully ...!!!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
                loaddata();
            }
        }

        private void VendorInsert_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
