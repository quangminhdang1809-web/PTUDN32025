using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTUDN32025.Services
{
    public class MuonSachResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string MaPhieuMuon { get; set; } 
    }
    public class MuonSachService
    {
        private readonly string _connectionString;
        public MuonSachService(string connectionString)
        {
            _connectionString = connectionString;
        }
        public MuonSachResult MuonSach(string maDocGia, string maSach)
        {
            var result = new MuonSachResult(); 
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand("usp_MuonSach", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                cmd.Parameters.AddWithValue("@MaSach", maSach);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    result.Success = true;
                    result.Message = "Mượn sách thành công";
                    return result;
                }
                catch (SqlException ex)
                {
                    result.Success = false;
                    string sqlMsg = ex.Message;
                    if (!string.IsNullOrWhiteSpace(sqlMsg))
                    {
                        result.Message = sqlMsg;
                    }
                    else
                    {
                        result.Message = "Lỗi khi mượn sách";
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    result.Success = false;
                    result.Message = "Lỗi khi mượn sách: " + ex.Message;
                    return result;
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}
