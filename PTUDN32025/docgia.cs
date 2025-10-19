using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; // Thêm using này để dùng App.config

namespace PTUDN32025
{
    public partial class ucdocgia : UserControl
    {
        // 1. Thống nhất Connection String: Dùng một chuỗi kết nối duy nhất từ App.config
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;

        private DataTable dtAllDocGia;
        public event EventHandler themdocgiaClicked;

        public ucdocgia()
        {
            InitializeComponent();
        }

        private void ucdocgia_Load(object sender, EventArgs e)
        {
            // Tối ưu: Chỉ cần cài đặt cột một lần khi UserControl được tải
            SetupDataGridview();
            LoadLoaiDocGiaComboBox();
            LoadDatagrid();
        }

        private void SetupDataGridview()
        {
            dgvxemdocgia.AutoGenerateColumns = false;
            dgvxemdocgia.Columns.Clear();

            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaDocGia", DataPropertyName = "MaDocGia", HeaderText = "Mã Độc Giả", Width = 100 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn { Name = "HoTen", DataPropertyName = "HoTen", HeaderText = "Họ Tên", Width = 300 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn { Name = "NgaySinh", DataPropertyName = "NgaySinh", HeaderText = "Ngày Sinh", Width = 100 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn { Name = "DiaChi", DataPropertyName = "DiaChi", HeaderText = "Địa Chỉ", Width = 200 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", DataPropertyName = "Email", HeaderText = "Email", Width = 150 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn { Name = "NgayLapThe", DataPropertyName = "NgayLapThe", HeaderText = "Ngày Lập Thẻ", Width = 100 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn { Name = "NgayHetHan", DataPropertyName = "NgayHetHan", HeaderText = "Ngày Hết Hạn", Width = 100 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenLoaiDocGia", DataPropertyName = "TenLoaiDocGia", HeaderText = "Loại Độc Giả", Width = 200 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn { Name = "SDT", DataPropertyName = "SDT", HeaderText = "Số Điện Thoại", Width = 100 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn { Name = "IDAccount", DataPropertyName = "IDAccount", HeaderText = "ID Tài Khoản", Width = 100, Visible = false }); // Ẩn cột ID Account cho gọn
        }

        private void LoadDatagrid()
        {
            try
            {
                // Sử dụng connectionString đã được khai báo ở trên
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT dg.MaDocGia, dg.HoTen, dg.NgaySinh, dg.DiaChi, dg.Email, 
                               dg.NgayLapThe, dg.NgayHetHan, ldg.TenLoaiDocGia, 
                               dg.SDT, dg.IDAccount
                        FROM DOCGIA dg
                        INNER JOIN LOAIDOCGIA ldg ON dg.MaLoaiDocGia = ldg.MaLoaiDocGia";

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dtAllDocGia = new DataTable();
                    da.Fill(dtAllDocGia);

                    dgvxemdocgia.DataSource = dtAllDocGia;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu độc giả: " + ex.Message);
            }
        }

        private void LoadLoaiDocGiaComboBox()
        {
            try
            {
                // Sử dụng connectionString đã được khai báo ở trên
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT TenLoaiDocGia FROM LOAIDOCGIA", con);
                    DataTable dtLoaiDocGia = new DataTable();
                    da.Fill(dtLoaiDocGia);

                    cbxLoaiDocGia.Items.Clear();
                    cbxLoaiDocGia.Items.Add("Tất cả");
                    foreach (DataRow row in dtLoaiDocGia.Rows)
                    {
                        cbxLoaiDocGia.Items.Add(row["TenLoaiDocGia"].ToString());
                    }
                    cbxLoaiDocGia.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải loại độc giả: " + ex.Message);
            }
        }

        private void cbxLoaiDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter(); // Sử dụng hàm lọc chung
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter(); // Lọc ngay khi gõ
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ApplyFilter(); // Nút tìm kiếm cũng dùng hàm lọc
        }

        /// <summary>
        /// Hàm lọc dữ liệu trên DataGridView từ dtAllDocGia đã tải sẵn
        /// </summary>
        private void ApplyFilter()
        {
            if (dtAllDocGia == null) return;

            string filterExpression = "";
            string searchText = txtTimKiem.Text.Trim();
            string selectedLoai = cbxLoaiDocGia.SelectedItem.ToString();

            // Lọc theo từ khóa
            if (!string.IsNullOrEmpty(searchText))
            {
                filterExpression = string.Format("HoTen LIKE '%{0}%' OR MaDocGia LIKE '%{0}%' OR Email LIKE '%{0}%' OR SDT LIKE '%{0}%'", searchText.Replace("'", "''"));
            }

            // Lọc theo loại độc giả
            if (selectedLoai != "Tất cả")
            {
                if (!string.IsNullOrEmpty(filterExpression))
                {
                    filterExpression += " AND ";
                }
                filterExpression += string.Format("TenLoaiDocGia = '{0}'", selectedLoai.Replace("'", "''"));
            }

            // Áp dụng bộ lọc cho DataView
            dtAllDocGia.DefaultView.RowFilter = filterExpression;
            dgvxemdocgia.DataSource = dtAllDocGia.DefaultView;
        }


        private void dgvxemdocgia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ DataView để đảm bảo đúng dòng đang hiển thị sau khi lọc
                DataRowView rowView = (DataRowView)dgvxemdocgia.Rows[e.RowIndex].DataBoundItem;

                string maDocGia = rowView["MaDocGia"].ToString();
                string tenDocGia = rowView["HoTen"].ToString();
                DateTime ngaySinh = Convert.ToDateTime(rowView["NgaySinh"]);
                string diaChi = rowView["DiaChi"].ToString();
                string email = rowView["Email"].ToString();
                DateTime ngayLapThe = Convert.ToDateTime(rowView["NgayLapThe"]);
                DateTime ngayHetHan = Convert.ToDateTime(rowView["NgayHetHan"]);
                string loaiDocGia = rowView["TenLoaiDocGia"].ToString();
                string IDAccount = rowView["IDAccount"].ToString();
                string soDienThoai = rowView["SDT"].ToString();

                chitietdocgia frm = new chitietdocgia(maDocGia, tenDocGia, ngaySinh, diaChi, email, ngayLapThe, ngayHetHan, loaiDocGia, IDAccount, soDienThoai);
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDatagrid(); // Tải lại dữ liệu nếu có thay đổi
                }
            }
        }

        private void btnthemdocgia_Click(object sender, EventArgs e)
        {
            using (ucthemdocgia frm = new ucthemdocgia())
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDatagrid();
                }
            }
        }
    }
}