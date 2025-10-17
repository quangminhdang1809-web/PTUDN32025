namespace PTUDN32025
{
    partial class frmdangnhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangnhap));
            contextMenuStrip1 = new ContextMenuStrip(components);
            txttendangnhap = new TextBox();
            txtmatkhau = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btndangnhap = new Button();
            btndong = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            chkxemmk = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txttendangnhap
            // 
            txttendangnhap.BackColor = Color.White;
            txttendangnhap.BorderStyle = BorderStyle.None;
            txttendangnhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txttendangnhap.ForeColor = SystemColors.ActiveCaptionText;
            txttendangnhap.Location = new Point(125, 350);
            txttendangnhap.Margin = new Padding(5, 5, 5, 5);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(358, 39);
            txttendangnhap.TabIndex = 1;
            txttendangnhap.Text = "Tên đăng nhập";
            txttendangnhap.MouseClick += txttendangnhap_MouseClick;
            txttendangnhap.TextChanged += txttendangnhap_TextChanged;
            txttendangnhap.MouseEnter += txttendangnhap_MouseEnter;
            // 
            // txtmatkhau
            // 
            txtmatkhau.BackColor = Color.White;
            txtmatkhau.BorderStyle = BorderStyle.None;
            txtmatkhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtmatkhau.ForeColor = SystemColors.ActiveCaptionText;
            txtmatkhau.Location = new Point(125, 488);
            txtmatkhau.Margin = new Padding(5, 5, 5, 5);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(358, 39);
            txtmatkhau.TabIndex = 2;
            txtmatkhau.Text = "Mật khẩu";
            txtmatkhau.MouseClick += txtmatkhau_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(172, 120);
            pictureBox1.Margin = new Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(65, 350);
            pictureBox2.Margin = new Padding(5, 5, 5, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(65, 488);
            pictureBox3.Margin = new Padding(5, 5, 5, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // btndangnhap
            // 
            btndangnhap.BackColor = Color.SteelBlue;
            btndangnhap.FlatStyle = FlatStyle.Popup;
            btndangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btndangnhap.ForeColor = SystemColors.ActiveCaptionText;
            btndangnhap.Location = new Point(65, 605);
            btndangnhap.Margin = new Padding(5, 5, 5, 5);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(418, 72);
            btndangnhap.TabIndex = 6;
            btndangnhap.Text = "Đăng nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // btndong
            // 
            btndong.BackColor = Color.SteelBlue;
            btndong.BackgroundImageLayout = ImageLayout.None;
            btndong.FlatAppearance.MouseDownBackColor = Color.Red;
            btndong.FlatAppearance.MouseOverBackColor = Color.Red;
            btndong.FlatStyle = FlatStyle.Flat;
            btndong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btndong.ForeColor = Color.White;
            btndong.Location = new Point(471, 0);
            btndong.Margin = new Padding(5, 5, 5, 5);
            btndong.Name = "btndong";
            btndong.Size = new Size(68, 48);
            btndong.TabIndex = 9;
            btndong.Text = "x";
            btndong.UseVisualStyleBackColor = false;
            btndong.Click += btndong_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DimGray;
            pictureBox4.Location = new Point(125, 398);
            pictureBox4.Margin = new Padding(5, 5, 5, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(325, 3);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.DimGray;
            pictureBox5.Location = new Point(125, 536);
            pictureBox5.Margin = new Padding(5, 5, 5, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(325, 3);
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btndong);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 48);
            panel1.TabIndex = 12;
            // 
            // chkxemmk
            // 
            chkxemmk.AutoSize = true;
            chkxemmk.ForeColor = SystemColors.ActiveCaptionText;
            chkxemmk.Location = new Point(176, 335);
            chkxemmk.Name = "chkxemmk";
            chkxemmk.Size = new Size(148, 24);
            chkxemmk.TabIndex = 13;
            chkxemmk.Text = "Hiển thị mật khẩu";
            chkxemmk.UseVisualStyleBackColor = true;
            chkxemmk.CheckedChanged += chkxemmk_CheckedChanged;
            // 
            // frmdangnhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(540, 766);
            Controls.Add(panel1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(btndangnhap);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtmatkhau);
            Controls.Add(txttendangnhap);
            ForeColor = SystemColors.AppWorkspace;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 5, 5, 5);
            Name = "frmdangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmdangnhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox txttendangnhap;
        private TextBox txtmatkhau;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btndangnhap;
        private Button btndong;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Panel panel1;
        private CheckBox chkxemmk;
    }
}
