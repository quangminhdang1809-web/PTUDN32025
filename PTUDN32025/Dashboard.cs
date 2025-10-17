namespace PTUDN32025
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Add any initialization code here if needed
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook frm = new IssueBook();   // tạo mới form con
            frm.MdiParent = this;              // set Dashboard làm MDI parent
            frm.Dock = DockStyle.Fill;         // cho form con chiếm toàn bộ vùng MDI
            frm.Show();
        }
    }
}
