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
    public partial class OrderDelete : Form
    {
        databasequery query = new databasequery();
        public OrderDelete()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            OrderID.Clear();
        }

        private void loaddata()
        {
            string qtp = "select";
            string tbnm = "Orders";
            string qty = "";
            query.crud(qtp, tbnm, qty);
            if (query.dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = query.dt;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(OrderID.Text == "")
            {
                MessageBox.Show("Please Enter Order Id", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OrderID.Focus();
            }
            else
            {
                string qtp = "delete";
                string val = "where oid = '" + OrderID.Text + "'";
                string tbnm = "Orders";
                query.crud(qtp,tbnm,val);
                MessageBox.Show("Order Delete Successfully ...!!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrderID.Clear();
                loaddata();
            }
        }

        private void OrderDelete_Load(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
