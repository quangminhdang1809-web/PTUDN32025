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
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            btndangxuat = new Button();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1100, 35);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 5);
            label2.Name = "label2";
            label2.Size = new Size(220, 23);
            label2.TabIndex = 1;
            label2.Text = "Hệ thống quản lý thư viện";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1074, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 28);
            label1.TabIndex = 0;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btn1
            // 
            btn1.BackColor = Color.Transparent;
            btn1.BackgroundImageLayout = ImageLayout.None;
            btn1.FlatAppearance.BorderColor = Color.White;
            btn1.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btn1.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn1.ForeColor = Color.White;
            btn1.Location = new Point(13, 148);
            btn1.Name = "btn1";
            btn1.Size = new Size(200, 45);
            btn1.TabIndex = 0;
            btn1.Text = "Trang chủ";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Transparent;
            btn2.BackgroundImageLayout = ImageLayout.None;
            btn2.FlatAppearance.BorderColor = Color.White;
            btn2.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btn2.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn2.ForeColor = Color.White;
            btn2.Location = new Point(13, 209);
            btn2.Name = "btn2";
            btn2.Size = new Size(200, 45);
            btn2.TabIndex = 1;
            btn2.Text = "Quản lý sách";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnqlsach_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Transparent;
            btn3.BackgroundImageLayout = ImageLayout.None;
            btn3.FlatAppearance.BorderColor = Color.White;
            btn3.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btn3.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn3.ForeColor = Color.White;
            btn3.Location = new Point(13, 271);
            btn3.Name = "btn3";
            btn3.Size = new Size(200, 45);
            btn3.TabIndex = 2;
            btn3.Text = "Độc giả";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Transparent;
            btn4.BackgroundImageLayout = ImageLayout.None;
            btn4.FlatAppearance.BorderColor = Color.White;
            btn4.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btn4.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn4.ForeColor = Color.White;
            btn4.Location = new Point(13, 331);
            btn4.Name = "btn4";
            btn4.Size = new Size(200, 45);
            btn4.TabIndex = 3;
            btn4.Text = "Mượn sách";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Transparent;
            btn5.BackgroundImageLayout = ImageLayout.None;
            btn5.FlatAppearance.BorderColor = Color.White;
            btn5.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btn5.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn5.ForeColor = Color.White;
            btn5.Location = new Point(13, 395);
            btn5.Name = "btn5";
            btn5.Size = new Size(200, 45);
            btn5.TabIndex = 4;
            btn5.Text = "Trả sách";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Transparent;
            btn6.BackgroundImageLayout = ImageLayout.None;
            btn6.FlatAppearance.BorderColor = Color.White;
            btn6.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            btn6.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(13, 458);
            btn6.Name = "btn6";
            btn6.Size = new Size(200, 45);
            btn6.TabIndex = 5;
            btn6.Text = "Thống kê báo cáo";
            btn6.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btndangxuat);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 565);
            panel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(57, 525);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 7;
            label3.Text = "Đăng xuất";
            // 
            // btndangxuat
            // 
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
            btndangxuat.Location = new Point(12, 517);
            btndangxuat.Name = "btndangxuat";
            btndangxuat.Size = new Size(35, 35);
            btndangxuat.TabIndex = 6;
            btndangxuat.UseVisualStyleBackColor = false;
            btndangxuat.Click += btndangxuat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmthuthu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmthuthu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmmainform";
            Load += frmmainform_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private Label label1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btndangxuat;
        private Label label3;
    }
}