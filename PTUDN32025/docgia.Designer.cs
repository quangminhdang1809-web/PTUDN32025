namespace PTUDN32025
{
    partial class ucdocgia
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
            this.Load += new System.EventHandler(this.ucdocgia_Load);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucdocgia));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtTimKiem = new TextBox();
            btnthemdocgia = new Button();
            panel1 = new Panel();
            btnTimKiem = new Button();
            cbxLoaiDocGia = new ComboBox();
            panel2 = new Panel();
            dgvxemdocgia = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvxemdocgia).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(212, 63);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(835, 34);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtSearch_TextChanged;
            // 
            // btnthemdocgia
            // 
            btnthemdocgia.BackColor = Color.Transparent;
            btnthemdocgia.FlatAppearance.BorderSize = 0;
            btnthemdocgia.FlatStyle = FlatStyle.Flat;
            btnthemdocgia.Image = (Image)resources.GetObject("btnthemdocgia.Image");
            btnthemdocgia.Location = new Point(1376, 41);
            btnthemdocgia.Margin = new Padding(4);
            btnthemdocgia.Name = "btnthemdocgia";
            btnthemdocgia.Size = new Size(92, 65);
            btnthemdocgia.TabIndex = 2;
            btnthemdocgia.UseVisualStyleBackColor = false;
            btnthemdocgia.Click += btnthemdocgia_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(cbxLoaiDocGia);
            panel1.Controls.Add(btnthemdocgia);
            panel1.Controls.Add(txtTimKiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1731, 128);
            panel1.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Transparent;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnTimKiem.ForeColor = SystemColors.ButtonHighlight;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(1280, 50);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(70, 49);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cbxLoaiDocGia
            // 
            cbxLoaiDocGia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxLoaiDocGia.FormattingEnabled = true;
            cbxLoaiDocGia.Location = new Point(1078, 63);
            cbxLoaiDocGia.Name = "cbxLoaiDocGia";
            cbxLoaiDocGia.Size = new Size(187, 36);
            cbxLoaiDocGia.TabIndex = 3;
            cbxLoaiDocGia.SelectedIndexChanged += cbxLoaiDocGia_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dgvxemdocgia);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(1731, 843);
            panel2.TabIndex = 6;
            // 
            // dgvxemdocgia
            // 
            dgvxemdocgia.AllowUserToAddRows = false;
            dgvxemdocgia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dgvxemdocgia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvxemdocgia.BackgroundColor = Color.WhiteSmoke;
            dgvxemdocgia.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvxemdocgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvxemdocgia.ColumnHeadersHeight = 80;
            dgvxemdocgia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvxemdocgia.Location = new Point(181, 31);
            dgvxemdocgia.Margin = new Padding(4);
            dgvxemdocgia.Name = "dgvxemdocgia";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvxemdocgia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvxemdocgia.RowHeadersWidth = 100;
            dgvxemdocgia.RowTemplate.Height = 100;
            dgvxemdocgia.Size = new Size(1430, 700);
            dgvxemdocgia.TabIndex = 96;
            dgvxemdocgia.CellDoubleClick += dgvxemdocgia_CellDoubleClick;
            // 
            // ucdocgia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.8F);
            Margin = new Padding(4);
            Name = "ucdocgia";
            Size = new Size(1731, 971);
            Load += ucdocgia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvxemdocgia).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button btngiaotrinh;
        private Button button2;
        private Button button3;
        private TextBox txtTimKiem;
        private Button btnthemdocgia;
        private Panel panel1;
        private Panel panel2;
        private Button btnluu;
        private DateTimePicker dateTimePicker3;
        private DataGridView dgvxemdocgia;
        private ComboBox cbxLoaiDocGia;
        private Button btnTimKiem;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox9;
        private TextBox textBox2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox8;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
    }
}
