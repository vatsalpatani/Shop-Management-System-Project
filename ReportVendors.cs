using DGVPrinterHelper;
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
    public partial class ReportVendors : Form
    {
        databasequery query = new databasequery();
        public ReportVendors()
        {
            InitializeComponent();
        }

        private void ReportVendors_Load(object sender, EventArgs e)
        {
            string sql = "";
            string tbnm = "Vendors";
            string qtp = "select";
            query.crud(qtp, tbnm, sql);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = query.dt;
        }

        private void print_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinter();
            printer.Title = "Vendor Report";
            printer.TitleSpacing = 15;
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleSpacing = 15;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Shop Management System";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView1);
        }
    }
}
