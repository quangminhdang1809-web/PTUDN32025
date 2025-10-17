namespace PTUDN32025
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addABookToolStripMenuItem = new ToolStripMenuItem();
            findABookToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addNewStudentToolStripMenuItem = new ToolStripMenuItem();
            viewReaderInFoToolStripMenuItem = new ToolStripMenuItem();
            issueReturnToolStripMenuItem = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            completeBookDetailToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem, issueReturnToolStripMenuItem, reportToolStripMenuItem, accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1257, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addABookToolStripMenuItem, findABookToolStripMenuItem });
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(101, 29);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addABookToolStripMenuItem
            // 
            addABookToolStripMenuItem.Image = (Image)resources.GetObject("addABookToolStripMenuItem.Image");
            addABookToolStripMenuItem.Name = "addABookToolStripMenuItem";
            addABookToolStripMenuItem.Size = new Size(234, 34);
            addABookToolStripMenuItem.Text = "Add New Book";
            // 
            // findABookToolStripMenuItem
            // 
            findABookToolStripMenuItem.Image = (Image)resources.GetObject("findABookToolStripMenuItem.Image");
            findABookToolStripMenuItem.Name = "findABookToolStripMenuItem";
            findABookToolStripMenuItem.Size = new Size(234, 34);
            findABookToolStripMenuItem.Text = "Find Books";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewStudentToolStripMenuItem, viewReaderInFoToolStripMenuItem });
            studentToolStripMenuItem.Image = (Image)resources.GetObject("studentToolStripMenuItem.Image");
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(106, 29);
            studentToolStripMenuItem.Text = "Reader";
            // 
            // addNewStudentToolStripMenuItem
            // 
            addNewStudentToolStripMenuItem.Image = (Image)resources.GetObject("addNewStudentToolStripMenuItem.Image");
            addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            addNewStudentToolStripMenuItem.Size = new Size(250, 34);
            addNewStudentToolStripMenuItem.Text = "Add New Reader";
            // 
            // viewReaderInFoToolStripMenuItem
            // 
            viewReaderInFoToolStripMenuItem.Image = (Image)resources.GetObject("viewReaderInFoToolStripMenuItem.Image");
            viewReaderInFoToolStripMenuItem.Name = "viewReaderInFoToolStripMenuItem";
            viewReaderInFoToolStripMenuItem.Size = new Size(250, 34);
            viewReaderInFoToolStripMenuItem.Text = "View Reader InFo";
            // 
            // issueReturnToolStripMenuItem
            // 
            issueReturnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { issueBooksToolStripMenuItem, returnBooksToolStripMenuItem });
            issueReturnToolStripMenuItem.Name = "issueReturnToolStripMenuItem";
            issueReturnToolStripMenuItem.Size = new Size(126, 29);
            issueReturnToolStripMenuItem.Text = "Issue/Return";
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.Image = (Image)resources.GetObject("issueBooksToolStripMenuItem.Image");
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Size = new Size(270, 34);
            issueBooksToolStripMenuItem.Text = "Issue Books";
            issueBooksToolStripMenuItem.Click += issueBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.Image = (Image)resources.GetObject("returnBooksToolStripMenuItem.Image");
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(270, 34);
            returnBooksToolStripMenuItem.Text = "Return Books";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { completeBookDetailToolStripMenuItem });
            reportToolStripMenuItem.Image = (Image)resources.GetObject("reportToolStripMenuItem.Image");
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(105, 29);
            reportToolStripMenuItem.Text = "Report";
            // 
            // completeBookDetailToolStripMenuItem
            // 
            completeBookDetailToolStripMenuItem.Name = "completeBookDetailToolStripMenuItem";
            completeBookDetailToolStripMenuItem.Size = new Size(295, 34);
            completeBookDetailToolStripMenuItem.Text = "Complete Book Details";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changePasswordToolStripMenuItem, logOutToolStripMenuItem });
            accountToolStripMenuItem.Image = (Image)resources.GetObject("accountToolStripMenuItem.Image");
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(117, 29);
            accountToolStripMenuItem.Text = "Account";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(254, 34);
            changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(254, 34);
            logOutToolStripMenuItem.Text = "Log Out";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1257, 703);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addABookToolStripMenuItem;
        private ToolStripMenuItem findABookToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addNewStudentToolStripMenuItem;
        private ToolStripMenuItem viewReaderInFoToolStripMenuItem;
        private ToolStripMenuItem issueReturnToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem completeBookDetailToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}
