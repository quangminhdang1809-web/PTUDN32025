namespace PTUDN32025
{
    partial class frmChiTietSach
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
            picAnhBia = new PictureBox();
            btnMuonSach = new Button();
            lblTheLoai = new Label();
            lblTenSach = new Label();
            lblTacGia = new Label();
            lblNamXuatBan = new Label();
            lblNhaXuatBan = new Label();
            btnThoatChiTietSach = new Button();
            lblTinhTrangSach = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)picAnhBia).BeginInit();
            SuspendLayout();
            // 
            // picAnhBia
            // 
            picAnhBia.Location = new Point(86, 100);
            picAnhBia.Name = "picAnhBia";
            picAnhBia.Size = new Size(352, 461);
            picAnhBia.TabIndex = 0;
            picAnhBia.TabStop = false;
            // 
            // btnMuonSach
            // 
            btnMuonSach.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMuonSach.Location = new Point(169, 605);
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Size = new Size(176, 59);
            btnMuonSach.TabIndex = 1;
            btnMuonSach.Text = "Mượn sách";
            btnMuonSach.UseVisualStyleBackColor = true;
            btnMuonSach.Click += btnMuonSach_Click;
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTheLoai.ForeColor = SystemColors.HotTrack;
            lblTheLoai.Location = new Point(513, 32);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(139, 45);
            lblTheLoai.TabIndex = 2;
            lblTheLoai.Text = "Thể loại";
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Font = new Font("Segoe UI", 10.125F);
            lblTenSach.Location = new Point(734, 140);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(116, 37);
            lblTenSach.TabIndex = 3;
            lblTenSach.Text = "Tên sách";
            // 
            // lblTacGia
            // 
            lblTacGia.AutoSize = true;
            lblTacGia.Font = new Font("Segoe UI", 10.125F);
            lblTacGia.Location = new Point(734, 235);
            lblTacGia.Name = "lblTacGia";
            lblTacGia.Size = new Size(98, 37);
            lblTacGia.TabIndex = 3;
            lblTacGia.Text = "Tác giả";
            // 
            // lblNamXuatBan
            // 
            lblNamXuatBan.AutoSize = true;
            lblNamXuatBan.Font = new Font("Segoe UI", 10.125F);
            lblNamXuatBan.Location = new Point(734, 330);
            lblNamXuatBan.Name = "lblNamXuatBan";
            lblNamXuatBan.Size = new Size(183, 37);
            lblNamXuatBan.TabIndex = 3;
            lblNamXuatBan.Text = "Năm xuất bản";
            // 
            // lblNhaXuatBan
            // 
            lblNhaXuatBan.AutoSize = true;
            lblNhaXuatBan.Font = new Font("Segoe UI", 10.125F);
            lblNhaXuatBan.Location = new Point(734, 425);
            lblNhaXuatBan.Name = "lblNhaXuatBan";
            lblNhaXuatBan.Size = new Size(175, 37);
            lblNhaXuatBan.TabIndex = 3;
            lblNhaXuatBan.Text = "Nhà xuất bản";
            lblNhaXuatBan.Click += lblNhaXuatBan_Click;
            // 
            // btnThoatChiTietSach
            // 
            btnThoatChiTietSach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThoatChiTietSach.FlatStyle = FlatStyle.Flat;
            btnThoatChiTietSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoatChiTietSach.ForeColor = Color.Red;
            btnThoatChiTietSach.Location = new Point(1116, -1);
            btnThoatChiTietSach.Name = "btnThoatChiTietSach";
            btnThoatChiTietSach.Size = new Size(64, 46);
            btnThoatChiTietSach.TabIndex = 4;
            btnThoatChiTietSach.Text = "X";
            btnThoatChiTietSach.UseVisualStyleBackColor = true;
            btnThoatChiTietSach.Click += btnThoatChiTietSach_Click;
            // 
            // lblTinhTrangSach
            // 
            lblTinhTrangSach.AutoSize = true;
            lblTinhTrangSach.Font = new Font("Segoe UI", 10.125F);
            lblTinhTrangSach.Location = new Point(734, 520);
            lblTinhTrangSach.Name = "lblTinhTrangSach";
            lblTinhTrangSach.Size = new Size(118, 37);
            lblTinhTrangSach.TabIndex = 3;
            lblTinhTrangSach.Text = "Còn/Hết";
            lblTinhTrangSach.Click += lblTinhTrangSach_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F);
            label1.Location = new Point(523, 140);
            label1.Name = "label1";
            label1.Size = new Size(116, 37);
            label1.TabIndex = 3;
            label1.Text = "Tên sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F);
            label2.Location = new Point(523, 235);
            label2.Name = "label2";
            label2.Size = new Size(98, 37);
            label2.TabIndex = 3;
            label2.Text = "Tác giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F);
            label3.Location = new Point(523, 330);
            label3.Name = "label3";
            label3.Size = new Size(183, 37);
            label3.TabIndex = 3;
            label3.Text = "Năm xuất bản";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F);
            label4.Location = new Point(523, 425);
            label4.Name = "label4";
            label4.Size = new Size(175, 37);
            label4.TabIndex = 3;
            label4.Text = "Nhà xuất bản";
            label4.Click += lblNhaXuatBan_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F);
            label5.Location = new Point(534, 524);
            label5.Name = "label5";
            label5.Size = new Size(118, 37);
            label5.TabIndex = 3;
            label5.Text = "Còn/Hết";
            label5.Click += lblTinhTrangSach_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F);
            label6.Location = new Point(534, 520);
            label6.Name = "label6";
            label6.Size = new Size(138, 37);
            label6.TabIndex = 3;
            label6.Text = "Tình trạng";
            label6.Click += lblTinhTrangSach_Click;
            // 
            // frmChiTietSach
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 721);
            Controls.Add(btnThoatChiTietSach);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblTinhTrangSach);
            Controls.Add(label4);
            Controls.Add(lblNhaXuatBan);
            Controls.Add(label3);
            Controls.Add(lblNamXuatBan);
            Controls.Add(label2);
            Controls.Add(lblTacGia);
            Controls.Add(label1);
            Controls.Add(lblTenSach);
            Controls.Add(lblTheLoai);
            Controls.Add(btnMuonSach);
            Controls.Add(picAnhBia);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmChiTietSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChiTietSach";
            ((System.ComponentModel.ISupportInitialize)picAnhBia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAnhBia;
        private Button btnMuonSach;
        private Label lblTheLoai;
        private Label lblTenSach;
        private Label lblTacGia;
        private Label lblNamXuatBan;
        private Label lblNhaXuatBan;
        private Button btnThoatChiTietSach;
        private Label lblTinhTrangSach;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}