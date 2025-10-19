using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace PTUDN32025
{
    public partial class frmChiTietSach : Form
    {
        private string MaSach; // Thuộc tính lưu lại mã sách 
        private string MaDocGia;
        public frmChiTietSach(string maSach, string maDocGia, string tenSach, string tacGia, string theLoai, int namXB, string nhaXB, Image anhBia, int SoLuong)
        {
            try
            {
                InitializeComponent();
                this.MaSach = maSach;
                this.MaDocGia = maDocGia;
                lblTheLoai.Text = theLoai;
                lblTenSach.Text = tenSach;
                lblTacGia.Text = tacGia;
                lblNamXuatBan.Text = namXB.ToString();
                lblNhaXuatBan.Text = nhaXB;
                lblTinhTrangSach.Text = SoLuong.ToString();

                if (anhBia != null)
                {
                    picAnhBia.Image = anhBia;
                    picAnhBia.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị chi tiết sách: " + ex.Message);
            }
        }
        private void btnMuonSach_Click(object sender, EventArgs e) //Xử lý mượn sách 
        {
            try
            {
                DBHelper db = new DBHelper();

                using (SqlConnection conn = db.Getconnection())
                {
                    conn.Open();
                    string maDocGia = Session.MaDocGia;
                    string maSach = this.MaSach;
                    if (string.IsNullOrWhiteSpace(maDocGia) || string.IsNullOrWhiteSpace(maSach))
                    {
                        MessageBox.Show("Mã độc giả hoặc mã sách không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(maSach))
                    {
                        MessageBox.Show("Không xác định mã sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var service = new PTUDN32025.Services.MuonSachService(@"Data Source=.\SQLExpress;Initial Catalog=QuanLyThuVien;Integrated Security=True; TrustServerCertificate=True");
                    var confirm = MessageBox.Show($"Bạn có chắc chắn muốn mượn sách {maSach} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm != DialogResult.Yes)
                    {
                        return; // Người dùng hủy bỏ
                    }
                    var res = service.MuonSach(maDocGia, maSach);
                    if (res.Success)
                    {
                        MessageBox.Show(res.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Đóng form sau khi mượn thành công
                    }
                    else
                    {
                        MessageBox.Show(res.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mượn sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LayMaDocGia(string tenDangNhap)
        {
            DBHelper db = new DBHelper();
            using (SqlConnection conn = db.Getconnection())
            {
                conn.Open();
                string query = "SELECT MaDocGia FROM DOCGIA WHERE TenDangNhap = @TenDangNhap";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        this.MaDocGia = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy độc giả với tên đăng nhập đã cho.");
                    }
                }
            }
        }
        private void btnThoatChiTietSach_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietSach_Load(object sender, EventArgs e)
        {
            KiemTraTinhTrangSach();
        }
        private void KiemTraTinhTrangSach()
        {
            try
            {
                DBHelper db = new DBHelper();
                using (SqlConnection conn = db.Getconnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM CTPHIEUMUON WHERE MaSach = @MaSach AND TinhTrangMuon = N'Đang mượn'";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra tình trạng sách: " + ex.Message);
            }
        }
        private void lblTinhTrangSach_Click(object sender, EventArgs e)
        {

        }
        private void KiemTraTinhTrang()
        {
            try
            {
                DBHelper db = new DBHelper();
                using (SqlConnection conn = db.Getconnection())
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM CTPHIEUMUON WHERE MaSach = @MaSach AND TinhTrangMuon = N'Đang mượn'";
                    using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", this.MaSach);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            lblTinhTrangSach.Text = "Tình trạng: Đang được mượn";
                            lblTinhTrangSach.ForeColor = Color.Red;
                            btnMuonSach.Enabled = false;
                        }
                        else
                        {
                            lblTinhTrangSach.Text = "Tình trạng: Sẵn sàng cho mượn";
                            lblTinhTrangSach.ForeColor = Color.Green;
                            btnMuonSach.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra tình trạng sách: " + ex.Message);
            }
        }

        private void lblNhaXuatBan_Click(object sender, EventArgs e)
        {

        }
    }
}
