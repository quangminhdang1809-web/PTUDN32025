
namespace PTUDN32025
{
    partial class quanlysach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlysach));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtTimKiem = new TextBox();
            btnthemsach = new Button();
            panel3 = new Panel();
            btnTimKiem = new Button();
            cbxTheLoai = new ComboBox();
            dgvxemsach = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvxemsach).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = SystemColors.Window;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(202, 56);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(835, 34);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtSearch_TextChanged;
            // 
            // btnthemsach
            // 
            btnthemsach.BackColor = Color.Transparent;
            btnthemsach.FlatAppearance.BorderSize = 0;
            btnthemsach.FlatStyle = FlatStyle.Flat;
            btnthemsach.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnthemsach.ForeColor = SystemColors.ButtonHighlight;
            btnthemsach.Image = (Image)resources.GetObject("btnthemsach.Image");
            btnthemsach.Location = new Point(1341, 41);
            btnthemsach.Name = "btnthemsach";
            btnthemsach.Size = new Size(83, 55);
            btnthemsach.TabIndex = 6;
            btnthemsach.UseVisualStyleBackColor = false;
            btnthemsach.Click += btnthemsach_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(cbxTheLoai);
            panel3.Controls.Add(txtTimKiem);
            panel3.Controls.Add(btnthemsach);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1607, 123);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Transparent;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnTimKiem.ForeColor = SystemColors.ButtonHighlight;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(1256, 44);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(70, 49);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // cbxTheLoai
            // 
            cbxTheLoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cbxTheLoai.FormattingEnabled = true;
            cbxTheLoai.Location = new Point(1058, 55);
            cbxTheLoai.Name = "cbxTheLoai";
            cbxTheLoai.Size = new Size(172, 36);
            cbxTheLoai.TabIndex = 7;
            cbxTheLoai.SelectedIndexChanged += cbxTheLoai_SelectedIndexChanged;
            // 
            // dgvxemsach
            // 
            dgvxemsach.AllowUserToAddRows = false;
            dgvxemsach.AllowUserToDeleteRows = false;
            dgvxemsach.AllowUserToResizeColumns = false;
            dgvxemsach.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dgvxemsach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvxemsach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvxemsach.BackgroundColor = Color.WhiteSmoke;
            dgvxemsach.BorderStyle = BorderStyle.Fixed3D;
            dgvxemsach.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvxemsach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvxemsach.ColumnHeadersHeight = 80;
            dgvxemsach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvxemsach.DefaultCellStyle = dataGridViewCellStyle3;
            dgvxemsach.EnableHeadersVisualStyles = false;
            dgvxemsach.Location = new Point(161, 148);
            dgvxemsach.Name = "dgvxemsach";
            dgvxemsach.RowHeadersWidth = 100;
            dgvxemsach.RowTemplate.Height = 100;
            dgvxemsach.Size = new Size(1337, 858);
            dgvxemsach.TabIndex = 8;
            dgvxemsach.CellClick += dgvxemsach_CellClick;
            dgvxemsach.CellContentClick += dataGridView1_CellContentClick;
            dgvxemsach.CellDoubleClick += dgvxemsach_CellDoubleClick;
            // 
            // quanlysach
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(dgvxemsach);
            Controls.Add(panel3);
            Name = "quanlysach";
            Size = new Size(1607, 1064);
            Load += quanlysach_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvxemsach).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTimKiem;
        private Button btnthemsach;
        private Panel panel3;
        private DataGridView dgvxemsach;
        private Button btnTimKiem;
        private ComboBox cbxTheLoai;
    }
}
