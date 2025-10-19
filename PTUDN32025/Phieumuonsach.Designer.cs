namespace PTUDN32025
{
    partial class FrmMuonSach
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
            panel1 = new Panel();
            panel2 = new Panel();
            lblMaDG = new Label();
            lblHoTen = new Label();
            lblEmail = new Label();
            lblSDT = new Label();
            lblNgayHetHan = new Label();
            txtMaDG = new TextBox();
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
                SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(txtMaDG);
            panel1.Controls.Add(lblNgayHetHan);
            panel1.Controls.Add(lblSDT);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblHoTen);
            panel1.Controls.Add(lblMaDG);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1207, 278);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(0, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(1213, 296);
            panel2.TabIndex = 1;
            // 
            // lblMaDG
            // 
            lblMaDG.AutoSize = true;
            lblMaDG.Location = new Point(38, 27);
            lblMaDG.Name = "lblMaDG";
            lblMaDG.Size = new Size(101, 25);
            lblMaDG.TabIndex = 0;
            lblMaDG.Text = "Mã độc giả";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(38, 68);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(67, 25);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ Tên";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(38, 117);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(38, 170);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(44, 25);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "SĐT";
            // 
            // lblNgayHetHan
            // 
            lblNgayHetHan.AutoSize = true;
            lblNgayHetHan.Location = new Point(38, 226);
            lblNgayHetHan.Name = "lblNgayHetHan";
            lblNgayHetHan.Size = new Size(118, 25);
            lblNgayHetHan.TabIndex = 4;
            lblNgayHetHan.Text = "Ngày hết hạn";
            // 
            // txtMaDG
            // 
            txtMaDG.Location = new Point(233, 28);
            txtMaDG.Name = "txtMaDG";
            txtMaDG.Size = new Size(150, 31);
            txtMaDG.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(233, 68);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(150, 31);
            txtHoTen.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(233, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 7;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(233, 167);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(150, 31);
            txtSDT.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(233, 220);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1210, 245);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã sách";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên sách";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tác giả";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng ";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Ngày mượn";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ngày hẹn trả";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.HeaderText = "Tình trạng";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // FrmMuonSach
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 678);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmMuonSach";
            Text = "Phiếu mượn sách";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            this.Load += new System.EventHandler(this.FrmMuonSach_Load);

        }

        #endregion

        private Panel panel1;
        private Label lblMaDG;
        private Panel panel2;
        private TextBox textBox5;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtHoTen;
        private TextBox txtMaDG;
        private Label lblNgayHetHan;
        private Label lblSDT;
        private Label lblEmail;
        private Label lblHoTen;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}