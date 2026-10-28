using Provident.Foundations.VisualStudio.Win32.UI.ErrorList;
using Provident.Foundations.VisualStudio.Win32.UI.SolutionExplorer;

namespace Provident.Xaml.Verify
{
    partial class MainDialog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDialog));
            OpenMenu = new ToolStripMenuItem();
            MainMenu = new MenuStrip();
            FileMenu = new ToolStripMenuItem();
            FileMenuOpen = new ToolStripMenuItem();
            FileMenuOpenSolution = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            FileMenuOpenProject = new ToolStripMenuItem();
            FileMenuDivA = new ToolStripSeparator();
            FileMenuClose = new ToolStripMenuItem();
            FileMenuDivB = new ToolStripSeparator();
            FileMenuSave = new ToolStripMenuItem();
            FileMenuDivC = new ToolStripSeparator();
            FileMenuExit = new ToolStripMenuItem();
            BuildMenu = new ToolStripMenuItem();
            BuldMenuValidateStyleId = new ToolStripMenuItem();
            MainToolbar = new ToolStrip();
            OpenSolutionButton = new ToolStripButton();
            ValidateXamlButton = new ToolStripButton();
            DivA = new ToolStripSeparator();
            BuildButton = new ToolStripButton();
            SolutionExplorer = new SolutionExplorer();
            SolutionExplorerSplitter = new Splitter();
            ErrorList = new VisualStudioErrorListControl();
            ErrorSplitter = new Splitter();
            MainMenu.SuspendLayout();
            MainToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // OpenMenu
            // 
            OpenMenu.Name = "OpenMenu";
            OpenMenu.Size = new Size(32, 19);
            // 
            // MainMenu
            // 
            MainMenu.AutoSize = false;
            MainMenu.BackColor = Color.FromArgb(28, 28, 28);
            MainMenu.Items.AddRange(new ToolStripItem[] { FileMenu, BuildMenu });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Padding = new Padding(0);
            MainMenu.RenderMode = ToolStripRenderMode.Professional;
            MainMenu.Size = new Size(784, 32);
            MainMenu.Stretch = false;
            MainMenu.TabIndex = 9;
            // 
            // FileMenu
            // 
            FileMenu.BackColor = Color.FromArgb(28, 28, 28);
            FileMenu.DropDownItems.AddRange(new ToolStripItem[] { FileMenuOpen, FileMenuDivA, FileMenuClose, FileMenuDivB, FileMenuSave, FileMenuDivC, FileMenuExit });
            FileMenu.ForeColor = Color.White;
            FileMenu.Name = "FileMenu";
            FileMenu.Size = new Size(37, 32);
            FileMenu.Text = "&File";
            // 
            // FileMenuOpen
            // 
            FileMenuOpen.AutoToolTip = true;
            FileMenuOpen.BackColor = Color.FromArgb(28, 28, 28);
            FileMenuOpen.DropDownItems.AddRange(new ToolStripItem[] { FileMenuOpenSolution, toolStripMenuItem1, FileMenuOpenProject });
            FileMenuOpen.ForeColor = Color.White;
            FileMenuOpen.ImageTransparentColor = Color.Transparent;
            FileMenuOpen.Name = "FileMenuOpen";
            FileMenuOpen.Size = new Size(138, 22);
            FileMenuOpen.Text = "&Open...";
            // 
            // FileMenuOpenSolution
            // 
            FileMenuOpenSolution.BackColor = Color.FromArgb(28, 28, 28);
            FileMenuOpenSolution.ForeColor = Color.White;
            FileMenuOpenSolution.Name = "FileMenuOpenSolution";
            FileMenuOpenSolution.Size = new Size(127, 22);
            FileMenuOpenSolution.Text = "&Solution...";
            FileMenuOpenSolution.ToolTipText = "Select and open a Visual Studio Solution file.";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.FromArgb(28, 28, 28);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(124, 6);
            // 
            // FileMenuOpenProject
            // 
            FileMenuOpenProject.BackColor = Color.FromArgb(28, 28, 28);
            FileMenuOpenProject.ForeColor = Color.FromArgb(245, 255, 245);
            FileMenuOpenProject.Name = "FileMenuOpenProject";
            FileMenuOpenProject.Size = new Size(127, 22);
            FileMenuOpenProject.Text = "&Project...";
            FileMenuOpenProject.ToolTipText = "Select and open a C# or Visual Basic XAML project.";
            // 
            // FileMenuDivA
            // 
            FileMenuDivA.Alignment = ToolStripItemAlignment.Right;
            FileMenuDivA.BackColor = Color.FromArgb(28, 28, 28);
            FileMenuDivA.ForeColor = Color.FromArgb(28, 28, 28);
            FileMenuDivA.Name = "FileMenuDivA";
            FileMenuDivA.Overflow = ToolStripItemOverflow.Never;
            FileMenuDivA.Size = new Size(135, 6);
            // 
            // FileMenuClose
            // 
            FileMenuClose.BackColor = Color.FromArgb(28, 28, 28);
            FileMenuClose.ForeColor = Color.White;
            FileMenuClose.Name = "FileMenuClose";
            FileMenuClose.Size = new Size(138, 22);
            FileMenuClose.Text = "C&lose";
            FileMenuClose.ToolTipText = "Close everything.";
            // 
            // FileMenuDivB
            // 
            FileMenuDivB.BackColor = Color.FromArgb(28, 28, 28);
            FileMenuDivB.ForeColor = Color.White;
            FileMenuDivB.Name = "FileMenuDivB";
            FileMenuDivB.Size = new Size(135, 6);
            // 
            // FileMenuSave
            // 
            FileMenuSave.BackColor = Color.FromArgb(28, 28, 28);
            FileMenuSave.ForeColor = Color.White;
            FileMenuSave.Image = (Image)resources.GetObject("FileMenuSave.Image");
            FileMenuSave.Name = "FileMenuSave";
            FileMenuSave.ShortcutKeys = Keys.Control | Keys.S;
            FileMenuSave.Size = new Size(138, 22);
            FileMenuSave.Text = "&Save";
            FileMenuSave.ToolTipText = "Save any open documents.";
            // 
            // FileMenuDivC
            // 
            FileMenuDivC.BackColor = Color.FromArgb(28, 28, 28);
            FileMenuDivC.ForeColor = Color.White;
            FileMenuDivC.Name = "FileMenuDivC";
            FileMenuDivC.Size = new Size(135, 6);
            // 
            // FileMenuExit
            // 
            FileMenuExit.BackColor = Color.FromArgb(28, 28, 28);
            FileMenuExit.ForeColor = Color.White;
            FileMenuExit.Name = "FileMenuExit";
            FileMenuExit.ShortcutKeys = Keys.Alt | Keys.F4;
            FileMenuExit.Size = new Size(138, 22);
            FileMenuExit.Text = "E&xit";
            FileMenuExit.ToolTipText = "Exit the application.";
            // 
            // BuildMenu
            // 
            BuildMenu.BackColor = Color.FromArgb(28, 28, 28);
            BuildMenu.DropDownItems.AddRange(new ToolStripItem[] { BuldMenuValidateStyleId });
            BuildMenu.ForeColor = Color.White;
            BuildMenu.Name = "BuildMenu";
            BuildMenu.Size = new Size(46, 32);
            BuildMenu.Text = "&Build";
            // 
            // BuldMenuValidateStyleId
            // 
            BuldMenuValidateStyleId.BackColor = Color.FromArgb(28, 28, 28);
            BuldMenuValidateStyleId.ForeColor = Color.White;
            BuldMenuValidateStyleId.Image = (Image)resources.GetObject("BuldMenuValidateStyleId.Image");
            BuldMenuValidateStyleId.Name = "BuldMenuValidateStyleId";
            BuldMenuValidateStyleId.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            BuldMenuValidateStyleId.Size = new Size(289, 22);
            BuldMenuValidateStyleId.Text = "&Validation XAML Style IDs...";
            // 
            // MainToolbar
            // 
            MainToolbar.AutoSize = false;
            MainToolbar.Items.AddRange(new ToolStripItem[] { OpenSolutionButton, ValidateXamlButton, DivA, BuildButton });
            MainToolbar.Location = new Point(0, 32);
            MainToolbar.Name = "MainToolbar";
            MainToolbar.Padding = new Padding(0, 0, 14, 0);
            MainToolbar.RenderMode = ToolStripRenderMode.Professional;
            MainToolbar.Size = new Size(784, 32);
            MainToolbar.TabIndex = 10;
            // 
            // OpenSolutionButton
            // 
            OpenSolutionButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenSolutionButton.Image = (Image)resources.GetObject("OpenSolutionButton.Image");
            OpenSolutionButton.ImageTransparentColor = Color.Magenta;
            OpenSolutionButton.Name = "OpenSolutionButton";
            OpenSolutionButton.Size = new Size(23, 29);
            OpenSolutionButton.Text = "Open Visual Studio Solution";
            // 
            // ValidateXamlButton
            // 
            ValidateXamlButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ValidateXamlButton.Image = (Image)resources.GetObject("ValidateXamlButton.Image");
            ValidateXamlButton.ImageTransparentColor = Color.Magenta;
            ValidateXamlButton.Name = "ValidateXamlButton";
            ValidateXamlButton.Size = new Size(23, 29);
            ValidateXamlButton.Text = "Open Visual Studio Project";
            // 
            // DivA
            // 
            DivA.Name = "DivA";
            DivA.Size = new Size(6, 32);
            // 
            // BuildButton
            // 
            BuildButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BuildButton.Enabled = false;
            BuildButton.Image = (Image)resources.GetObject("BuildButton.Image");
            BuildButton.ImageTransparentColor = Color.Magenta;
            BuildButton.Name = "BuildButton";
            BuildButton.Size = new Size(23, 29);
            // 
            // SolutionExplorer
            // 
            SolutionExplorer.BackColor = Color.FromArgb(28, 28, 28);
            SolutionExplorer.BorderStyle = BorderStyle.FixedSingle;
            SolutionExplorer.Dock = DockStyle.Right;
            SolutionExplorer.Font = new Font("Segoe UI", 9.75F);
            SolutionExplorer.ForeColor = Color.White;
            SolutionExplorer.Location = new Point(512, 64);
            SolutionExplorer.Margin = new Padding(658, 141, 658, 141);
            SolutionExplorer.Name = "SolutionExplorer";
            SolutionExplorer.Size = new Size(272, 497);
            SolutionExplorer.TabIndex = 11;
            SolutionExplorer.Visible = false;
            SolutionExplorer.VisualStylesMode = VisualStylesMode.Latest;
            // 
            // SolutionExplorerSplitter
            // 
            SolutionExplorerSplitter.BackColor = Color.FromArgb(64, 0, 64);
            SolutionExplorerSplitter.Dock = DockStyle.Right;
            SolutionExplorerSplitter.Location = new Point(507, 64);
            SolutionExplorerSplitter.Name = "SolutionExplorerSplitter";
            SolutionExplorerSplitter.Size = new Size(5, 497);
            SolutionExplorerSplitter.TabIndex = 12;
            SolutionExplorerSplitter.TabStop = false;
            // 
            // ErrorList
            // 
            ErrorList.BackColor = Color.FromArgb(28, 28, 28);
            ErrorList.Dock = DockStyle.Bottom;
            ErrorList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorList.Location = new Point(0, 261);
            ErrorList.Margin = new Padding(48, 22, 48, 22);
            ErrorList.Name = "ErrorList";
            ErrorList.Size = new Size(507, 300);
            ErrorList.TabIndex = 13;
            ErrorList.Visible = false;
            ErrorList.VisualStylesMode = VisualStylesMode.Latest;
            // 
            // ErrorSplitter
            // 
            ErrorSplitter.BackColor = Color.FromArgb(64, 0, 64);
            ErrorSplitter.Dock = DockStyle.Bottom;
            ErrorSplitter.Location = new Point(0, 256);
            ErrorSplitter.Name = "ErrorSplitter";
            ErrorSplitter.Size = new Size(507, 5);
            ErrorSplitter.TabIndex = 14;
            ErrorSplitter.TabStop = false;
            // 
            // MainDialog
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(784, 561);
            Controls.Add(ErrorSplitter);
            Controls.Add(ErrorList);
            Controls.Add(SolutionExplorerSplitter);
            Controls.Add(SolutionExplorer);
            Controls.Add(MainToolbar);
            Controls.Add(MainMenu);
            FormRevealMode = FormRevealMode.Deferred;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(658, 141, 658, 141);
            Name = "MainDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Provident Foundations XAML ID Validation For Visual Studio";
            VisualStylesMode = VisualStylesMode.Latest;
            WindowState = FormWindowState.Maximized;
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            MainToolbar.ResumeLayout(false);
            MainToolbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripMenuItem OpenMenu;
        private MenuStrip MainMenu;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem FileMenuOpen;
        private ToolStripMenuItem FileMenuOpenSolution;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem FileMenuOpenProject;
        private ToolStripSeparator FileMenuDivA;
        private ToolStripMenuItem FileMenuClose;
        private ToolStripSeparator FileMenuDivB;
        private ToolStripMenuItem FileMenuSave;
        private ToolStripSeparator FileMenuDivC;
        private ToolStripMenuItem FileMenuExit;
        private ToolStripMenuItem BuildMenu;
        private ToolStripMenuItem BuldMenuValidateStyleId;
        private ToolStrip MainToolbar;
        private ToolStripButton OpenSolutionButton;
        private ToolStripSeparator DivA;
        private ToolStripButton BuildButton;
        private ToolStripButton ValidateXamlButton;
        private SolutionExplorer SolutionExplorer;
        private Splitter SolutionExplorerSplitter;
        private VisualStudioErrorListControl ErrorList;
        private Splitter ErrorSplitter;
    }
}
