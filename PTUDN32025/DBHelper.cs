using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; 

namespace PTUDN32025
{
    internal class DBHelper
    {
        private string connectionString = @"Data Source=.\SQLExpress;Initial Catalog=QuanLyThuVien;Integrated Security=True; TrustServerCertificate=True";
        public SqlConnection Getconnection() => new SqlConnection(connectionString); 
        private SqlCommand CreateCommand (string query, SqlConnection sqlCon, SqlParameter[] para = null)
        {
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            if (para != null && para.Length >0)
            {
                cmd.Parameters.AddRange(para);
            }
            return cmd;
        }
        public DataTable ExecuteQuery(string query, SqlParameter[] para = null)
        {
            using (var con = Getconnection())
            using (var cmd = CreateCommand(query, con, para))

            using (var adt = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            } 
        }
//Những câu lệnh không phải truy vấn select (
        public int ExecuteNonQuery(string query, SqlParameter[] para = null)
        {
            using (var con = Getconnection())
            using (var cmd = CreateCommand(query, con, para))
            {
                con.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        //Trả về 1 giá trị đơn 
        public object ExecuteScalar(string query, SqlParameter[] para = null)
        {
            using (var con = Getconnection())
            using (var cmd= CreateCommand(query, con, para))
            {
                con.Open(); return cmd.ExecuteScalar();
            }    
        }
    }

}
