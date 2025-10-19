using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; // SỬA 1: Thêm using cần thiết

namespace PTUDN32025
{
    public partial class chitietdocgia : Form
    {
        // SỬA 2: Khai báo một chuỗi kết nối duy nhất cho toàn bộ Form
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

        // Lưu bản gốc để Undo
        private string originalMaDocGia;
        private string originalTenDocGia;
        private DateTime originalNgaysinh;
        private string originalDiaChi;
        private string originalEmail;
        private DateTime originalNgayLapThe;
        private DateTime originalNgayHetHan;
        private string originalLoaiDocGia;
        private string originalIDAccount;
        private string originalSoDienThoai;

        public chitietdocgia(string maDocGia, string tenDocGia, DateTime ngaySinh,
                             string diaChi, string email, DateTime ngayLapThe,
                             DateTime ngayHetHan, string loaiDocGia, string idAccount, string soDienThoai)
        {
            InitializeComponent();

            // Gán vào biến toàn cục
            this.originalMaDocGia = maDocGia;
            this.originalTenDocGia = tenDocGia;
            this.originalNgaysinh = ngaySinh;
            this.originalDiaChi = diaChi;
            this.originalEmail = email;
            this.originalNgayLapThe = ngayLapThe;
            this.originalNgayHetHan = ngayHetHan;
            this.originalLoaiDocGia = loaiDocGia;
            this.originalIDAccount = idAccount;
            this.originalSoDienThoai = soDienThoai;

            // Hiển thị dữ liệu lên form
            txtMaDocGia.Text = maDocGia;
            txtTenDocGia.Text = tenDocGia;
            dtpngaysinh.Value = ngaySinh;
            txtdiachi.Text = diaChi;
            txtemail.Text = email;
            dtpngaylapthe.Value = ngayLapThe;
            dtpngayhethan.Value = ngayHetHan;
            txtsodienthoai.Text = soDienThoai;
            txtidaccount.Text = idAccount;
        }

        private void chitietdocgia_Load(object sender, EventArgs e)
        {
            LoadLoaiDocGia();
            // SỬA 3: Đặt giá trị cho ComboBox sau khi đã tải dữ liệu
            cbxLoaiDocGia.Text = originalLoaiDocGia;

            LoadLichSuMuonTra(originalMaDocGia);
        }

        private void LoadLoaiDocGia()
        {
            // Sử dụng connectionString đã được khai báo ở trên
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT MaLoaiDocGia, TenLoaiDocGia FROM LOAIDOCGIA", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbxLoaiDocGia.DataSource = dt;
                cbxLoaiDocGia.DisplayMember = "TenLoaiDocGia";
                cbxLoaiDocGia.ValueMember = "MaLoaiDocGia";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaDocGia.ReadOnly = true;
            txtTenDocGia.ReadOnly = false;
            dtpngaysinh.Enabled = true;
            txtdiachi.ReadOnly = false;
            txtemail.ReadOnly = false;
            dtpngaylapthe.Enabled = true;
            dtpngayhethan.Enabled = true;
            cbxLoaiDocGia.Enabled = true;
            txtsodienthoai.ReadOnly = false;
            btnLuu.Enabled = true;
            MessageBox.Show("Bạn có thể sửa thông tin độc giả.");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Sử dụng connectionString đã được khai báo ở trên
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                UPDATE DOCGIA SET 
                    HoTen = @HoTen, NgaySinh = @NgaySinh, DiaChi = @DiaChi, Email = @Email,
                    NgayLapThe = @NgayLapThe, NgayHetHan = @NgayHetHan, 
                    MaLoaiDocGia = @MaLoaiDocGia, SDT = @SDT
                WHERE MaDocGia = @MaDocGia", con))
            {
                if (cbxLoaiDocGia.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn loại độc giả!");
                    return;
                }
                cmd.Parameters.AddWithValue("@HoTen", txtTenDocGia.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpngaysinh.Value);
                cmd.Parameters.AddWithValue("@DiaChi", txtdiachi.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                cmd.Parameters.AddWithValue("@NgayLapThe", dtpngaylapthe.Value);
                cmd.Parameters.AddWithValue("@NgayHetHan", dtpngayhethan.Value);
                cmd.Parameters.AddWithValue("@MaLoaiDocGia", cbxLoaiDocGia.SelectedValue);
                cmd.Parameters.AddWithValue("@SDT", txtsodienthoai.Text);
                cmd.Parameters.AddWithValue("@MaDocGia", originalMaDocGia);

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("✅ Cập nhật thông tin độc giả thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("⚠️ Cập nhật thất bại. Hãy kiểm tra dữ liệu.");
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // Khôi phục lại dữ liệu gốc
            txtMaDocGia.Text = originalMaDocGia;
            txtTenDocGia.Text = originalTenDocGia;
            dtpngaysinh.Value = originalNgaysinh;
            txtdiachi.Text = originalDiaChi;
            txtemail.Text = originalEmail;
            dtpngaylapthe.Value = originalNgayLapThe;
            dtpngayhethan.Value = originalNgayHetHan;
            cbxLoaiDocGia.Text = originalLoaiDocGia;
            txtsodienthoai.Text = originalSoDienThoai;
            txtidaccount.Text = originalIDAccount;

            // Đặt lại trạng thái ban đầu
            txtTenDocGia.ReadOnly = true;
            dtpngaysinh.Enabled = false;
            txtdiachi.ReadOnly = true;
            txtemail.ReadOnly = true;
            dtpngaylapthe.Enabled = false;
            dtpngayhethan.Enabled = false;
            cbxLoaiDocGia.Enabled = false;
            txtsodienthoai.ReadOnly = true;
            btnLuu.Enabled = false;
            txtidaccount.Enabled = false;
            MessageBox.Show("Đã hủy các thay đổi.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa độc giả này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Sử dụng connectionString đã được khai báo ở trên
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM DOCGIA WHERE MaDocGia = @MaDocGia", con))
                {
                    cmd.Parameters.AddWithValue("@MaDocGia", originalMaDocGia);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("✅ Xóa độc giả thành công!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("⚠️ Xóa thất bại. Có thể do độc giả đang mượn sách.");
                    }
                }
            }
        }

        private void LoadLichSuMuonTra(string maDocGia)
        {
            // Sử dụng connectionString đã được khai báo ở trên
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        DS.TenDauSach AS [Tên sách],
                        PMS.NgayMuon AS [Ngày mượn],
                        CTPM.HanTra AS [Hạn trả],
                        PTS.NgayTra AS [Ngày trả],
                        CTPM.TinhTrangMuon AS [Tình trạng]
                    FROM DOCGIA DG
                    INNER JOIN PHIEUMUONSACH PMS ON DG.MaDocGia = PMS.MaDocGia
                    INNER JOIN CTPHIEUMUON CTPM ON PMS.MaPhieuMS = CTPM.MaPhieuMS
                    LEFT JOIN PHIEUTRASACH PTS ON CTPM.MaPhieuMS = PTS.MaPhieuMS AND CTPM.MaSach = PTS.MaSach
                    INNER JOIN SACH S ON CTPM.MaSach = S.MaSach
                    INNER JOIN DAUSACH DS ON S.MaDauSach = DS.MaDauSach
                    WHERE DG.MaDocGia = @MaDocGia
                    ORDER BY PMS.NgayMuon DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLichSuMuonTra.DataSource = dt;
                }
            }
        }

        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {
            // Không cần code ở đây
        }
    }
}