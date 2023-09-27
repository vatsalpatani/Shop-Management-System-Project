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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SMS
{
    public partial class VendorUpdate : Form
    {
        databasequery query = new databasequery();
        public VendorUpdate()
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
            VendorID.Text = VendorAddress.Text = VendorName.Text = PhoneNumber.Text = Email.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VendorID.Text == "")
            {
                MessageBox.Show("Please Enter Id", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VendorID.Focus();
            }
            else
            {
                string qtp = "select";
                string tbnm = "Vendors";
                string qty = "where vid = '" + VendorID.Text + "'";
                query.crud(qtp, tbnm, qty);
                if (query.dt.Rows.Count > 0)
                {
                    VendorName.Text = query.dt.Rows[0][1].ToString();
                    VendorAddress.Text = query.dt.Rows[0][2].ToString();
                    PhoneNumber.Text = query.dt.Rows[0][3].ToString();
                    Email.Text = query.dt.Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("No Data Avilable", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VendorID.Clear();
                    VendorID.Focus();
                }
                loaddata();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (VendorName.Text == "" || Email.Text == "" || VendorAddress.Text == "" || PhoneNumber.Text == "" || VendorID.Text == "")
            {
                MessageBox.Show("Please provide All Information", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VendorID.Focus();
            }
            else if (!phone(PhoneNumber.Text))
            {
                MessageBox.Show("Enter Proper Mobile Number", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneNumber.Clear();
                PhoneNumber.Focus();
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
                string qtp = "update";
                string data = "vname = '" + VendorName.Text + "', vaddress = '" + VendorAddress.Text + "', vphno = '" + PhoneNumber.Text + "', vemail = '" + Email.Text + "' where vid = '" + VendorID.Text + "'";
                query.crud(qtp, tbnm, data);
                MessageBox.Show("Customer Update Successfully ...!!!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleardata();
                loaddata();
            }
        }

        private void VendorUpdate_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
