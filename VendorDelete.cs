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

namespace SMS
{
    public partial class VendorDelete : Form
    {
        databasequery query = new databasequery();  
        public VendorDelete()
        {
            InitializeComponent();
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

        private void Search_Click(object sender, EventArgs e)
        {
            if (VendorName.Text == "")
            {
                MessageBox.Show("Please Enter Name", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
                else
                {
                    MessageBox.Show("No Data Avilable", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VendorName.Clear();
                    VendorID.Clear();
                    VendorName.Focus();
                }
                loaddata();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (VendorID.Text == "")
            {
                MessageBox.Show("Please Enter Id", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VendorID.Focus();
            }
            else
            {
                string qtp = "delete";
                string tbnm = "Vendors";
                string qty = "where vid = '" + VendorID.Text + "'";
                query.crud(qtp, tbnm, qty);
                MessageBox.Show("Vendor Delete Successfully ...!!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
                VendorID.Text = VendorName.Text = string.Empty;
            }
        }

        private void VendorDelete_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
