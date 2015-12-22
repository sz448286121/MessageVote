using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace vote
{
    public class DataBase
    {
        SqlConnection conn;
        public DataBase(string str)
        {
            this.conn = new SqlConnection(str);
        }
        public void open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable query_dt(string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable dt=new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataSet query_ds(string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        public int update(string sql)
        {
            open();
            SqlCommand sc = new SqlCommand();
            sc.CommandText = sql;
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            int x = sc.ExecuteNonQuery();
            close();
            return x;
        }
    }
}
