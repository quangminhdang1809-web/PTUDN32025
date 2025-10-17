namespace PTUDN32025
{
    partial class chitietsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chitietsach));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pbAnhBia = new PictureBox();
            btnLuu = new Button();
            txtTheLoai = new TextBox();
            label2 = new Label();
            dgvTacGia = new DataGridView();
            txtsoluong = new TextBox();
            label6 = new Label();
            dtpnamxb = new DateTimePicker();
            btnTrove = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            label4 = new Label();
            label3 = new Label();
            txtnxb = new TextBox();
            txtTenSach = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhBia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTacGia).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pbAnhBia);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(txtTheLoai);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dgvTacGia);
            panel1.Controls.Add(txtsoluong);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtpnamxb);
            panel1.Controls.Add(btnTrove);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtnxb);
            panel1.Controls.Add(txtTenSach);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(735, 836);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // pbAnhBia
            // 
            pbAnhBia.Location = new Point(248, 31);
            pbAnhBia.Name = "pbAnhBia";
            pbAnhBia.Size = new Size(273, 294);
            pbAnhBia.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnhBia.TabIndex = 61;
            pbAnhBia.TabStop = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Transparent;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.Location = new Point(651, 765);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(54, 29);
            btnLuu.TabIndex = 60;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtTheLoai
            // 
            txtTheLoai.BorderStyle = BorderStyle.FixedSingle;
            txtTheLoai.Font = new Font("Segoe UI", 12F);
            txtTheLoai.Location = new Point(210, 422);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.ReadOnly = true;
            txtTheLoai.Size = new Size(390, 34);
            txtTheLoai.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(68, 422);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 43;
            label2.Text = "Thể loại";
            // 
            // dgvTacGia
            // 
            dgvTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTacGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTacGia.ColumnHeadersHeight = 33;
            dgvTacGia.Location = new Point(210, 653);
            dgvTacGia.Name = "dgvTacGia";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTacGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTacGia.RowHeadersWidth = 51;
            dgvTacGia.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTacGia.Size = new Size(392, 86);
            dgvTacGia.TabIndex = 42;
            // 
            // txtsoluong
            // 
            txtsoluong.BorderStyle = BorderStyle.FixedSingle;
            txtsoluong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtsoluong.Location = new Point(210, 584);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.ReadOnly = true;
            txtsoluong.Size = new Size(390, 34);
            txtsoluong.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(68, 590);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 39;
            label6.Text = "Số lượng";
            // 
            // dtpnamxb
            // 
            dtpnamxb.CustomFormat = "yyyy";
            dtpnamxb.Enabled = false;
            dtpnamxb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpnamxb.Format = DateTimePickerFormat.Custom;
            dtpnamxb.Location = new Point(210, 518);
            dtpnamxb.Name = "dtpnamxb";
            dtpnamxb.ShowUpDown = true;
            dtpnamxb.Size = new Size(118, 34);
            dtpnamxb.TabIndex = 37;
            // 
            // btnTrove
            // 
            btnTrove.BackColor = Color.Transparent;
            btnTrove.FlatAppearance.BorderSize = 0;
            btnTrove.FlatStyle = FlatStyle.Flat;
            btnTrove.Image = (Image)resources.GetObject("btnTrove.Image");
            btnTrove.Location = new Point(592, 765);
            btnTrove.Name = "btnTrove";
            btnTrove.Size = new Size(53, 29);
            btnTrove.TabIndex = 36;
            btnTrove.UseVisualStyleBackColor = false;
            btnTrove.Click += btnUndo_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Transparent;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(544, 765);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(51, 29);
            btnXoa.TabIndex = 35;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Transparent;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(484, 765);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(54, 29);
            btnSua.TabIndex = 34;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(64, 518);
            label4.Name = "label4";
            label4.Size = new Size(140, 28);
            label4.TabIndex = 31;
            label4.Text = "Năm xuất bản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(68, 467);
            label3.Name = "label3";
            label3.Size = new Size(51, 28);
            label3.TabIndex = 30;
            label3.Text = "NXB";
            // 
            // txtnxb
            // 
            txtnxb.BorderStyle = BorderStyle.FixedSingle;
            txtnxb.Font = new Font("Segoe UI", 12F);
            txtnxb.Location = new Point(210, 467);
            txtnxb.Name = "txtnxb";
            txtnxb.ReadOnly = true;
            txtnxb.Size = new Size(390, 34);
            txtnxb.TabIndex = 27;
            // 
            // txtTenSach
            // 
            txtTenSach.BorderStyle = BorderStyle.FixedSingle;
            txtTenSach.Font = new Font("Segoe UI", 12F);
            txtTenSach.Location = new Point(210, 377);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.ReadOnly = true;
            txtTenSach.Size = new Size(390, 34);
            txtTenSach.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(68, 377);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 22;
            label1.Text = "Tên sách";
            // 
            // chitietsach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 836);
            Controls.Add(panel1);
            Name = "chitietsach";
            Load += chitietsach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnhBia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTacGia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTrove;
        private Button btnXoa;
        private Button btnSua;
        private Label label4;
        private Label label3;
        private TextBox txtnxb;
        private TextBox txtTenSach;
        private Label label1;
        private TextBox txtsoluong;
        private Label label6;
        private DateTimePicker dtpnamxb;
        private DataGridView dgvTacGia;
        private TextBox txtTheLoai;
        private Label label2;
        private Button btnLuu;
        private PictureBox pbAnhBia;
    }
}
