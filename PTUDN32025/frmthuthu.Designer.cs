namespace PTUDN32025
{
    partial class frmthuthu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmthuthu));
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new Label();
            btndangxuat = new Button();
            panel1 = new Panel();
            btn4 = new Button();
            btnquanlysach = new Button();
            btn6 = new Button();
            btndocgia = new Button();
            btn5 = new Button();
            btn1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panelMain = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(113, 620);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 7;
            label3.Text = "Đăng xuất";
            label3.Click += label3_Click;
            // 
            // btndangxuat
            // 
            btndangxuat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btndangxuat.BackColor = Color.Transparent;
            btndangxuat.BackgroundImageLayout = ImageLayout.None;
            btndangxuat.Cursor = Cursors.Hand;
            btndangxuat.FlatAppearance.BorderColor = Color.White;
            btndangxuat.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btndangxuat.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btndangxuat.FlatStyle = FlatStyle.Flat;
            btndangxuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btndangxuat.ForeColor = Color.White;
            btndangxuat.Image = (Image)resources.GetObject("btndangxuat.Image");
            btndangxuat.Location = new Point(25, 612);
            btndangxuat.Name = "btndangxuat";
            btndangxuat.Size = new Size(59, 48);
            btndangxuat.TabIndex = 6;
            btndangxuat.UseVisualStyleBackColor = false;
            btndangxuat.Click += btndangxuat_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btnquanlysach);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btndangxuat);
            panel1.Controls.Add(btndocgia);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 734);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint_1;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Transparent;
            btn4.BackgroundImageLayout = ImageLayout.None;
            btn4.FlatAppearance.BorderColor = Color.White;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btn4.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn4.ForeColor = Color.White;
            btn4.Image = (Image)resources.GetObject("btn4.Image");
            btn4.ImageAlign = ContentAlignment.MiddleLeft;
            btn4.Location = new Point(31, 347);
            btn4.Name = "btn4";
            btn4.Size = new Size(192, 45);
            btn4.TabIndex = 3;
            btn4.Text = "     Mượn sách";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btnquanlysach
            // 
            btnquanlysach.BackColor = Color.Transparent;
            btnquanlysach.BackgroundImageLayout = ImageLayout.None;
            btnquanlysach.FlatAppearance.BorderColor = Color.White;
            btnquanlysach.FlatAppearance.BorderSize = 0;
            btnquanlysach.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btnquanlysach.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btnquanlysach.FlatStyle = FlatStyle.Flat;
            btnquanlysach.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnquanlysach.ForeColor = Color.White;
            btnquanlysach.Image = (Image)resources.GetObject("btnquanlysach.Image");
            btnquanlysach.ImageAlign = ContentAlignment.MiddleLeft;
            btnquanlysach.Location = new Point(31, 225);
            btnquanlysach.Name = "btnquanlysach";
            btnquanlysach.Size = new Size(192, 45);
            btnquanlysach.TabIndex = 1;
            btnquanlysach.Text = "        Quản lý sách";
            btnquanlysach.UseVisualStyleBackColor = false;
            btnquanlysach.Click += btnquanlysach_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Transparent;
            btn6.BackgroundImageLayout = ImageLayout.None;
            btn6.FlatAppearance.BorderColor = Color.White;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btn6.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn6.ForeColor = Color.White;
            btn6.Image = (Image)resources.GetObject("btn6.Image");
            btn6.ImageAlign = ContentAlignment.MiddleLeft;
            btn6.Location = new Point(31, 475);
            btn6.Name = "btn6";
            btn6.Size = new Size(192, 45);
            btn6.TabIndex = 5;
            btn6.Text = "Báo cáo";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btndocgia
            // 
            btndocgia.BackColor = Color.Transparent;
            btndocgia.BackgroundImageLayout = ImageLayout.None;
            btndocgia.FlatAppearance.BorderColor = Color.White;
            btndocgia.FlatAppearance.BorderSize = 0;
            btndocgia.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btndocgia.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btndocgia.FlatStyle = FlatStyle.Flat;
            btndocgia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btndocgia.ForeColor = Color.White;
            btndocgia.Image = (Image)resources.GetObject("btndocgia.Image");
            btndocgia.ImageAlign = ContentAlignment.MiddleLeft;
            btndocgia.Location = new Point(31, 287);
            btndocgia.Name = "btndocgia";
            btndocgia.Size = new Size(192, 45);
            btndocgia.TabIndex = 2;
            btndocgia.Text = "Độc giả";
            btndocgia.UseVisualStyleBackColor = false;
            btndocgia.Click += btndocgia_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Transparent;
            btn5.BackgroundImageLayout = ImageLayout.None;
            btn5.FlatAppearance.BorderColor = Color.White;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btn5.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn5.ForeColor = Color.White;
            btn5.Image = (Image)resources.GetObject("btn5.Image");
            btn5.ImageAlign = ContentAlignment.MiddleLeft;
            btn5.Location = new Point(31, 408);
            btn5.Name = "btn5";
            btn5.Size = new Size(192, 45);
            btn5.TabIndex = 4;
            btn5.Text = "Trả sách";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Transparent;
            btn1.BackgroundImageLayout = ImageLayout.None;
            btn1.FlatAppearance.BorderColor = Color.White;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btn1.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn1.ForeColor = SystemColors.Window;
            btn1.Image = (Image)resources.GetObject("btn1.Image");
            btn1.ImageAlign = ContentAlignment.MiddleLeft;
            btn1.Location = new Point(31, 160);
            btn1.Name = "btn1";
            btn1.Size = new Size(192, 45);
            btn1.TabIndex = 0;
            btn1.Text = "    Trang chủ";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(806, 0);
            label1.Name = "label1";
            label1.Size = new Size(32, 38);
            label1.TabIndex = 0;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 23);
            label2.Name = "label2";
            label2.Size = new Size(295, 31);
            label2.TabIndex = 1;
            label2.Text = "Hệ thống quản lý thư viện";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(262, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 71);
            panel2.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(262, 71);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(838, 663);
            panelMain.TabIndex = 9;
            panelMain.Paint += panelMain_Paint;
            // 
            // frmthuthu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 734);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "frmthuthu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thủ thư";
            WindowState = FormWindowState.Maximized;
            Load += frmmainform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Button btndangxuat;
        private Label label3;
        private Button btn4;
        private Button btndocgia;
        private Button btnquanlysach;
        private Button btn1;
        private PictureBox pictureBox1;
        private Button btn6;
        private Button btn5;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panelMain;
    }
}