using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDN32025
{
    public partial class frmthuthu : Form
    {
        public frmthuthu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }



        private void frmmainform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnqlsach_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Hide();
                frmdangnhap dangnhap = new frmdangnhap();
                dangnhap.ShowDialog();
                this.Close();
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        public void LoadUserControl(UserControl uc)
        {
            // Xóa control cũ trong panel
            panelMain.Controls.Clear();

            // Dock cho user control chiếm toàn bộ panel
            uc.Dock = DockStyle.Fill;

            // Thêm user control vào panel
            panelMain.Controls.Add(uc);
            uc.BringToFront(); // Đưa user control lên trên cùng
        }
        private void btndocgia_Click(object sender, EventArgs e)
        {
            ucdocgia uc = new ucdocgia();  // khởi tạo
            uc.themdocgiaClicked += themdocgiaClicked;
            LoadUserControl(uc);

        }

        private void btnquanlysach_Click(object sender, EventArgs e)
        {
            quanlysach uc = new quanlysach();
            uc.themsachClicked += themsachClicked;
            LoadUserControl(uc);
            uc.RefreshData();
        }
        private void themsachClicked(object sender, EventArgs e)
        {
            themsach frm = new themsach();
            frm.StartPosition = FormStartPosition.CenterScreen; // hoặc CenterParent
            frm.WindowState = FormWindowState.Normal;
            frm.ShowDialog();

        }
        private void themdocgiaClicked(object sender, EventArgs e)
        {
            ucthemdocgia Themdocgia = new ucthemdocgia();
            Themdocgia.StartPosition = FormStartPosition.CenterScreen; // hoặc CenterParent
            Themdocgia.WindowState = FormWindowState.Normal;
            Themdocgia.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
