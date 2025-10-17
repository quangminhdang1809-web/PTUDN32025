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

namespace PTUDN32025
{
    public partial class quanlysach : UserControl
    {
        public event EventHandler themsachClicked;
        public quanlysach()
        {
            InitializeComponent();
        }

        // * SỬA: Thay đổi kiểu dữ liệu thành string để khớp với Mã Đầu Sách (001, 002...)
        private string currentMaDauSach = "";
        private string originalTenSach, originalTheLoai, originalNXB;
        private int originalSoLuong, originalNamXB;
        private string originalAnhBia;
        private bool isEditing = false;
        private DataTable dtAllBooks;

        private void btnthemsach_Click(object sender, EventArgs e)
        {
            using (themsach frm = new themsach())
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Tải lại dữ liệu sau khi thêm sách thành công
                    LoadDataGrid();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        private void quanlysach_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadDataGrid();
            LoadTheLoaiComboBox();
        }
        private void dgvxemsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvxemsach.Rows.Count)
            {
                DataGridViewRow row = dgvxemsach.Rows[e.RowIndex];

                // Lấy MaDauSach dưới dạng chuỗi
                currentMaDauSach = row.Cells["MaDauSach"].Value.ToString();

                originalTenSach = row.Cells["TenDauSach"].Value.ToString();
                originalTheLoai = row.Cells["TenTheLoai"].Value.ToString();
                originalNXB = row.Cells["NhaXuatBan"].Value.ToString();

                // SỬA: Xử lý DBNull an toàn khi đọc SoSach
                originalSoLuong = row.Cells["SoSach"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["SoSach"].Value);

                originalNamXB = Convert.ToInt32(row.Cells["NamXuatBan"].Value);
                originalAnhBia = row.Cells["AnhBia"].Value == DBNull.Value ? null : row.Cells["AnhBia"].Value.ToString();
            }
        }
        private void gdvxemsach_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // Thay thế hàm quanlysach_Load hoặc tạo hàm mới
        private void LoadDataGrid(string tenTheLoai = null)
        {
            SetupDataGridView();

            string connectionString = "data source=.\\SQLEXPRESS;database=QuanLyThuVien;integrated security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT
                DS.MaDauSach,
                DS.TenDauSach,
                DS.NhaXuatBan,
                DS.NamXuatBan,
                DS.SoSach,
                DS.AnhBia,
                TL.TenTheLoai,
                -- gộp tên tác giả
                STUFF((
                    SELECT ', ' + TG.TenTacGia
                    FROM DAUSACH_TACGIA DSTG
                    INNER JOIN TACGIA TG ON DSTG.MaTacGia = TG.MaTacGia
                    WHERE DSTG.MaDauSach = DS.MaDauSach
                    FOR XML PATH(''), TYPE
                ).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS TacGia
            FROM DAUSACH DS
            INNER JOIN THELOAI TL ON DS.MaTheLoai = TL.MaTheLoai";

                if (!string.IsNullOrEmpty(tenTheLoai))
                {
                    cmd.CommandText += " WHERE TL.TenTheLoai = @TenTheLoai";
                    cmd.Parameters.AddWithValue("@TenTheLoai", tenTheLoai);
                }

                dtAllBooks = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtAllBooks);
                }

                // thêm cột ảnh hiển thị
                if (!dtAllBooks.Columns.Contains("AnhHienThi"))
                    dtAllBooks.Columns.Add("AnhHienThi", typeof(Image));

                foreach (DataRow row in dtAllBooks.Rows)
                {
                    string path = row["AnhBia"] == DBNull.Value ? null : row["AnhBia"].ToString();
                    if (!string.IsNullOrEmpty(path) && File.Exists(path))
                    {
                        try
                        {
                            byte[] bytes = File.ReadAllBytes(path);
                            using (var ms = new MemoryStream(bytes))
                            using (var tmp = Image.FromStream(ms))
                            {
                                row["AnhHienThi"] = new Bitmap(tmp);
                            }
                        }
                        catch { row["AnhHienThi"] = DBNull.Value; }
                    }
                    else
                    {
                        row["AnhHienThi"] = DBNull.Value;
                    }
                }

                dgvxemsach.DataSource = dtAllBooks;
            }
        }


        private void SetupDataGridView()
        {
            dgvxemsach.AutoGenerateColumns = false;
            dgvxemsach.Columns.Clear();

            // Cột ảnh hiển thị
            var imgCol = new DataGridViewImageColumn
            {
                Name = "AnhHienThi",
                HeaderText = "Ảnh Bìa",
                DataPropertyName = "AnhHienThi",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 100
            };
            dgvxemsach.Columns.Add(imgCol);

            // Các cột dữ liệu (Name phải trùng với DataPropertyName / tên cột trong DataTable)
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenDauSach", DataPropertyName = "TenDauSach", HeaderText = "Tên Sách" });
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenTheLoai", DataPropertyName = "TenTheLoai", HeaderText = "Thể Loại" });
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "NhaXuatBan", DataPropertyName = "NhaXuatBan", HeaderText = "NXB" });
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoSach", DataPropertyName = "SoSach", HeaderText = "Số Lượng" });
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "NamXuatBan", DataPropertyName = "NamXuatBan", HeaderText = "Năm XB" });

            // Cột chứa đường dẫn ảnh thực tế (ẩn)
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "AnhBia", DataPropertyName = "AnhBia", Visible = false });

            // Cột khóa chính (ẩn)
            dgvxemsach.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaDauSach", DataPropertyName = "MaDauSach", Visible = false });
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Giả định bạn có control txtTimKiem trên Form
            // FilterData(txtTimKiem.Text.Trim()); 
        }

        private void dgvxemsach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvxemsach.Rows[e.RowIndex];

                // Lấy MaDauSach dưới dạng chuỗi
                string maDauSach = row.Cells["MaDauSach"].Value.ToString();

                string tenSach = row.Cells["TenDauSach"].Value.ToString();
                string theLoai = row.Cells["TenTheLoai"].Value.ToString();
                string nxb = row.Cells["NhaXuatBan"].Value.ToString();

                // Lấy SoSach và AnhBia dưới dạng OBJECT để xử lý DBNull an toàn
                object soLuongObject = row.Cells["SoSach"].Value;

                int namXB = Convert.ToInt32(row.Cells["NamXuatBan"].Value);

                object anhBiaObject = row.Cells["AnhBia"].Value;

                // SỬA: Chuyển đổi an toàn các Object có thể NULL thành kiểu cần thiết
                int soLuongSafe = soLuongObject == DBNull.Value ? 0 : Convert.ToInt32(soLuongObject);
                string anhBiaSafe = anhBiaObject == DBNull.Value ? null : (string)anhBiaObject;


                // Gọi constructor của chitietsach với các tham số đã được sửa an toàn
                chitietsach frm = new chitietsach(maDauSach, tenSach, theLoai, nxb, namXB, soLuongSafe, anhBiaSafe);
                frm.StartPosition = FormStartPosition.CenterParent;

                // Mở Form chi tiết và tải lại dữ liệu nếu có chỉnh sửa
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDataGrid();
                }
            }
        }
        private void LoadTheLoaiComboBox()
        {
            string connectionString = "data source=.\\SQLEXPRESS;database=QuanLyThuVien;integrated security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaTheLoai, TenTheLoai FROM THELOAI", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Thêm dòng "Tất cả"
                DataRow row = dt.NewRow();
                row["MaTheLoai"] = 0;
                row["TenTheLoai"] = "Tất cả";
                dt.Rows.InsertAt(row, 0);

                cbxTheLoai.DataSource = dt;
                cbxTheLoai.DisplayMember = "TenTheLoai";   // <-- Hiển thị TÊN
                cbxTheLoai.ValueMember = "MaTheLoai";      // <-- Lưu mã
            }
        }


        private void cbxTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTheLoai.SelectedValue != null)
            {
                if (cbxTheLoai.SelectedValue.ToString() == "0")
                {
                    LoadDataGrid(); // tất cả
                }
                else
                {
                    string tenTheLoai = cbxTheLoai.Text; // lấy tên thể loại
                    LoadDataGrid(tenTheLoai);
                }
            }
        }

        // 🔹 Tạo câu SQL tìm kiếm sách
        private (string sql, List<SqlParameter> parameters) BuildBookSearchSql(string[] tokens)
        {
            // Các cột muốn tìm kiếm
            string[] cols = new string[]
            {
        "DS.TenDauSach",
        "TL.TenTheLoai",
        "DS.NhaXuatBan",
        "TG.TenTacGia"
            };

            var paramList = new List<SqlParameter>();
            var whereParts = new List<string>();

            for (int t = 0; t < tokens.Length; t++)
            {
                string pname = "@p" + t;
                paramList.Add(new SqlParameter(pname, "%" + tokens[t] + "%"));

                var tokenConditions = cols.Select(c => $"{c} LIKE {pname}");
                whereParts.Add("(" + string.Join(" OR ", tokenConditions) + ")");
            }

            string whereExpr = string.Join(" AND ", whereParts);

            string sql = $@"
        SELECT DS.MaDauSach, DS.TenDauSach, TL.TenTheLoai, DS.NhaXuatBan,
               DS.NamXuatBan, DS.SoSach, DS.AnhBia,
               STUFF((
                    SELECT ', ' + TG.TenTacGia
                    FROM DAUSACH_TACGIA DSTG
                    INNER JOIN TACGIA TG ON DSTG.MaTacGia = TG.MaTacGia
                    WHERE DSTG.MaDauSach = DS.MaDauSach
                    FOR XML PATH(''), TYPE
               ).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS TacGia
        FROM DAUSACH DS
        INNER JOIN THELOAI TL ON DS.MaTheLoai = TL.MaTheLoai
        LEFT JOIN DAUSACH_TACGIA DSTG ON DS.MaDauSach = DSTG.MaDauSach
        LEFT JOIN TACGIA TG ON DSTG.MaTacGia = TG.MaTacGia
        {(string.IsNullOrEmpty(whereExpr) ? "" : "WHERE " + whereExpr)}
        GROUP BY DS.MaDauSach, DS.TenDauSach, TL.TenTheLoai, DS.NhaXuatBan,
                 DS.NamXuatBan, DS.SoSach, DS.AnhBia";
            return (sql, paramList);
        }

        // 🔹 Hàm chạy tìm kiếm
        private DataTable SearchBooks(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return new DataTable();

            var tokens = Regex.Split(keyword.Trim(), @"\s+")
                              .Where(t => !string.IsNullOrWhiteSpace(t))
                              .ToArray();

            var (sql, parameters) = BuildBookSearchSql(tokens);

            string connectionString = "data source=.\\SQLEXPRESS;database=QuanLyThuVien;integrated security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddRange(parameters.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 🔹 Gọi khi bấm nút tìm kiếm
        private void DoSearch()
        {
            try
            {
                // Giả định bạn có control txtTimKiem trên Form
                // if (string.IsNullOrWhiteSpace(txtTimKiem.Text)) 
                // {
                //     LoadDataGrid();
                //     return;
                // }

                // var dt = SearchBooks(txtTimKiem.Text.Trim());
                // dgvxemsach.DataSource = null;
                // dgvxemsach.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DoSearch();
        }
        public void RefreshData()
        {
            SetupDataGridView();
            LoadDataGrid();
            LoadTheLoaiComboBox();
        }

    }
}
