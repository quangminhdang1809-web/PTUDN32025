using System.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
namespace PTUDN32025
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttendangnhap_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txttendangnhap_MouseClick(object sender, MouseEventArgs e)
        {
            if (txttendangnhap.Text == "Tên đăng nhập")
            {
                txttendangnhap.Clear();
            }
        }

        private void txtmatkhau_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtmatkhau.Text == "Mật khẩu")
            {
                txtmatkhau.Clear();
                txtmatkhau.PasswordChar = '*';
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string ConnectionString = "data source = .\\SQLEXPRESS; database = QuanLyThuVien; Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM ACCOUNT WHERE IDAccount = @IDAccount AND PasswordAccount = @PasswordAccount";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IDAccount", txttendangnhap.Text);
                cmd.Parameters.AddWithValue("@PasswordAccount", txtmatkhau.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string role = reader["TypeOfAccount"].ToString();
                    Session.IDAccount = reader["IDAccount"].ToString();
                    Session.TypeOfAccount = role;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reader.Close();
                    return;
                }
                reader.Close();

                if (Session.TypeOfAccount == "ADMIN")
                    {
                        this.Hide(); 
                        frmthuthu f = new frmthuthu();
                        f.ShowDialog();
                        this.Close(); 
                    }
                else if (Session.TypeOfAccount == "USER")
                    {
                        using (SqlConnection con2 = new SqlConnection(ConnectionString))
                        {
                            con2.Open();
                            string queryDocGia = "Select MaDocGia, HoTen from DOCGIA where IDAccount = @id";
                            SqlCommand cmdDocGia = new SqlCommand(queryDocGia, con2);
                            cmdDocGia.Parameters.AddWithValue("@id", Session.IDAccount);

                            SqlDataReader readerDG = cmdDocGia.ExecuteReader();
                            if (readerDG.Read())
                            {
                                Session.MaDocGia = readerDG["MaDocGia"].ToString();
                                Session.HoTen = readerDG["HoTen"].ToString();
                            }
                            readerDG.Close();
                        }
                        this.Hide();
                        frmdocgia f = new frmdocgia();
                        f.ShowDialog();
                        this.Close();
                    }   
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void txttendangnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
