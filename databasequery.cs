using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SMS
{
    class databasequery
    {
        public SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\SMS.mdf;Integrated Security=True");
        public  DataTable dt = new DataTable();
        public  void crud(string qtype, string tbnm, string val)
        {
            string sql = "";
            dt.Clear();
            if (qtype == "insert")
            {
                sql = "insert into " + tbnm + " values ( '" + val + "')";
            }
            else if (qtype == "delete")
            {
                sql = "delete from " + tbnm + " " + val;
                //MessageBox.Show(sql);
            }
            else if (qtype == "update")
            {
                sql = "update " + tbnm + " set " + val;
                //MessageBox.Show(sql);
            }

            else if (qtype == "select")
            {
                sql = "select * from " + tbnm + " " + val;
            }
            else if(qtype == "query")
            {
                sql = val;
            }
            //MessageBox.Show(sql);
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(dt);
        }
    }
}