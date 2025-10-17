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
    public partial class frmdocgia : Form
    {
        public frmdocgia()
        {
            InitializeComponent();
        }
        private void frmdocgia_Shown(object sender, EventArgs e)
        {
            lblChaoMung.Text = "Chào mừng bạn đến với thư viện, " + Session.HoTen;
            lblTenDocGia.Text = Session.HoTen;
            lblMaDocGia.Text = Session.MaDocGia;
        }
        public void LoadControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(uc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            frmMuonSach frm = new frmMuonSach();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.Show();
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            Session.Clear();
            this.Hide();
            frmdangnhap frm = new frmdangnhap();
            frm.ShowDialog();
            this.Close();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
