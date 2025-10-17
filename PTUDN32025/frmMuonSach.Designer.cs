namespace PTUDN32025
{
    partial class frmMuonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvKetQuaTimKiem = new DataGridView();
            pnlTimKiem = new Panel();
            cbbSapXep = new ComboBox();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            txtTuKhoa = new TextBox();
            btnTimKiem = new Button();
            cbbTheLoai = new ComboBox();
            cbbTinhTrang = new ComboBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            tinhtrang = new DataGridViewTextBoxColumn();
            namxb = new DataGridViewTextBoxColumn();
            theloai = new DataGridViewTextBoxColumn();
            tacgia = new DataGridViewTextBoxColumn();
            tensach = new DataGridViewTextBoxColumn();
            masach = new DataGridViewTextBoxColumn();
            btnMuon = new Button();
            colMaSach = new DataGridViewTextBoxColumn();
            colAnhBia = new DataGridViewImageColumn();
            colTenSach = new DataGridViewTextBoxColumn();
            colTheLoai = new DataGridViewTextBoxColumn();
            colTacGia = new DataGridViewTextBoxColumn();
            colNamXuatBan = new DataGridViewTextBoxColumn();
            colNhaXuatBan = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaTimKiem).BeginInit();
            pnlTimKiem.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKetQuaTimKiem
            // 
            dgvKetQuaTimKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKetQuaTimKiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKetQuaTimKiem.Columns.AddRange(new DataGridViewColumn[] { colMaSach, colAnhBia, colTenSach, colTheLoai, colTacGia, colNamXuatBan, colNhaXuatBan, colSoLuong });
            dgvKetQuaTimKiem.Location = new Point(3, 111);
            dgvKetQuaTimKiem.Name = "dgvKetQuaTimKiem";
            dgvKetQuaTimKiem.RowHeadersWidth = 82;
            dgvKetQuaTimKiem.RowTemplate.Height = 150;
            dgvKetQuaTimKiem.Size = new Size(1762, 778);
            dgvKetQuaTimKiem.TabIndex = 1;
            dgvKetQuaTimKiem.CellClick += dgvKetQuaTimKiem_CellClick;
            dgvKetQuaTimKiem.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(cbbSapXep);
            pnlTimKiem.Controls.Add(lblTimKiem);
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(btnTim);
            pnlTimKiem.Dock = DockStyle.Top;
            pnlTimKiem.Location = new Point(0, 0);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1762, 119);
            pnlTimKiem.TabIndex = 0;
            // 
            // cbbSapXep
            // 
            cbbSapXep.FormattingEnabled = true;
            cbbSapXep.Location = new Point(1077, 35);
            cbbSapXep.Name = "cbbSapXep";
            cbbSapXep.Size = new Size(281, 40);
            cbbSapXep.TabIndex = 4;
            cbbSapXep.Text = "Chọn danh mục";
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(136, 35);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(113, 32);
            lblTimKiem.TabIndex = 9;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(331, 35);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(478, 39);
            txtTimKiem.TabIndex = 4;
            txtTimKiem.Text = "Tìm kiếm bằng tên sách, tên tác giả";
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(868, 35);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(150, 46);
            btnTim.TabIndex = 5;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Location = new Point(35, 39);
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(200, 39);
            txtTuKhoa.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(381, 49);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 46);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // cbbTheLoai
            // 
            cbbTheLoai.FormattingEnabled = true;
            cbbTheLoai.Location = new Point(40, 97);
            cbbTheLoai.Name = "cbbTheLoai";
            cbbTheLoai.Size = new Size(242, 40);
            cbbTheLoai.TabIndex = 2;
            // 
            // cbbTinhTrang
            // 
            cbbTinhTrang.FormattingEnabled = true;
            cbbTinhTrang.Location = new Point(327, 101);
            cbbTinhTrang.Name = "cbbTinhTrang";
            cbbTinhTrang.Size = new Size(242, 40);
            cbbTinhTrang.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1740, 200);
            panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(606, 39);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(705, 39);
            button1.Name = "button1";
            button1.Size = new Size(148, 39);
            button1.TabIndex = 1;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(40, 97);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 40);
            comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(404, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 2;
            // 
            // tinhtrang
            // 
            tinhtrang.HeaderText = "Tình trạng";
            tinhtrang.MinimumWidth = 10;
            tinhtrang.Name = "tinhtrang";
            tinhtrang.Width = 200;
            // 
            // namxb
            // 
            namxb.HeaderText = "Năm xuất bản";
            namxb.MinimumWidth = 10;
            namxb.Name = "namxb";
            namxb.Width = 200;
            // 
            // theloai
            // 
            theloai.HeaderText = "Thể loại";
            theloai.MinimumWidth = 10;
            theloai.Name = "theloai";
            theloai.Width = 200;
            // 
            // tacgia
            // 
            tacgia.HeaderText = "Tác giả";
            tacgia.MinimumWidth = 10;
            tacgia.Name = "tacgia";
            tacgia.Width = 200;
            // 
            // tensach
            // 
            tensach.HeaderText = "Tên sách";
            tensach.MinimumWidth = 10;
            tensach.Name = "tensach";
            tensach.Width = 200;
            // 
            // masach
            // 
            masach.HeaderText = "Mã sách";
            masach.MinimumWidth = 10;
            masach.Name = "masach";
            masach.Width = 200;
            // 
            // btnMuon
            // 
            btnMuon.Location = new Point(1492, 25);
            btnMuon.Name = "btnMuon";
            btnMuon.Size = new Size(150, 46);
            btnMuon.TabIndex = 2;
            btnMuon.Text = "Mượn ";
            btnMuon.UseVisualStyleBackColor = true;
            // 
            // colMaSach
            // 
            colMaSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMaSach.DefaultCellStyle = dataGridViewCellStyle1;
            colMaSach.FillWeight = 20F;
            colMaSach.HeaderText = "Mã sách";
            colMaSach.MinimumWidth = 10;
            colMaSach.Name = "colMaSach";
            colMaSach.Width = 150;
            // 
            // colAnhBia
            // 
            colAnhBia.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colAnhBia.HeaderText = "Bìa sách ";
            colAnhBia.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colAnhBia.MinimumWidth = 10;
            colAnhBia.Name = "colAnhBia";
            colAnhBia.Width = 250;
            // 
            // colTenSach
            // 
            colTenSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTenSach.DefaultCellStyle = dataGridViewCellStyle2;
            colTenSach.FillWeight = 80F;
            colTenSach.HeaderText = "Tên sách";
            colTenSach.MinimumWidth = 10;
            colTenSach.Name = "colTenSach";
            colTenSach.Width = 200;
            // 
            // colTheLoai
            // 
            colTheLoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTheLoai.DefaultCellStyle = dataGridViewCellStyle3;
            colTheLoai.FillWeight = 50F;
            colTheLoai.HeaderText = "Thể loại";
            colTheLoai.MinimumWidth = 10;
            colTheLoai.Name = "colTheLoai";
            colTheLoai.Width = 200;
            // 
            // colTacGia
            // 
            colTacGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTacGia.DefaultCellStyle = dataGridViewCellStyle4;
            colTacGia.FillWeight = 60F;
            colTacGia.HeaderText = "Tác giả";
            colTacGia.MinimumWidth = 10;
            colTacGia.Name = "colTacGia";
            colTacGia.Width = 200;
            // 
            // colNamXuatBan
            // 
            colNamXuatBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colNamXuatBan.DefaultCellStyle = dataGridViewCellStyle5;
            colNamXuatBan.FillWeight = 40F;
            colNamXuatBan.HeaderText = "Năm xuất bản";
            colNamXuatBan.MinimumWidth = 10;
            colNamXuatBan.Name = "colNamXuatBan";
            colNamXuatBan.Width = 200;
            // 
            // colNhaXuatBan
            // 
            colNhaXuatBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNhaXuatBan.HeaderText = "Nhà xuất bản";
            colNhaXuatBan.MinimumWidth = 10;
            colNhaXuatBan.Name = "colNhaXuatBan";
            colNhaXuatBan.Visible = false;
            colNhaXuatBan.Width = 200;
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 10;
            colSoLuong.Name = "colSoLuong";
            // 
            // frmMuonSach
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1762, 889);
            Controls.Add(pnlTimKiem);
            Controls.Add(dgvKetQuaTimKiem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMuonSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMuonSach";
            ((System.ComponentModel.ISupportInitialize)dgvKetQuaTimKiem).EndInit();
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlTimKiem;
        private TextBox txtTuKhoa;
        private Button btnTimKiem;
        private ComboBox cbbTheLoai;
        private ComboBox cbbTinhTrang;
        private Panel panel2;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn tinhtrang;
        private DataGridViewTextBoxColumn namxb;
        private DataGridViewTextBoxColumn theloai;
        private DataGridViewTextBoxColumn tacgia;
        private DataGridViewTextBoxColumn tensach;
        private DataGridViewTextBoxColumn masach;
        private Button btnMuon;
        private Button btnTim;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private DataGridView dgvKetQuaTimKiem;
        private ComboBox cbbSapXep;
        private DataGridViewTextBoxColumn colMaSach;
        private DataGridViewImageColumn colAnhBia;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colTheLoai;
        private DataGridViewTextBoxColumn colTacGia;
        private DataGridViewTextBoxColumn colNamXuatBan;
        private DataGridViewTextBoxColumn colNhaXuatBan;
        private DataGridViewTextBoxColumn colSoLuong;
    }
}