using Aspose.Drawing;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class ReportOrder : Form
    {
        databasequery query = new databasequery();
        public ReportOrder()
        {
            InitializeComponent();
        }

        private void ReportOrder_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string qtp = "select";
            string tbnm = "order_view";
            string sql = "WHERE odate BETWEEN '"+ FromDate.Text +"' AND '" + Todate.Text + "'";
            query.crud(qtp,tbnm,sql);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = query.dt;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinter();
            printer.Title = "Order Report";//Header
            printer.TitleSpacing = 15;
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleSpacing = 15;
            printer.SubTitleFormatFlags = System.Drawing.StringFormatFlags.LineLimit | System.Drawing.StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = System.Drawing.StringAlignment.Near;
            printer.Footer = "Shop Management System";//Footer
            printer.FooterSpacing = 15;
            //Print landscape mode
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView1);
        }
    }
}
