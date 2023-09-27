using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class VendorView : Form
    {
        databasequery query = new databasequery();
        public VendorView()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            cleardata();
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

        private void cleardata()
        {
            VendorName.Text = VendorName2.Text = VendorID.Text = VendorPhoneNo.Text = Email.Text = VendorAddress.Text = string.Empty;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (VendorName.Text == "")
            {
                MessageBox.Show("Please Enter Vendor Name", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VendorName.Focus();
            }
            else
            {
                string qtp = "select";
                string tbnm = "Vendors";
                string qty = "where vname = '" + VendorName.Text + "'";
                query.crud(qtp, tbnm, qty);
                if (query.dt.Rows.Count > 0)
                {
                    VendorID.Text = query.dt.Rows[0][0].ToString();
                    VendorName2.Text = query.dt.Rows[0][1].ToString();
                    VendorAddress.Text = query.dt.Rows[0][2].ToString();
                    VendorPhoneNo.Text = query.dt.Rows[0][3].ToString();
                    Email.Text = query.dt.Rows[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("No Data Avilable", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleardata();
                    VendorName.Focus();
                    loaddata();
                }
            }
        }

        private void VendorView_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
