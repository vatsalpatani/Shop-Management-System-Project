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
using static System.Net.WebRequestMethods;

namespace SMS
{
    public partial class ProductInsert : Form
    {
        databasequery query = new databasequery();
        public ProductInsert()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void loaddata()
        {
            query.dt.Clear();
            string qtp = "select";
            string tbnm = "Products";
            string qty = "";
            query.crud(qtp, tbnm, qty);
            if (query.dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = query.dt;
            }
        }

        private void cleardata()
        {
            ProductName.Text = VendorID.Text = Amount.Text = string.Empty;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string tbnm = "";
            string qtp = "";
            string data = "";
            if (ProductName.Text == "" || VendorID.Text == "" || Amount.Text == "" )
            {
                MessageBox.Show("Please provide All Information", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductName.Focus();
            }
            else
            {
                string pvid = VendorID.Text;
                qtp = "select";
                tbnm = "Vendors";
                data = "where vid = '" + pvid +"'";
                query.crud(qtp, tbnm, data);
                if (query.dt.Rows.Count > 0)
                {
                    tbnm = "Products";
                    qtp = "insert";
                    data = ProductName.Text + "','" + Amount.Text + "','" + VendorID.Text;
                    query.crud(qtp, tbnm, data);
                    MessageBox.Show("Product Add Successfully ...!!!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleardata();
                }
                else
                {
                    MessageBox.Show("Provided Vendor Id is Not Available", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VendorID.Clear();
                    VendorID.Focus();
                }
                
                loaddata();
            }
        }

        private void ProductInsert_Load(object sender, EventArgs e)
        {
            loaddata();
        }

    }
}
