using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PTUDN32025
{
    /// <summary>
    /// Đại diện cho biểu mẫu thêm sách mới.
    /// Phiên bản tái cấu trúc này cải tiến so với bản gốc bằng cách tập trung chuỗi kết nối,
    /// tách logic thành các phương thức nhỏ hơn, mạnh mẽ hơn và phù hợp với lược đồ cơ sở dữ liệu cuối cùng.
    /// </summary>
    public partial class themsach : Form
    {
        // Lưu chuỗi kết nối ở một nơi để tránh lặp lại và dễ dàng thay đổi.
        private readonly string _connectionString = "data source=.\\SQLEXPRESS;database=QuanLyThuVien;integrated security=True";
        private string _selectedImagePath = "";

        // LƯU Ý: Các điều khiển (controls) như txttensach, dgvtacgia, etc.
        // được giả định là đã được tạo trong file .Designer.cs và có modifier là public hoặc internal.
        // Chúng ta không cần khai báo lại chúng ở đây.

        public themsach()
        {
            InitializeComponent();
        }

        private void ucthemsach_Load(object sender, EventArgs e)
        {
            LoadBookCategories();
        }

        /// <summary>
        /// Tải danh mục thể loại sách từ cơ sở dữ liệu và điền vào ComboBox.
        /// </summary>
        private void LoadBookCategories()
        {
            try
            {
                using (var con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    const string query = "SELECT MaTheLoai, TenTheLoai FROM THELOAI";
                    var da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);

                    cbxtheloai.DataSource = dt;
                    cbxtheloai.DisplayMember = "TenTheLoai";
                    cbxtheloai.ValueMember = "MaTheLoai";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tải danh mục thể loại sách thất bại. Lỗi: " + ex.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xử lý logic chính để lưu sách mới và tất cả dữ liệu liên quan.
        /// </summary>
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string tenSach, out string nxb, out int soLuong, out int namXB, out string maTheLoai))
            {
                return; // Dừng lại nếu xác thực thất bại
            }

            using (var con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Bước 1 & 2: Chèn bản ghi đầu sách chính (DAUSACH) và lấy ID mới của nó
                    string maDauSachMoi = InsertDauSachAndGetId(con, transaction, tenSach, maTheLoai, namXB, nxb, soLuong);

                    // Bước 3: Xử lý tất cả tác giả và liên kết họ với sách mới
                    ProcessAuthors(con, transaction, maDauSachMoi);

                    // Bước 4: Gọi stored procedure để tạo các bản sao sách riêng lẻ (SACH)
                    CreateSachCopies(con, transaction, maDauSachMoi, soLuong);

                    transaction.Commit();
                    MessageBox.Show($"Thêm thành công đầu sách '{maDauSachMoi}' với {soLuong} bản sao.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK; // Báo hiệu thành công cho form cha
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Chèn một bản ghi mới vào DAUSACH và lấy ID được tạo bởi trigger.
        /// </summary>
        private string InsertDauSachAndGetId(SqlConnection con, SqlTransaction tran, string tenSach, string maTheLoai, int namXB, string nxb, int soLuong)
        {
            // Chèn với một ID giữ chỗ tạm thời ('TEMP'). Trigger sẽ thay thế nó.
            const string insertQuery = @"
                INSERT INTO DAUSACH (MaDauSach, TenDauSach, MaTheLoai, NamXuatBan, NhaXuatBan, SoSach, AnhBia) 
                VALUES (@MaDauSach, @TenDauSach, @MaTheLoai, @NamXuatBan, @NhaXuatBan, @SoSach, @AnhBia);";

            using (var cmd = new SqlCommand(insertQuery, con, tran))
            {
                cmd.Parameters.AddWithValue("@MaDauSach", "TEMP");
                cmd.Parameters.AddWithValue("@TenDauSach", tenSach);
                cmd.Parameters.AddWithValue("@MaTheLoai", maTheLoai);
                cmd.Parameters.AddWithValue("@NamXuatBan", namXB);
                cmd.Parameters.AddWithValue("@NhaXuatBan", nxb);
                cmd.Parameters.AddWithValue("@SoSach", soLuong);
                cmd.Parameters.AddWithValue("@AnhBia", string.IsNullOrEmpty(_selectedImagePath) ? (object)DBNull.Value : _selectedImagePath);
                cmd.ExecuteNonQuery();
            }

            // Lấy ID được tạo bởi trigger.
            const string selectIdQuery = @"
                SELECT TOP 1 MaDauSach FROM DAUSACH 
                WHERE TenDauSach = @TenDauSach AND NamXuatBan = @NamXuatBan AND MaDauSach <> 'TEMP' 
                ORDER BY MaDauSach DESC";

            using (var cmdGetId = new SqlCommand(selectIdQuery, con, tran))
            {
                cmdGetId.Parameters.AddWithValue("@TenDauSach", tenSach);
                cmdGetId.Parameters.AddWithValue("@NamXuatBan", namXB);

                object result = cmdGetId.ExecuteScalar();
                if (result == null)
                {
                    throw new Exception("Không thể lấy ID sách mới. Vui lòng kiểm tra trigger 'trg_GenerateMaDauSach_So'.");
                }
                return result.ToString();
            }
        }

        /// <summary>
        /// Xác thực dữ liệu người dùng nhập từ các điều khiển trên form.
        /// </summary>
        private bool ValidateInputs(out string tenSach, out string nxb, out int soLuong, out int namXB, out string maTheLoai)
        {
            tenSach = txttensach.Text.Trim();
            nxb = txtnxb.Text.Trim();
            maTheLoai = cbxtheloai.SelectedValue?.ToString();
            namXB = dtpnamxb.Value.Year;
            soLuong = 0;

            if (string.IsNullOrEmpty(tenSach) || string.IsNullOrEmpty(nxb) || string.IsNullOrEmpty(txtsoluong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường bắt buộc: Tên sách, Nhà xuất bản và Số lượng.", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dgvtacgia.Rows.Count == 0 || (dgvtacgia.Rows.Count == 1 && dgvtacgia.Rows[0].IsNewRow))
            {
                MessageBox.Show("Vui lòng thêm ít nhất một tác giả.", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtsoluong.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải là một số dương hợp lệ.", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(maTheLoai))
            {
                MessageBox.Show("Vui lòng chọn một thể loại sách.", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Xử lý tác giả từ DataGridView, thêm tác giả mới và liên kết họ với sách.
        /// </summary>
        private void ProcessAuthors(SqlConnection con, SqlTransaction tran, string maDauSachMoi)
        {
            foreach (DataGridViewRow row in dgvtacgia.Rows)
            {
                if (row.IsNewRow) continue;

                string tenTacGia = row.Cells[0].Value?.ToString()?.Trim();
                if (string.IsNullOrEmpty(tenTacGia) || !int.TryParse(row.Cells[1].Value?.ToString(), out int namSinh))
                {
                    continue; // Bỏ qua các hàng không hợp lệ
                }

                int maTacGia = GetOrInsertAuthor(con, tran, tenTacGia, namSinh);
                LinkAuthorToBook(con, tran, maDauSachMoi, maTacGia);
            }
        }

        /// <summary>
        /// Kiểm tra xem một tác giả đã tồn tại chưa. Nếu chưa, chèn họ vào và trả về ID mới.
        /// </summary>
        private int GetOrInsertAuthor(SqlConnection con, SqlTransaction tran, string tenTacGia, int namSinh)
        {
            // Kiểm tra xem tác giả đã tồn tại chưa
            const string checkQuery = "SELECT MaTacGia FROM TACGIA WHERE TenTacGia = @TenTacGia AND NamSinh = @NamSinh";
            using (var cmdCheck = new SqlCommand(checkQuery, con, tran))
            {
                cmdCheck.Parameters.AddWithValue("@TenTacGia", tenTacGia);
                cmdCheck.Parameters.AddWithValue("@NamSinh", namSinh);
                object result = cmdCheck.ExecuteScalar();
                if (result != null)
                {
                    return (int)result;
                }
            }

            // Nếu chưa, chèn tác giả mới và lấy ID của họ
            const string insertQuery = "INSERT INTO TACGIA (TenTacGia, NamSinh) OUTPUT INSERTED.MaTacGia VALUES (@TenTacGia, @NamSinh)";
            using (var cmdInsert = new SqlCommand(insertQuery, con, tran))
            {
                cmdInsert.Parameters.AddWithValue("@TenTacGia", tenTacGia);
                cmdInsert.Parameters.AddWithValue("@NamSinh", namSinh);
                return (int)cmdInsert.ExecuteScalar();
            }
        }

        /// <summary>
        /// Tạo một liên kết giữa sách và tác giả trong bảng DAUSACH_TACGIA.
        /// </summary>
        private void LinkAuthorToBook(SqlConnection con, SqlTransaction tran, string maDauSach, int maTacGia)
        {
            const string linkQuery = "INSERT INTO DAUSACH_TACGIA (MaDauSach, MaTacGia) VALUES (@MaDauSach, @MaTacGia)";
            using (var cmdLink = new SqlCommand(linkQuery, con, tran))
            {
                cmdLink.Parameters.AddWithValue("@MaDauSach", maDauSach);
                cmdLink.Parameters.AddWithValue("@MaTacGia", maTacGia);
                cmdLink.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Thực thi stored procedure để tạo các bản sao sách riêng lẻ.
        /// </summary>
        private void CreateSachCopies(SqlConnection con, SqlTransaction tran, string maDauSach, int soLuong)
        {
            using (var cmdSP = new SqlCommand("sp_ThemSachTheoSoLuong", con, tran))
            {
                cmdSP.CommandType = CommandType.StoredProcedure;
                cmdSP.Parameters.AddWithValue("@MaDauSach", maDauSach);
                cmdSP.Parameters.AddWithValue("@SoLuong", soLuong);
                cmdSP.ExecuteNonQuery();
            }
        }

        private void btnthemanh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Tệp hình ảnh|*.jpg;*.jpeg;*.png;*.bmp",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _selectedImagePath = ofd.FileName;
                        using (var stream = new FileStream(_selectedImagePath, FileMode.Open, FileAccess.Read))
                        {
                            // Giả sử PictureBox của bạn có tên là pbthemanh trong designer
                            pbthemanh.Image = Image.FromStream(stream);
                        }
                    }
                    catch (Exception ex)
                    {
                        _selectedImagePath = "";
                        MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi hình ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnthemtacgia_Click(object sender, EventArgs e)
        {
            string tenTacGia = txttacgia.Text.Trim();
            int namSinh = dtpnamsinhtacgia.Value.Year;

            if (string.IsNullOrEmpty(tenTacGia))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả.", "Yêu cầu nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvtacgia.Rows.Add(tenTacGia, namSinh);

            // Đặt lại các trường nhập tác giả
            txttacgia.Clear();
            dtpnamsinhtacgia.Value = DateTime.Now;
        }

        private void btnxoatacgia_Click(object sender, EventArgs e)
        {
            if (dgvtacgia.SelectedRows.Count > 0 && !dgvtacgia.SelectedRows[0].IsNewRow)
            {
                dgvtacgia.Rows.Remove(dgvtacgia.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tác giả để xóa.", "Yêu cầu lựa chọn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

