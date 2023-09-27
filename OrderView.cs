using DGVPrinterHelper;
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
    public partial class OrderView : Form
    {
        databasequery query = new databasequery();
        public OrderView()
        {
            InitializeComponent();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinter();
            printer.Title = "Order View ";//Header
            printer.TitleSpacing = 15;
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleSpacing = 15;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Shop Management System";//Footer
            printer.FooterSpacing = 15;
            //Print landscape mode
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(ViewData);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if(orderID.Text == "")
            {
                MessageBox.Show("Please Enter Order Id", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                orderID.Focus();
            }
            else
            {
                string qtp = "select";
                string sql = "where oid = '" + orderID.Text + "'";
                string tbnm = "order_view";
                query.crud(qtp , tbnm , sql);
                ViewData.ReadOnly = true;
                ViewData.DataSource = query.dt;
            }
        }
    }
}
