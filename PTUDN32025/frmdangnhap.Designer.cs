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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            txttendangnhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txttendangnhap.Location = new Point(73, 199);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(220, 31);
            txttendangnhap.TabIndex = 1;
            txttendangnhap.Text = "Tên đăng nhập";
            txttendangnhap.MouseClick += txttendangnhap_MouseClick;
            txttendangnhap.MouseEnter += txttendangnhap_MouseEnter;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            txtmatkhau.Location = new Point(73, 274);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(220, 31);
            txtmatkhau.TabIndex = 2;
            txtmatkhau.Text = "Mật khẩu";
            txtmatkhau.MouseClick += txtmatkhau_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(36, 270);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // btndangnhap
            // 
            btndangnhap.BackColor = Color.MediumAquamarine;
            btndangnhap.FlatStyle = FlatStyle.Popup;
            btndangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btndangnhap.Location = new Point(36, 343);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(257, 45);
            btndangnhap.TabIndex = 6;
            btndangnhap.Text = "Đăng nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // btndong
            // 
            btndong.BackColor = Color.FromArgb(35, 36, 55);
            btndong.BackgroundImageLayout = ImageLayout.None;
            btndong.FlatStyle = FlatStyle.Popup;
            btndong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btndong.ForeColor = SystemColors.ButtonHighlight;
            btndong.Location = new Point(289, 3);
            btndong.Name = "btndong";
            btndong.Size = new Size(42, 32);
            btndong.TabIndex = 9;
            btndong.Text = "x";
            btndong.UseVisualStyleBackColor = false;
            btndong.Click += btndong_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(68, 243);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(224, 10);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 55);
            ClientSize = new Size(332, 479);
            Controls.Add(pictureBox4);
            Controls.Add(btndong);
            Controls.Add(btndangnhap);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtmatkhau);
            Controls.Add(txttendangnhap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
    }
}
