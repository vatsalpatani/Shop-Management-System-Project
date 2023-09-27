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
    public partial class Login : Form
    {
        databasequery query = new databasequery();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void cleardata()
        {
            userName.Text = password.Text = string.Empty;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {                                          
            if (userName.Text == "" || this.password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userName.Focus();
                return;
             }

            string qtype = "select";
            string tbnm = "login";
            string val = " where unm = '"+ userName.Text +"' and pwd = '" + password.Text + "'";
            query.crud(qtype, tbnm, val);
            if (query.dt.Rows.Count > 0)
            {
                string unm = query.dt.Rows[0][0].ToString();
                string pwd = query.dt.Rows[0][1].ToString();
                if (userName.Text == unm && password.Text == pwd)
                {
                    MessageBox.Show("login successfull ...!!!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu hm = new Menu();
                    this.Hide();
                    hm.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cleardata();
                userName.Focus();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cleardata();
        }
    }
}
