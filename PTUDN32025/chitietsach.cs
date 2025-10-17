using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PTUDN32025
{
    public partial class chitietsach : Form
    {
        private string maDauSach; // Mã Đầu Sách (001, 002...)

        // Lưu bản gốc để Undo
        private string originalTenSach;
        private string originalTheLoai;
        private string originalNXB;
        private int originalSoLuong;
        private int originalNamXB;
        private string originalAnhBia;

        // * SỬA: Thay đổi kiểu tham số maSach thành string (maDauSach)
        // * SỬA: Thay đổi soLuong và anhBia thành kiểu an toàn (int và string)
        public chitietsach(string maDauSach, string tenSach, string theLoai, string nxb, int namXB, int soLuong, string anhBia)
        {
            InitializeComponent();

            // Gán vào biến toàn cục
            this.maDauSach = maDauSach;
            this.originalTenSach = tenSach ?? string.Empty;
            this.originalTheLoai = theLoai ?? string.Empty;
            this.originalNXB = nxb ?? string.Empty;
            this.originalNamXB = namXB;
            this.originalSoLuong = soLuong;
            this.originalAnhBia = anhBia;

            // Hiển thị dữ liệu lên form
            txtTenSach.Text = originalTenSach;
            txtTheLoai.Text = originalTheLoai;
            txtnxb.Text = originalNXB;
            txtsoluong.Text = originalSoLuong.ToString();

            // Setup DateTimePicker chỉ hiển thị năm
            dtpnamxb.Format = DateTimePickerFormat.Custom;
            dtpnamxb.CustomFormat = "yyyy";
            dtpnamxb.ShowUpDown = true;

            try
            {
                dtpnamxb.Value = new DateTime(originalNamXB, 1, 1);
            }
            catch
            {
                dtpnamxb.Value = DateTime.Now;
            }

            if (!string.IsNullOrEmpty(originalAnhBia) && File.Exists(originalAnhBia))
            {
                try
                {
                    // Đọc ảnh một cách an toàn để tránh lỗi file lock
                    using (var stream = new FileStream(originalAnhBia, FileMode.Open, FileAccess.Read))
                    {
                        pbAnhBia.Image = Image.FromStream(stream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi tải ảnh: {ex.Message}");
                    pbAnhBia.Image = null;
                }
            }
            else
            {
                pbAnhBia.Image = null;
            }
        }

        private void chitietsach_Load(object sender, EventArgs e)
        {
            // Tải danh sách tác giả khi Form chi tiết mở ra
            LoadTacGia();
        }

        // --- PHƯƠNG THỨC MỚI: TẢI DANH SÁCH TÁC GIẢ THEO MA_DAUSACH ---
        private void LoadTacGia()
        {
            // Đảm bảo Form chi tiết sách có DataGridView tên là dgvTacGia
            if (dgvTacGia == null) return;

            string connectionString = "data source=.\\SQLEXPRESS;database=QuanLyThuVien;integrated security=True";
            string sql = @"
                SELECT 
                    TG.TenTacGia,
                    TG.NamSinh
                FROM TACGIA TG
                INNER JOIN DAUSACH_TACGIA DSTG ON TG.MaTacGia = DSTG.MaTacGia
                WHERE DSTG.MaDauSach = @MaDauSach";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                // Biến maDauSach được sử dụng ở đây
                cmd.Parameters.AddWithValue("@MaDauSach", maDauSach);

                DataTable dtTacGia = new DataTable();
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtTacGia);

                    // Thiết lập DataGridView
                    dgvTacGia.AutoGenerateColumns = true;
                    dgvTacGia.DataSource = dtTacGia;

                    // Thiết lập Header
                    if (dgvTacGia.Columns.Contains("TenTacGia"))
                        dgvTacGia.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
                    if (dgvTacGia.Columns.Contains("NamSinh"))
                        dgvTacGia.Columns["NamSinh"].HeaderText = "Năm Sinh";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải thông tin tác giả: " + ex.Message);
                }
            }
        }
        // -----------------------------------------------------------------


        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenSach.ReadOnly = false;
            txtnxb.ReadOnly = false;
            txtsoluong.ReadOnly = false;
            dtpnamxb.Enabled = true;

            MessageBox.Show("Bạn có thể sửa thông tin sách.");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtsoluong.Text, out int soLuongMoi) || soLuongMoi < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            int soSachChenThem = soLuongMoi - originalSoLuong;
            string connectionString = "data source=.\\SQLEXPRESS;database=QuanLyThuVien;integrated security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    // 1. Cập nhật thông tin DAUSACH
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.Transaction = tran;
                        cmd.CommandText = @"
                            UPDATE DAUSACH 
                            SET TenDauSach = @TenDauSach,
                                NhaXuatBan = @NXB,
                                NamXuatBan = @NamXB,
                                SoSach = @SoLuongMoi,
                                AnhBia = @AnhBia
                            WHERE MaDauSach = @MaDauSach";

                        cmd.Parameters.AddWithValue("@TenDauSach", txtTenSach.Text);
                        cmd.Parameters.AddWithValue("@NXB", txtnxb.Text);
                        cmd.Parameters.AddWithValue("@NamXB", dtpnamxb.Value.Year);
                        cmd.Parameters.AddWithValue("@SoLuongMoi", soLuongMoi);
                        cmd.Parameters.AddWithValue("@AnhBia", (object)originalAnhBia ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@MaDauSach", maDauSach);

                        cmd.ExecuteNonQuery();
                    }

                    // 2. Xử lý thay đổi số lượng sách con (SACH)
                    if (soSachChenThem > 0)
                    {
                        // THÊM SÁCH MỚI (Sử dụng Stored Procedure)
                        string sqlSP = "EXEC sp_ThemSachTheoSoLuong @MaDauSach, @SoLuong";
                        using (SqlCommand cmdSP = new SqlCommand(sqlSP, con, tran))
                        {
                            cmdSP.Parameters.AddWithValue("@MaDauSach", maDauSach);
                            cmdSP.Parameters.AddWithValue("@SoLuong", soSachChenThem);
                            cmdSP.ExecuteNonQuery();
                        }
                    }
                    else if (soSachChenThem < 0)
                    {
                        // XÓA SÁCH CŨ NHẤT THEO THỨ TỰ NGƯỢC
                        int soSachCanXoa = Math.Abs(soSachChenThem);

                        // Lấy danh sách MaSach để xóa (sách có mã lớn nhất và chưa được mượn/đã bị hỏng)
                        // Giả định: Xóa các sách có MaSach lớn nhất (mới nhất) và không có trong bảng CTPHIEUMUON
                        string sqlDelete = @"
                            DELETE TOP (@SoLuongXoa) FROM SACH
                            WHERE MaDauSach = @MaDauSach
                            AND MaSach NOT IN (SELECT MaSach FROM CTPHIEUMUON) -- Không được xóa sách đang được mượn
                            ORDER BY MaSach DESC";

                        using (SqlCommand cmdDelete = new SqlCommand(sqlDelete, con, tran))
                        {
                            cmdDelete.Parameters.AddWithValue("@SoLuongXoa", soSachCanXoa);
                            cmdDelete.Parameters.AddWithValue("@MaDauSach", maDauSach);
                            cmdDelete.ExecuteNonQuery();
                        }
                    }

                    // 3. Commit giao dịch nếu tất cả thành công
                    tran.Commit();
                    MessageBox.Show("Cập nhật và điều chỉnh số lượng sách thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Rollback nếu có bất kỳ lỗi nào xảy ra
                    tran.Rollback();
                    MessageBox.Show("Lỗi cập nhật số lượng sách: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa đầu sách này và tất cả sách con không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string connectionString = "data source=.\\SQLEXPRESS;database=QuanLyThuVien;integrated security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction tran = con.BeginTransaction();
                    try
                    {
                        // THỨ TỰ XÓA ĐÚNG: Xóa khỏi bảng liên kết trước khi xóa chính.

                        // 1. Xóa liên kết tác giả (FK_DAUSACH_TACGIA_DAUSACH)
                        using (SqlCommand cmdTacGia = new SqlCommand("DELETE FROM DAUSACH_TACGIA WHERE MaDauSach = @MaDauSach", con, tran))
                        {
                            cmdTacGia.Parameters.AddWithValue("@MaDauSach", maDauSach);
                            cmdTacGia.ExecuteNonQuery();
                        }

                        // 2. Xóa sách con trong bảng SACH (FK_SACH_DAUSACH)
                        // LƯU Ý: Nếu SACH được tham chiếu bởi CTPHIEUMUON (Chi tiết phiếu mượn), 
                        // phải xóa CTPHIEUMUON trước.

                        // Xóa các chi tiết phiếu mượn tham chiếu đến các sách con
                        // Giả định: Bạn đã có MaPhieuMS tương ứng, nhưng vì bạn chỉ có MaSach, 
                        // ta cần xóa trực tiếp sách con nếu chúng không nằm trong phiếu mượn đang active.
                        // Nếu cần phải xóa cả CTPHIEUMUON thì cần logic phức tạp hơn.
                        // Ta chỉ xóa các sách không nằm trong CTPHIEUMUON để đơn giản hóa.

                        using (SqlCommand cmdSach = new SqlCommand("DELETE FROM SACH WHERE MaDauSach = @MaDauSach AND MaSach NOT IN (SELECT MaSach FROM CTPHIEUMUON)", con, tran))
                        {
                            cmdSach.Parameters.AddWithValue("@MaDauSach", maDauSach);
                            cmdSach.ExecuteNonQuery();
                        }

                        // Nếu vẫn còn sách bị khóa bởi CTPHIEUMUON, việc DELETE ở bước 3 sẽ báo lỗi.
                        // Bạn cần xử lý trường hợp này, nhưng ở đây ta chỉ xóa sách không mượn.

                        // 3. Xóa đầu sách
                        using (SqlCommand cmdDauSach = new SqlCommand("DELETE FROM DAUSACH WHERE MaDauSach = @MaDauSach", con, tran))
                        {
                            cmdDauSach.Parameters.AddWithValue("@MaDauSach", maDauSach);
                            cmdDauSach.ExecuteNonQuery();
                        }

                        tran.Commit();
                        MessageBox.Show("Xóa đầu sách thành công!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Lỗi xóa sách: " + ex.Message);
                    }
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // Code cho btnUndo_Click (Hoàn tác)
            // ... giữ nguyên ...
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
