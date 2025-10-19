using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace PTUDN32025
{
    public partial class quanlysach : UserControl
    {
        public event EventHandler themsachClicked;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["LibraryDB"].ConnectionString;
        private DataTable dtAllBooks;

        public quanlysach()
        {
            InitializeComponent();
        }

        private void quanlysach_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadTheLoaiComboBox();
            LoadDataGrid();
        }

        #region Tải và Hiển thị Dữ liệu

        private void SetupDataGridView()
        {
            dgvxemsach.AutoGenerateColumns = false;
            dgvxemsach.Columns.Clear();

            // SỬA 1: Đã xóa cột hiển thị ảnh bìa (DataGridViewImageColumn)
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenDauSach", DataPropertyName = "TenDauSach", HeaderText = "Tên Sách", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "TacGia", DataPropertyName = "TacGia", HeaderText = "Tác Giả", Width = 200 });
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenTheLoai", DataPropertyName = "TenTheLoai", HeaderText = "Thể Loại", Width = 150 });
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "NhaXuatBan", DataPropertyName = "NhaXuatBan", HeaderText = "NXB", Width = 150 });
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoSach", DataPropertyName = "SoSach", HeaderText = "Số Lượng", Width = 80 });
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "NamXuatBan", DataPropertyName = "NamXuatBan", HeaderText = "Năm XB", Width = 80 });

            // SỬA 2: Đã xóa cột ẩn AnhBia
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaDauSach", DataPropertyName = "MaDauSach", Visible = false });
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaTheLoai", DataPropertyName = "MaTheLoai", Visible = false });
        }

        private void LoadDataGrid()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    // SỬA 3: Đã xóa DS.AnhBia khỏi câu lệnh SELECT
                    cmd.CommandText = @"
                        SELECT
                            DS.MaDauSach, DS.TenDauSach, DS.NhaXuatBan, DS.NamXuatBan,
                            DS.SoSach, DS.MaTheLoai, TL.TenTheLoai,
                            STUFF((
                                SELECT ', ' + TG.TenTacGia
                                FROM DAUSACH_TACGIA DSTG
                                JOIN TACGIA TG ON DSTG.MaTacGia = TG.MaTacGia
                                WHERE DSTG.MaDauSach = DS.MaDauSach
                                FOR XML PATH(''), TYPE
                            ).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS TacGia
                        FROM DAUSACH DS
                        LEFT JOIN THELOAI TL ON DS.MaTheLoai = TL.MaTheLoai";

                    dtAllBooks = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtAllBooks);
                    }

                    // SỬA 4: Đã xóa toàn bộ phần code xử lý cột ảnh
                    dgvxemsach.DataSource = dtAllBooks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTheLoaiComboBox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MaTheLoai, TenTheLoai FROM THELOAI", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow row = dt.NewRow();
                    row["MaTheLoai"] = "0";
                    row["TenTheLoai"] = "Tất cả";
                    dt.Rows.InsertAt(row, 0);

                    cbxTheLoai.DataSource = dt;
                    cbxTheLoai.DisplayMember = "TenTheLoai";
                    cbxTheLoai.ValueMember = "MaTheLoai";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thể loại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Xử lý Sự kiện (Events)

        private void btnthemsach_Click(object sender, EventArgs e) { /* Code thêm sách của bạn */ }
        private void dgvxemsach_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { /* Code xem chi tiết của bạn */ }

        private void txtSearch_TextChanged(object sender, EventArgs e) { ApplyFilter(); }
        private void cbxTheLoai_SelectedIndexChanged(object sender, EventArgs e) { ApplyFilter(); }
        private void btnTimKiem_Click(object sender, EventArgs e) { ApplyFilter(); }

        private void ApplyFilter()
        {
            if (dtAllBooks == null) return;
            var filterParts = new System.Collections.Generic.List<string>();
            string searchText = txtTimKiem.Text.Trim();
            string selectedMaTheLoai = cbxTheLoai.SelectedValue?.ToString();

            if (!string.IsNullOrEmpty(selectedMaTheLoai) && selectedMaTheLoai != "0")
            {
                filterParts.Add($"MaTheLoai = '{selectedMaTheLoai}'");
            }
            if (!string.IsNullOrEmpty(searchText))
            {
                string safeSearchText = searchText.Replace("'", "''");
                filterParts.Add($"(TenDauSach LIKE '%{safeSearchText}%' OR TacGia LIKE '%{safeSearchText}%' OR NhaXuatBan LIKE '%{safeSearchText}%')");
            }
            dtAllBooks.DefaultView.RowFilter = string.Join(" AND ", filterParts);
        }

        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void dgvxemsach_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        #endregion

        public void RefreshData()
        {
            LoadDataGrid();
            ApplyFilter();
        }
    }
}