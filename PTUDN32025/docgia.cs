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
using System.Collections.Generic;


namespace PTUDN32025
{
    public partial class ucdocgia : UserControl
    {
        public event EventHandler themdocgiaClicked;
        public ucdocgia()
        {
            InitializeComponent();
        }
        private DataTable dtAllDocGia;

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
        private void SetupDataGridview()
        {
            dgvxemdocgia.AutoGenerateColumns = false;
            dgvxemdocgia.Columns.Clear();

            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaDocGia", DataPropertyName = "MaDocGia", HeaderText = "Mã Độc Giả", Width = 100 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn { Name = "HoTen", DataPropertyName = "HoTen", HeaderText = "Họ Tên", Width = 300 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn {Name = "NgaySinh", DataPropertyName = "NgaySinh", HeaderText = "Ngày Sinh", Width = 100 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn {Name = "DiaChi", DataPropertyName = "DiaChi", HeaderText = "Địa Chỉ", Width = 200 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn {Name = "Email", DataPropertyName = "Email", HeaderText = "Email", Width = 150 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn {Name = "NgayLapThe", DataPropertyName = "NgayLapThe", HeaderText = "Ngày Lập Thẻ", Width = 100 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn {Name = "NgayHetHan", DataPropertyName = "NgayHetHan", HeaderText = "Ngày Hết Hạn", Width = 100 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn {Name = "TenLoaiDocGia", DataPropertyName = "TenLoaiDocGia", HeaderText = "Tên loại độc giả", Width = 200 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn {Name = "SDT", DataPropertyName = "SDT", HeaderText = "Số Điện Thoại", Width = 100 });
            dgvxemdocgia.Columns.Add(new DataGridViewTextBoxColumn {Name = "IDAccount", DataPropertyName = "IDAccount", HeaderText = "ID Tài Khoản", Width = 100 });
        }

        private void LoadDatagrid(string tenLoaiDocGia = null)
        {
            SetupDataGridview();

            string connectionString = "data source=.\\SQLEXPRESS;database=QuanLyThuVien;integrated security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT dg.MaDocGia, dg.HoTen, dg.NgaySinh, dg.DiaChi, dg.Email, 
                           dg.NgayLapThe, dg.NgayHetHan, ldg.TenLoaiDocGia, 
                           dg.SDT, dg.IDAccount
                    FROM DOCGIA dg
                    INNER JOIN LOAIDOCGIA ldg ON dg.MaLoaiDocGia = ldg.MaLoaiDocGia";

                if (!string.IsNullOrEmpty(tenLoaiDocGia))
                {
                    cmd.CommandText += " WHERE ldg.TenLoaiDocGia = @TenLoaiDocGia";
                    cmd.Parameters.AddWithValue("@TenLoaiDocGia", tenLoaiDocGia);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dtAllDocGia = new DataTable();
                da.Fill(dtAllDocGia);

                dgvxemdocgia.DataSource = dtAllDocGia;
            }
        }

