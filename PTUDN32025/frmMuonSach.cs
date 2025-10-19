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
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Text;

namespace PTUDN32025
{
    public partial class frmMuonSach : Form
    {
        private string basePath = @"C:\Users\ngoca\source\repos\PTUDN3\PTUDN32025\Image"; 
        private (string sql, List<SqlParameter> parameters) BuildKeywordSearchSql(string[] tokens)
        {
            string[] cols = new string[] { "ds.TenDauSach", "tl.TenTheLoai", "CAST (ds.NamXuatBan AS NVARCHAR)" };

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
                    scoreParts.Add($"SUM(CASE WHEN {c} COLLATE Latin1_General_CI_AI like {pname} then 1 else 0 end)");
                    tokenConditions.Add($"{c} COLLATE Latin1_General_CI_AI like {pname}");
                }
                whereParts.Add("(" + string.Join(" OR ", tokenConditions) + ")");
            }

            string scoreExpr = string.Join(" + ", scoreParts);
            string whereExpr = string.Join(" OR ", whereParts);

            string sql = $@"SELECT ds.MaDauSach, ds.AnhBia, ds.TenDauSach, ds.NamXuatBan, ds.NhaXuatBan, tl.TenTheLoai, ds.SoLuong, string_agg(tg.TenTacGia, ', ') as TacGia, ({scoreExpr}) as Score
                           from DAUSACH ds 
                           left join DAUSACH_TACGIA dstg on ds.MaDauSach = dstg.MaDauSach
                           left join TACGIA tg on dstg.MaTacGia = tg.MaTacGia
                           left join THELOAI tl on ds.MaTheLoai = tl.MaTheLoai
                           group by ds.MaDauSach, ds.TenDauSach, ds.NamXuatBan, ds.NhaXuatBan, ds.SoLuong, tl.TenTheLoai, ds.AnhBia
                           HAVING ({scoreExpr}) >0
                           {(string.IsNullOrWhiteSpace(whereExpr) ? "" : " AND (" + whereExpr + ")")}
                           ORDER BY Score DESC";
            return (sql, paramList);
        }

        private DataTable SearchByKeywords(string rawInput)
        {
            if (string.IsNullOrWhiteSpace(rawInput))
            {
                return new DataTable();
            }
            var tokens = Regex.Split(rawInput.Trim(), @"\s+").Where(t => !string.IsNullOrWhiteSpace(t)).ToArray();
            if (tokens.Length == 0)
            {
                return new DataTable();
            }
            var (sql, parameters) = BuildKeywordSearchSql(tokens);

            DBHelper db = new DBHelper();
            return db.ExecuteQuery(sql, parameters.ToArray());
        }

        public frmMuonSach()
        {
            InitializeComponent();
            dgvKetQuaTimKiem.AutoGenerateColumns = false;
        }
        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            SetupAutoComplete();
            SetupDebounce();
        }
        private void SetupAutoComplete()
        {
            DBHelper db = new DBHelper();
            var dt = db.ExecuteQuery("SELECT DISTINCT ds.TenDauSach FROM DAUSACH ds");
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                col.Add(row["TenDauSach"].ToString());
            }
            txtTimKiem.AutoCompleteCustomSource = col;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private System.Windows.Forms.Timer searchTimer;
        private void SetupDebounce()
        {
            searchTimer = new System.Windows.Forms.Timer();
            searchTimer.Interval = 400;
            searchTimer.Tick += (s, e) =>
            {
                searchTimer.Stop();
                DoSearch();
            };
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (searchTimer != null)
            {
                searchTimer.Stop();
                searchTimer.Start();
            }
        }
        private void DoSearch()
        {
            try
            {
                var dt = SearchByKeywords(txtTimKiem.Text);
                dgvKetQuaTimKiem.DataSource = null;
                dgvKetQuaTimKiem.Rows.Clear();

                dgvKetQuaTimKiem.RowTemplate.Height = 150;
                ((DataGridViewImageColumn)dgvKetQuaTimKiem.Columns[1]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvKetQuaTimKiem.Columns[1].Width = 120;
                foreach (DataRow row in dt.Rows)
                {
                    Image img = null;
                    string rel = row["AnhBia"]?.ToString();

                    try
                    {
                        if (!string.IsNullOrEmpty(rel))
                        {
                            string fullPath = Path.Combine(Application.StartupPath, rel);
                            if (File.Exists(fullPath))
                            {
                                img = Image.FromFile(fullPath);
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy file ảnh: " + fullPath);
                            }
                        }
                        int i = dgvKetQuaTimKiem.Rows.Add();
                        dgvKetQuaTimKiem.Rows[i].Cells["colMaSach"].Value = row["MaDauSach"].ToString();
                        dgvKetQuaTimKiem.Rows[i].Cells["colAnhBia"].Value = img;
                        dgvKetQuaTimKiem.Rows[i].Cells["colTenSach"].Value = row["TenDauSach"].ToString();
                        dgvKetQuaTimKiem.Rows[i].Cells["colTheLoai"].Value = row["TenTheLoai"].ToString();
                        dgvKetQuaTimKiem.Rows[i].Cells["colTacGia"].Value = row["TacGia"].ToString();
                        dgvKetQuaTimKiem.Rows[i].Cells["colNamXuatBan"].Value = row["NamXuatBan"].ToString();
                        dgvKetQuaTimKiem.Rows[i].Cells["colNhaXuatBan"].Value = row["NhaXuatBan"].ToString();
                        dgvKetQuaTimKiem.Rows[i].Cells["colSoLuong"].Value = row["SoLuong"].ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải ảnh: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm thấy sách!" + ex.Message);
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCanhBao_Click(object sender, EventArgs e)
        {

        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {

        }
        private void dgvKetQuaTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKetQuaTimKiem.Rows[e.RowIndex];
                string maDauSach = row.Cells["colMaSach"].Value.ToString(); 
                string tenSach = row.Cells["colTenSach"].Value.ToString();
                string tacGia = row.Cells["colTacGia"].Value.ToString();
                string theLoai = row.Cells["colTheLoai"].Value.ToString();
                int namXuatBan = Convert.ToInt32(row.Cells["colNamXuatBan"].Value);
                string nhaXuatBan = row.Cells["colNhaXuatBan"].Value.ToString();
                Image anhBia = row.Cells["colAnhBia"].Value as Image;
                int soLuong = Convert.ToInt32(row.Cells["colSoLuong"].Value);

                frmChiTietSach frm = new frmChiTietSach(maDauSach, Session.MaDocGia, tenSach, tacGia, theLoai, namXuatBan, nhaXuatBan, anhBia, soLuong);
                frm.ShowDialog();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
