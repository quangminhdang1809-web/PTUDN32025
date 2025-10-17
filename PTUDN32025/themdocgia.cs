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

namespace PTUDN32025
{
    public partial class ucthemdocgia : Form
    {
        public ucthemdocgia()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtdiachi.Text == "" || txtemail.Text == "" || txtIDAccount.Text == "" || txtmadocgia.Text == "" || txtsdt.Text == "" || txttendocgia.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            string maDocGia = txtmadocgia.Text.Trim();
            string username = txtIDAccount.Text.Trim();
            string password = txtsdt.Text.Trim();
            string hoTen = txttendocgia.Text.Trim();
            DateTime ngaySinh = dtpngaysinh.Value;
            string diaChi = txtdiachi.Text.Trim();
            string email = txtemail.Text.Trim();
            DateTime ngayLapThe = dtpngaylapthe.Value;
            DateTime ngayHetHan = dtpngayhethan.Value;
            string maLoaiDocGia = cbxloaidocgia.SelectedValue.ToString();
            string sdt = txtsdt.Text.Trim();

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    // 1️⃣ Kiểm tra ACCOUNT đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM ACCOUNT WHERE IDAccount = @IDAccount";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con, tran))
                    {
                        checkCmd.Parameters.AddWithValue("@IDAccount", username);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại!");
                            tran.Rollback();
                            return;
                        }
                    }

                    // 2️⃣ Thêm ACCOUNT với loại tài khoản mặc định USER
                    string queryAcc = @"
                INSERT INTO ACCOUNT (IDAccount, PasswordAccount, TypeOfAccount)
                OUTPUT INSERTED.IDAccount
                VALUES (@IDAccount, @PasswordAccount, 'USER')";

                    string idAccount;
                    using (SqlCommand cmdAcc = new SqlCommand(queryAcc, con, tran))
                    {
                        cmdAcc.Parameters.AddWithValue("@IDAccount", username);
                        cmdAcc.Parameters.AddWithValue("@PasswordAccount", password);
                        idAccount = (string)cmdAcc.ExecuteScalar();
                    }

                    // 3️⃣ Thêm DOCGIA
                    string queryDocGia = @"
                INSERT INTO DOCGIA 
                (MaDocGia,HoTen, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan, MaLoaiDocGia, IDAccount, SDT)
                VALUES 
                (@MaDocGia,@HoTen, @NgaySinh, @DiaChi, @Email, @NgayLapThe, @NgayHetHan, @MaLoaiDocGia, @IDAccount, @SDT)";

                    using (SqlCommand cmdDocGia = new SqlCommand(queryDocGia, con, tran))
                    {
                        cmdDocGia.Parameters.AddWithValue("@MaDocGia", maDocGia);
                        cmdDocGia.Parameters.AddWithValue("@HoTen", hoTen);
                        cmdDocGia.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        cmdDocGia.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmdDocGia.Parameters.AddWithValue("@Email", email);
                        cmdDocGia.Parameters.AddWithValue("@NgayLapThe", ngayLapThe);
                        cmdDocGia.Parameters.AddWithValue("@NgayHetHan", ngayHetHan);
                        cmdDocGia.Parameters.AddWithValue("@MaLoaiDocGia", maLoaiDocGia);
                        cmdDocGia.Parameters.AddWithValue("@IDAccount", idAccount);
                        cmdDocGia.Parameters.AddWithValue("@SDT", sdt);

                        cmdDocGia.ExecuteNonQuery();
                    }

                    tran.Commit();
                    MessageBox.Show("Đăng nhập thành công! Thêm độc giả + tài khoản USER thành công!");
                    ResetFields(); // reset các ô text
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void ResetFields()
        {
            txtmadocgia.Text = "";
            txtIDAccount.Text = "";
            txtsdt.Text = "";
            txttendocgia.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            dtpngaysinh.Value = DateTime.Now;
            dtpngaylapthe.Value = DateTime.Now;
            dtpngayhethan.Value = DateTime.Now;
            if (cbxloaidocgia.Items.Count > 0)
                cbxloaidocgia.SelectedIndex = 0; // chọn mặc định loại độc giả đầu tiên
        }




        private void themdocgia_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True;Connect Timeout=30"))
            {
                string sql = "SELECT MaLoaiDocGia, TenLoaiDocGia FROM LOAIDOCGIA";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbxloaidocgia.DataSource = dt;
                cbxloaidocgia.DisplayMember = "TenLoaiDocGia"; // hiển thị tên
                cbxloaidocgia.ValueMember = "MaLoaiDocGia";    // lưu mã
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm is frmthuthu mainForm)
            {
                // Gọi lại hàm LoadUserControl trong form chính
                mainForm.LoadUserControl(new quanlysach());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