        private void ucdocgia_Load(object sender, EventArgs e)
        {
            SetupDataGridview();
            LoadDatagrid();
            LoadLoaiDocGiaComboBox();

        }
        private void docgia_Load(object sender, EventArgs e)
        {
            SetupDataGridview();
            LoadDatagrid();
            
        }
        private void LoadLoaiDocGiaComboBox()
        {
            string connectionString = "data source=.\\SQLEXPRESS;database=QuanLyThuVien;integrated security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT TenLoaiDocGia FROM LOAIDOCGIA";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtLoaiDocGia = new DataTable();
                da.Fill(dtLoaiDocGia);
                cbxLoaiDocGia.Items.Clear();
                cbxLoaiDocGia.Items.Add("Tất cả");
                foreach (DataRow row in dtLoaiDocGia.Rows)
                {
                    cbxLoaiDocGia.Items.Add(row["TenLoaiDocGia"].ToString());
                }
                cbxLoaiDocGia.SelectedIndex = 0; // Chọn mục "Tất cả" làm mặc định
            }
        }
        private void cbxLoaiDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLoaiDocGia = cbxLoaiDocGia.SelectedItem.ToString();
            if (selectedLoaiDocGia == "Tất cả")
            {
                LoadDatagrid();
            }
            else
            {
                LoadDatagrid(selectedLoaiDocGia);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvxemdocgia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvxemdocgia.Rows[e.RowIndex];

                string maDocGia = row.Cells["MaDocGia"].Value.ToString();
                string tenDocGia = row.Cells["HoTen"].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                string diaChi = row.Cells["DiaChi"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                DateTime ngayLapThe = Convert.ToDateTime(row.Cells["NgayLapThe"].Value);
                DateTime ngayHetHan = Convert.ToDateTime(row.Cells["NgayHetHan"].Value);
                string loaiDocGia = row.Cells["TenLoaiDocGia"].Value.ToString();
                string IDAccount = row.Cells["IDAccount"].Value.ToString();
                string soDienThoai = row.Cells["SDT"].Value.ToString();


                chitietdocgia frm = new chitietdocgia(maDocGia, tenDocGia, ngaySinh, diaChi, email, ngayLapThe, ngayHetHan, loaiDocGia, IDAccount, soDienThoai);
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // 🔹 Gọi lại hàm load dữ liệu
                    LoadDatagrid();
                }
            }
            
        }
        private (string sql, List<SqlParameter> parameters) BuildKeywordSearchSql(string[] tokens)
        {
            // Các cột bạn muốn tìm theo
            string[] cols = new string[]
            {
        "dg.HoTen",
        "dg.Email",
        "dg.DiaChi",
        "dg.SDT",
        "ldg.TenLoaiDocGia"
            };

            var paramList = new List<SqlParameter>();
            var scoreParts = new List<string>();
            var whereParts = new List<string>();

            for (int t = 0; t < tokens.Length; t++)
            {
                string pname = "@p" + t;
                paramList.Add(new SqlParameter(pname, "%" + tokens[t] + "%"));

                var tokenConditions = new List<string>();
                foreach (var c in cols)
                {
                    scoreParts.Add($"SUM(CASE WHEN {c} COLLATE Latin1_General_CI_AI LIKE {pname} THEN 1 ELSE 0 END)");
                    tokenConditions.Add($"{c} COLLATE Latin1_General_CI_AI LIKE {pname}");
                }
                whereParts.Add("(" + string.Join(" OR ", tokenConditions) + ")");
            }

            string scoreExpr = string.Join(" + ", scoreParts);
            string whereExpr = string.Join(" OR ", whereParts);

            string sql = $@"
        SELECT dg.MaDocGia, dg.HoTen, dg.NgaySinh, dg.DiaChi, dg.Email,
               dg.NgayLapThe, dg.NgayHetHan, ldg.TenLoaiDocGia, dg.SDT,
               ({scoreExpr}) AS Score
        FROM DOCGIA dg
        LEFT JOIN LOAIDOCGIA ldg ON dg.MaLoaiDocGia = ldg.MaLoaiDocGia
        GROUP BY dg.MaDocGia, dg.HoTen, dg.NgaySinh, dg.DiaChi, dg.Email,
                 dg.NgayLapThe, dg.NgayHetHan, ldg.TenLoaiDocGia, dg.SDT
        HAVING ({scoreExpr}) > 0
        {(string.IsNullOrWhiteSpace(whereExpr) ? "" : " AND (" + whereExpr + ")")}
        ORDER BY Score DESC";

            return (sql, paramList);
        }

        private DataTable SearchByKeywords(string rawInput)
        {
            if (string.IsNullOrWhiteSpace(rawInput))
                return new DataTable();

            var tokens = Regex.Split(rawInput.Trim(), @"\s+")
                              .Where(t => !string.IsNullOrWhiteSpace(t))
                              .ToArray();

            if (tokens.Length == 0)
                return new DataTable();

            var (sql, parameters) = BuildKeywordSearchSql(tokens);

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

        private void DoSearch()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
                {
                    // Nếu không nhập gì thì hiển thị lại tất cả
                    LoadDatagrid();
                    return;
                }

                var dt = SearchByKeywords(txtTimKiem.Text);

                // 🔹 Gỡ liên kết cũ rồi gán DataSource mới
                dgvxemdocgia.DataSource = null;
                dgvxemdocgia.DataSource = dt;
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

    }
}
