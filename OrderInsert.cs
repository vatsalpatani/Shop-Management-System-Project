using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class OrderInsert : Form
    {
        databasequery query = new databasequery();
        DataTable transactionDT = new DataTable();
        string cid = "";
        string qtp = "";
        string tbnm = "";
        string val = "";

        public OrderInsert()
        {
            InitializeComponent();
        }

        private void custcleardata()
        {
            Cust_search.Text = custEmail.Text = CustName.Text = PhoneNumber.Text = Cust_address.Text = string.Empty;
        }

        private void prodcleardata()
        {
            Product_search.Text = ProductID.Text = Product_Name.Text = Amount.Text = string.Empty;
        }

        private void allclear()
        {
            Cust_search.Text = custEmail.Text = CustName.Text = PhoneNumber.Text = Cust_address.Text = Product_search.Text = ProductID.Text = Product_Name.Text = Amount.Text = SubTotal.Text = Discount.Text = GST.Text = PaidAmount.Text = ReturnAmount.Text = Quantity.Text = Amount.Text = string.Empty;
            AddedProducts.DataSource = null;
        }

        private void Cust_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = Cust_search.Text;
            if (keyword == null || keyword == "")
            {
                custcleardata();
                return;
            }
            val = "where cid like '%" + keyword + "%' or cname like '%" + keyword + "%'";
            tbnm = "Customers";
            qtp = "select";
            string sql = "select * from Customers where cid like '%" + keyword + "%' or cname like '%" + keyword + "%'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql,query.cn);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                CustName.Text = dt.Rows[0][1].ToString();
                Cust_address.Text = dt.Rows[0][2].ToString();
                PhoneNumber.Text = dt.Rows[0][3].ToString();
                custEmail.Text = dt.Rows[0][4].ToString();
                cid = dt.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("Provided Customer is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                custcleardata();
                Cust_search.Clear();
                Cust_search.Focus();
            }

        }

        private void Product_search_TextChanged(object sender, EventArgs e)//error
        {
            string keyword1 = Product_search.Text;
            if (keyword1 == null || keyword1 == "")
            {
                prodcleardata();
                return;
            }
            val = "where pid like '%" + keyword1 + "%' or pname like '%" + keyword1 + "%'";
            tbnm = "Products";
            qtp = "select";
            string sql = "select * from Products where pid like '%" + keyword1 + "%' or pname like '%" + keyword1 + "%'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, query.cn);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ProductID.Text = dt.Rows[0][0].ToString();
                Product_Name.Text = dt.Rows[0][1].ToString();
                Amount.Text = dt.Rows[0][2].ToString();
                dt.Clear();

            }
            else
            {
                MessageBox.Show("Provided Product is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prodcleardata();
                Product_search.Clear();
                Product_search.Focus();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            String PNAME = Product_Name.Text;
            String PID = ProductID.Text;
            if (Quantity.Text == "" || Product_Name.Text == "" || ProductID.Text == "")
            {
                MessageBox.Show("Enter the Quantity!!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tbnm = "Stocks";
            qtp = "select";
            val = "where pid = '" + ProductID.Text + "' and quantity >= '" + Quantity.Text + "'";
            string sql = "select * from Stocks where pid = '" + ProductID.Text + "' and quantity >= '" + Quantity.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, query.cn);
            da.Fill(dt);
            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("Check stock!!!!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal quantity = decimal.Parse(Quantity.Text);
            decimal amount = decimal.Parse(Amount.Text);
            decimal total = amount * quantity;
            decimal subtotal = decimal.Parse(SubTotal.Text);

            subtotal += total;

            if (PNAME == "")
            {
                MessageBox.Show("select a product and try again", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                transactionDT.Rows.Add(PNAME, PID, quantity, amount, total);
                AddedProducts.DataSource = transactionDT;
                SubTotal.Text = subtotal.ToString();

                if (ProductID.Text == "")
                {
                    MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Product_Name.Clear();
                ProductID.Clear();
                Quantity.Text = "0";
                Amount.Text = "0";

            }

        }

        private void OrderInsert_Load(object sender, EventArgs e)
        {
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Product ID");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Amount");
            transactionDT.Columns.Add("Total");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            qtp = "insert";
            tbnm = "Orders";
            val = cid + "','" + date.Text + "','" + Total_Amt.Text;
            query.crud(qtp, tbnm, val);
            MessageBox.Show("Order Insertion Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string oid = "";
            qtp = "select";
            tbnm = "Orders";
            val = "";
            query.crud(qtp, tbnm, val);
            
            for (int j = 0; j < query.dt.Rows.Count; j++)
            {
                oid = query.dt.Rows[j]["oid"].ToString();//error
                //MessageBox.Show(oid);
            }
            //MessageBox.Show("xx");
            //MessageBox.Show(oid);

            for (int i = 0; i < transactionDT.Rows.Count; i++)
            {
                qtp = "insert";
                tbnm = "Order_details";
                val = oid + "','" + transactionDT.Rows[i]["Product ID"].ToString() + "','" + transactionDT.Rows[i]["Quantity"].ToString();
                query.crud(qtp, tbnm, val);
            }

            for (int i = 0; i < transactionDT.Rows.Count; i++)
            {
                qtp = "update";
                tbnm = "Stocks";
                val = "quantity = quantity - '" + transactionDT.Rows[i]["Quantity"].ToString() + "' where pid = '" + transactionDT.Rows[i]["Product ID"].ToString() + "'";
                query.crud(qtp,tbnm,val);
                
            }

            allclear();
        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            if (SubTotal.Text == "")
            {
                return;
            }
            if (Discount.Text == "")
            {
                MessageBox.Show("Add value of Discount first", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal discount = decimal.Parse(Discount.Text);
                decimal subtotal = decimal.Parse(SubTotal.Text);
                decimal grandTotal = ((100 - discount) / 100) * subtotal;
                Total_Amt.Text = grandTotal.ToString();
            }
        }

        private void GST_TextChanged(object sender, EventArgs e)
        {
            if (Total_Amt.Text == "")
            {
                MessageBox.Show("Calcuate Grand total after discount", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Total_Amt.Text == "" || GST.Text == "")
                {
                    return;
                }
                decimal previousGT = decimal.Parse(Total_Amt.Text);
                decimal gst = decimal.Parse(GST.Text);
                decimal GTwithGst = ((100 + gst) / 100) * previousGT;
                Total_Amt.Text = GTwithGst.ToString();
            }
        }

        private void PaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (PaidAmount.Text == "" || Total_Amt.Text == "")
            {
                return;
            }
            decimal paidamt = decimal.Parse(PaidAmount.Text);
            decimal gtamt = decimal.Parse(Total_Amt.Text);

            if (paidamt < gtamt)
            {
                //MessageBox.Show("Please check the total amount again");
                return;
            }
            decimal retamt = paidamt - gtamt;
            ReturnAmount.Text = retamt.ToString();
        }
    }
}
