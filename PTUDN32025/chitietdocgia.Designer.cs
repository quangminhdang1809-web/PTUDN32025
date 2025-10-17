namespace PTUDN32025
{
    partial class chitietdocgia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chitietdocgia));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnUndo = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            groupBox1 = new GroupBox();
            cbxLoaiDocGia = new ComboBox();
            dtpngaysinh = new DateTimePicker();
            dtpngayhethan = new DateTimePicker();
            dtpngaylapthe = new DateTimePicker();
            txtsodienthoai = new TextBox();
            txtidaccount = new TextBox();
            txtemail = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTenDocGia = new TextBox();
            txtdiachi = new TextBox();
            txtMaDocGia = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvLichSuMuonTra = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSuMuonTra).BeginInit();
            SuspendLayout();
            // 
            // btnUndo
            // 
            btnUndo.BackColor = Color.Transparent;
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(728, 697);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(54, 29);
            btnUndo.TabIndex = 51;
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Transparent;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(672, 697);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(54, 29);
            btnXoa.TabIndex = 50;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Transparent;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(616, 697);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(54, 29);
            btnSua.TabIndex = 49;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Transparent;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(784, 697);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(54, 29);
            btnLuu.TabIndex = 71;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbxLoaiDocGia);
            groupBox1.Controls.Add(dtpngaysinh);
            groupBox1.Controls.Add(dtpngayhethan);
            groupBox1.Controls.Add(dtpngaylapthe);
            groupBox1.Controls.Add(txtsodienthoai);
            groupBox1.Controls.Add(txtidaccount);
            groupBox1.Controls.Add(txtemail);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenDocGia);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txtMaDocGia);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox1.Location = new Point(39, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(787, 357);
            groupBox1.TabIndex = 72;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin độc giả";
            // 
            // cbxLoaiDocGia
            // 
            cbxLoaiDocGia.Enabled = false;
            cbxLoaiDocGia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxLoaiDocGia.FormattingEnabled = true;
            cbxLoaiDocGia.Location = new Point(563, 172);
            cbxLoaiDocGia.Name = "cbxLoaiDocGia";
            cbxLoaiDocGia.Size = new Size(187, 36);
            cbxLoaiDocGia.TabIndex = 92;
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.Enabled = false;
            dtpngaysinh.Font = new Font("Segoe UI", 12F);
            dtpngaysinh.Format = DateTimePickerFormat.Short;
            dtpngaysinh.Location = new Point(174, 172);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(185, 34);
            dtpngaysinh.TabIndex = 91;
            // 
            // dtpngayhethan
            // 
            dtpngayhethan.Enabled = false;
            dtpngayhethan.Font = new Font("Segoe UI", 12F);
            dtpngayhethan.Format = DateTimePickerFormat.Short;
            dtpngayhethan.Location = new Point(565, 112);
            dtpngayhethan.Name = "dtpngayhethan";
            dtpngayhethan.Size = new Size(185, 34);
            dtpngayhethan.TabIndex = 90;
            // 
            // dtpngaylapthe
            // 
            dtpngaylapthe.CustomFormat = "";
            dtpngaylapthe.Enabled = false;
            dtpngaylapthe.Font = new Font("Segoe UI", 12F);
            dtpngaylapthe.Format = DateTimePickerFormat.Short;
            dtpngaylapthe.Location = new Point(565, 52);
            dtpngaylapthe.Name = "dtpngaylapthe";
            dtpngaylapthe.Size = new Size(185, 34);
            dtpngaylapthe.TabIndex = 89;
            // 
            // txtsodienthoai
            // 
            txtsodienthoai.BorderStyle = BorderStyle.FixedSingle;
            txtsodienthoai.Font = new Font("Segoe UI", 12F);
            txtsodienthoai.Location = new Point(565, 294);
            txtsodienthoai.Name = "txtsodienthoai";
            txtsodienthoai.ReadOnly = true;
            txtsodienthoai.Size = new Size(185, 34);
            txtsodienthoai.TabIndex = 88;
            // 
            // txtidaccount
            // 
            txtidaccount.BorderStyle = BorderStyle.FixedSingle;
            txtidaccount.Font = new Font("Segoe UI", 12F);
            txtidaccount.Location = new Point(565, 234);
            txtidaccount.Name = "txtidaccount";
            txtidaccount.ReadOnly = true;
            txtidaccount.Size = new Size(185, 34);
            txtidaccount.TabIndex = 87;
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Font = new Font("Segoe UI", 12F);
            txtemail.Location = new Point(174, 292);
            txtemail.Name = "txtemail";
            txtemail.ReadOnly = true;
            txtemail.Size = new Size(185, 34);
            txtemail.TabIndex = 86;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(40, 52);
            label11.Name = "label11";
            label11.Size = new Size(112, 28);
            label11.TabIndex = 85;
            label11.Text = "Mã độc giả";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(418, 232);
            label10.Name = "label10";
            label10.Size = new Size(106, 28);
            label10.TabIndex = 84;
            label10.Text = "IDAccount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(418, 172);
            label9.Name = "label9";
            label9.Size = new Size(121, 28);
            label9.TabIndex = 83;
            label9.Text = "Loại độc giả";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(418, 112);
            label8.Name = "label8";
            label8.Size = new Size(135, 28);
            label8.TabIndex = 82;
            label8.Text = "Ngày hết hạn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(418, 52);
            label7.Name = "label7";
            label7.Size = new Size(128, 28);
            label7.TabIndex = 81;
            label7.Text = "Ngày lập thẻ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(418, 292);
            label6.Name = "label6";
            label6.Size = new Size(133, 28);
            label6.TabIndex = 80;
            label6.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(40, 292);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 79;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(40, 232);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 78;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(40, 172);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 77;
            label2.Text = "Ngày sinh";
            // 
            // txtTenDocGia
            // 
            txtTenDocGia.BorderStyle = BorderStyle.FixedSingle;
            txtTenDocGia.Font = new Font("Segoe UI", 12F);
            txtTenDocGia.Location = new Point(174, 112);
            txtTenDocGia.Name = "txtTenDocGia";
            txtTenDocGia.ReadOnly = true;
            txtTenDocGia.Size = new Size(185, 34);
            txtTenDocGia.TabIndex = 76;
            // 
            // txtdiachi
            // 
            txtdiachi.BorderStyle = BorderStyle.FixedSingle;
            txtdiachi.Font = new Font("Segoe UI", 12F);
            txtdiachi.Location = new Point(174, 232);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.ReadOnly = true;
            txtdiachi.Size = new Size(185, 34);
            txtdiachi.TabIndex = 75;
            // 
            // txtMaDocGia
            // 
            txtMaDocGia.BorderStyle = BorderStyle.FixedSingle;
            txtMaDocGia.Font = new Font("Segoe UI", 12F);
            txtMaDocGia.Location = new Point(174, 52);
            txtMaDocGia.Name = "txtMaDocGia";
            txtMaDocGia.ReadOnly = true;
            txtMaDocGia.Size = new Size(185, 34);
            txtMaDocGia.TabIndex = 74;
            txtMaDocGia.TextChanged += txtMaDocGia_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(40, 112);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 73;
            label1.Text = "Tên độc giả";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dgvLichSuMuonTra);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            groupBox2.Location = new Point(38, 404);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(788, 275);
            groupBox2.TabIndex = 73;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lịch sử mượn trả";
            // 
            // dgvLichSuMuonTra
            // 
            dgvLichSuMuonTra.AllowUserToDeleteRows = false;
            dgvLichSuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLichSuMuonTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLichSuMuonTra.ColumnHeadersHeight = 30;
            dgvLichSuMuonTra.Location = new Point(29, 57);
            dgvLichSuMuonTra.Name = "dgvLichSuMuonTra";
            dgvLichSuMuonTra.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLichSuMuonTra.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLichSuMuonTra.RowHeadersWidth = 60;
            dgvLichSuMuonTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichSuMuonTra.Size = new Size(734, 195);
            dgvLichSuMuonTra.TabIndex = 53;
            // 
            // chitietdocgia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(864, 749);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLuu);
            Controls.Add(btnUndo);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Name = "chitietdocgia";
            Load += chitietdocgia_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLichSuMuonTra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUndo;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLuu;
        private GroupBox groupBox1;
        private ComboBox cbxLoaiDocGia;
        private DateTimePicker dtpngaysinh;
        private DateTimePicker dtpngayhethan;
        private DateTimePicker dtpngaylapthe;
        private TextBox txtsodienthoai;
        private TextBox txtidaccount;
        private TextBox txtemail;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTenDocGia;
        private TextBox txtdiachi;
        private TextBox txtMaDocGia;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvLichSuMuonTra;
    }
}
