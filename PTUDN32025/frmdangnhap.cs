using System.Data.SqlClient;
using System;
using System.Data;
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAM; database = QuanLyThuVien; Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from ACCOUNT where IDAccount = '" + txttendangnhap.Text + "'and PasswordAccount ='" + txtmatkhau.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

           if (ds.Tables[0].Rows.Count > 0)
            {
                string role = ds.Tables[0].Rows[0]["TypeOfAccount"].ToString();

                this.Hide();

                if (role == "ADMIN")
                {
                    frmthuthu f = new frmthuthu();
                    f.ShowDialog();
                }
                else if (role == "USER")
                {
                    frmdocgia f = new frmdocgia();
                    f.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
