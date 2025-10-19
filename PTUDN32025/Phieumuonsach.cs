using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTUDN32025 // Namespace từ file designer của bạn
{
    public partial class FrmMuonSach : Form
    {
        // Lấy chuỗi kết nối từ file App.config
        private string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

        public FrmMuonSach()
        {
            InitializeComponent();
        }

        private void FrmMuonSach_Load(object sender, EventArgs e)
        {
            // Gán sự kiện CellEndEdit cho dataGridView1 một cách tự động
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);

            // Gán sự kiện Leave cho textbox mã độc giả để tự động điền thông tin
            this.txtMaDG.Leave += new System.EventHandler(this.txtMaDG_Leave);

        }

        /// <summary>
        /// Sự kiện xảy ra khi người dùng nhập xong Mã Độc Giả và di chuyển sang control khác.
        /// Tự động tải thông tin của độc giả lên các TextBox.
        /// </summary>
        private void txtMaDG_Leave(object sender, EventArgs e)
        {
            string maDocGia = txtMaDG.Text;
            if (string.IsNullOrWhiteSpace(maDocGia))
            {
                // Nếu mã độc giả trống thì xóa các trường thông tin
                txtHoTen.Clear();
                txtEmail.Clear();
                txtSDT.Clear();
                textBox5.Clear(); // TextBox cho ngày hết hạn
                return;
            }
            LoadReaderInfo(maDocGia);
        }
        private void txtMaDG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadReaderInfo(txtMaDG.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// Sự kiện xảy ra khi người dùng kết thúc chỉnh sửa một ô trong DataGridView.
        /// </summary>
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Chỉ thực hiện khi chỉnh sửa cột "Tên Sách" (cột có chỉ số là 1)
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                string tenSach = cellValue?.ToString();

                if (!string.IsNullOrWhiteSpace(tenSach))
                {
                    string maDocGia = txtMaDG.Text;
                    if (string.IsNullOrWhiteSpace(maDocGia))
                    {
                        MessageBox.Show("Vui lòng nhập Mã độc giả trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value = null; // Xóa tên sách vừa nhập
                        return;
                    }
                    FindAndFillBookInfo(tenSach, maDocGia, e.RowIndex);
                }
            }
        }

        /// <summary>
        /// Tìm sách trong DB và điền thông tin vào hàng của DataGridView.
        /// </summary>
        private void FindAndFillBookInfo(string bookTitle, string readerId, int rowIndex)
        {
            string query = @"
                SELECT TOP 1
                    s.MaSach,
                    (SELECT STRING_AGG(tg.TenTacGia, ', ')
                     FROM DAUSACH_TACGIA dstg JOIN TACGIA tg ON dstg.MaTacGia = tg.MaTacGia
                     WHERE dstg.MaDauSach = ds.MaDauSach) AS TacGia,
                    tt.TenTinhTrang
                FROM DAUSACH ds
                JOIN SACH s ON ds.MaDauSach = s.MaDauSach
                JOIN TINHTRANG tt ON s.MaTinhTrang = tt.MaTinhTrang
                WHERE ds.TenDauSach LIKE @TenSach AND tt.TenTinhTrang = N'Sẵn sàng'
                ORDER BY s.NgayNhap DESC;";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TenSach", $"%{bookTitle}%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string maSach = reader["MaSach"].ToString();
                                string tacGia = reader["TacGia"].ToString();
                                string tinhTrang = reader["TenTinhTrang"].ToString();

                                reader.Close(); // Đóng reader trước khi thực hiện truy vấn mới

                                int thoiHanMuon = GetLoanPeriodForReader(readerId, con);
                                if (thoiHanMuon == -1)
                                {
                                    MessageBox.Show("Không tìm thấy thông tin độc giả hoặc loại độc giả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                DateTime ngayMuon = DateTime.Today;
                                DateTime ngayHenTra = ngayMuon.AddDays(thoiHanMuon);

                                var currentRow = dataGridView1.Rows[rowIndex];
                                // Điền dữ liệu theo chỉ số cột
                                currentRow.Cells[0].Value = maSach;       // Cột "Mã sách"
                                currentRow.Cells[2].Value = tacGia;       // Cột "Tác giả"
                                currentRow.Cells[4].Value = ngayMuon.ToString("dd/MM/yyyy"); // Cột "Ngày mượn"
                                currentRow.Cells[5].Value = ngayHenTra.ToString("dd/MM/yyyy");// Cột "Ngày hẹn trả"
                                currentRow.Cells[6].Value = tinhTrang;    // Cột "Tình trạng"
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy sách có tên này hoặc sách đã được cho mượn.", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearRow(rowIndex);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn dữ liệu sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Lấy thông tin độc giả từ DB và hiển thị lên các TextBox.
        /// </summary>
        private void LoadReaderInfo(string readerId)
        {
            string query = "SELECT HoTen, Email, SDT, NgayHetHan FROM DOCGIA WHERE MaDocGia = @MaDocGia";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaDocGia", readerId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtHoTen.Text = reader["HoTen"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtSDT.Text = reader["SDT"].ToString();
                                textBox5.Text = Convert.ToDateTime(reader["NgayHetHan"]).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy độc giả với mã này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtHoTen.Clear();
                                txtEmail.Clear();
                                txtSDT.Clear();
                                textBox5.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin độc giả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Lấy số ngày được phép mượn sách của một độc giả.
        /// </summary>
        private int GetLoanPeriodForReader(string readerId, SqlConnection connection)
        {
            string query = @"
                SELECT ldg.ThoiHanMuon 
                FROM DOCGIA dg JOIN LOAIDOCGIA ldg ON dg.MaLoaiDocGia = ldg.MaLoaiDocGia
                WHERE dg.MaDocGia = @MaDocGia";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@MaDocGia", readerId);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            return -1; // Trả về -1 nếu không tìm thấy
        }

        /// <summary>
        /// Xóa nội dung trên một hàng.
        /// </summary>
        private void ClearRow(int rowIndex)
        {
            var currentRow = dataGridView1.Rows[rowIndex];
            for (int i = 0; i < currentRow.Cells.Count; i++)
            {
                currentRow.Cells[i].Value = null;
            }
        }
    }
}