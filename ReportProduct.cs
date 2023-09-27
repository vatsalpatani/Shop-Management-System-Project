using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SMS
{
    public partial class ReportProduct : Form
    {
        databasequery query = new databasequery();
        public ReportProduct()
        {
            InitializeComponent();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Products Report";
            printer.TitleSpacing = 20;
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleSpacing = 20;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip ;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Shop Management System";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = false;
            printer.PrintDataGridView(dataGridView1);           
        }

        private void ReportProduct_Load(object sender, EventArgs e)
        {
            string qtp = "select";
            string tbnm = "product_view";
            string val = "";
            query.crud(qtp,tbnm , val);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = query.dt;
        }
    }
}
