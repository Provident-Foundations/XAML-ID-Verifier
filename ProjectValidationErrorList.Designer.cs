namespace Provident.Xaml.Verify;

partial class ProjectValidationErrorList
{
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Releases the resources used by the control.
    /// </summary>
    /// <param name="disposing">true to release managed resources; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _errorIcon?.Dispose();
            _warningIcon?.Dispose();
            _informationIcon?.Dispose();
            _fileIcon?.Dispose();
            components?.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        HeaderPanel = new Panel();
        SummaryLabel = new Label();
        ShowFiles = new CheckBox();
        SeverityFilter = new ComboBox();
        FilterLabel = new Label();
        ResultsGrid = new DataGridView();
        SeverityColumn = new DataGridViewImageColumn();
        SeverityTextColumn = new DataGridViewTextBoxColumn();
        MessageColumn = new DataGridViewTextBoxColumn();
        FileColumn = new DataGridViewTextBoxColumn();
        LocationColumn = new DataGridViewTextBoxColumn();
        CategoryColumn = new DataGridViewTextBoxColumn();
        DateColumn = new DataGridViewTextBoxColumn();
        HeaderPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)ResultsGrid).BeginInit();
        SuspendLayout();
        // 
        // HeaderPanel
        // 
        HeaderPanel.Controls.Add(SummaryLabel);
        HeaderPanel.Controls.Add(ShowFiles);
        HeaderPanel.Controls.Add(SeverityFilter);
        HeaderPanel.Controls.Add(FilterLabel);
        HeaderPanel.Dock = DockStyle.Top;
        HeaderPanel.Location = new Point(0, 0);
        HeaderPanel.Name = "HeaderPanel";
        HeaderPanel.Padding = new Padding(6, 5, 6, 5);
        HeaderPanel.Size = new Size(900, 34);
        HeaderPanel.TabIndex = 1;
        // 
        // SummaryLabel
        // 
        SummaryLabel.Dock = DockStyle.Fill;
        SummaryLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        SummaryLabel.ForeColor = Color.White;
        SummaryLabel.Location = new Point(6, 5);
        SummaryLabel.Name = "SummaryLabel";
        SummaryLabel.Size = new Size(610, 24);
        SummaryLabel.TabIndex = 0;
        SummaryLabel.Text = "0 diagnostic(s), 0 XAML file(s)";
        SummaryLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ShowFiles
        // 
        ShowFiles.AutoSize = true;
        ShowFiles.Checked = true;
        ShowFiles.CheckState = CheckState.Checked;
        ShowFiles.Dock = DockStyle.Right;
        ShowFiles.ForeColor = Color.White;
        ShowFiles.Location = new Point(616, 5);
        ShowFiles.Name = "ShowFiles";
        ShowFiles.Size = new Size(120, 24);
        ShowFiles.TabIndex = 1;
        ShowFiles.Text = "Show loaded files";
        ShowFiles.CheckedChanged += HandleShowFilesChanged;
        // 
        // SeverityFilter
        // 
        SeverityFilter.BackColor = Color.FromArgb(48, 48, 48);
        SeverityFilter.Dock = DockStyle.Right;
        SeverityFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        SeverityFilter.ForeColor = Color.White;
        SeverityFilter.Items.AddRange(new object[] { "All", "Errors", "Warnings", "Information" });
        SeverityFilter.Location = new Point(736, 5);
        SeverityFilter.Name = "SeverityFilter";
        SeverityFilter.Size = new Size(110, 26);
        SeverityFilter.TabIndex = 2;
        SeverityFilter.SelectedIndexChanged += HandleSeverityFilterChanged;
        // 
        // FilterLabel
        // 
        FilterLabel.Dock = DockStyle.Right;
        FilterLabel.ForeColor = Color.White;
        FilterLabel.Location = new Point(846, 5);
        FilterLabel.Name = "FilterLabel";
        FilterLabel.Size = new Size(48, 24);
        FilterLabel.TabIndex = 3;
        FilterLabel.Text = "  Filter: ";
        FilterLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // ResultsGrid
        // 
        ResultsGrid.AllowUserToAddRows = false;
        ResultsGrid.AllowUserToDeleteRows = false;
        ResultsGrid.AllowUserToResizeRows = false;
        ResultsGrid.BackgroundColor = Color.FromArgb(28, 28, 28);
        ResultsGrid.BorderStyle = BorderStyle.None;
        ResultsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        ResultsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 28, 28);
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle1.ForeColor = Color.White;
        dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        ResultsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        ResultsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ResultsGrid.Columns.AddRange(new DataGridViewColumn[] { SeverityColumn, SeverityTextColumn, MessageColumn, FileColumn, LocationColumn, CategoryColumn, DateColumn });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 28, 28);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        ResultsGrid.DefaultCellStyle = dataGridViewCellStyle2;
        ResultsGrid.Dock = DockStyle.Fill;
        ResultsGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
        ResultsGrid.GridColor = Color.Indigo;
        ResultsGrid.Location = new Point(0, 34);
        ResultsGrid.MultiSelect = false;
        ResultsGrid.Name = "ResultsGrid";
        ResultsGrid.ReadOnly = true;
        ResultsGrid.RowHeadersVisible = false;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(28, 28, 28);
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle3.ForeColor = Color.White;
        dataGridViewCellStyle3.SelectionBackColor = Color.MediumPurple;
        dataGridViewCellStyle3.SelectionForeColor = Color.White;
        ResultsGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
        ResultsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        ResultsGrid.Size = new Size(900, 266);
        ResultsGrid.TabIndex = 0;
        ResultsGrid.VisualStylesMode = VisualStylesMode.Latest;
        // 
        // SeverityColumn
        // 
        SeverityColumn.HeaderText = "";
        SeverityColumn.Name = "SeverityColumn";
        SeverityColumn.ReadOnly = true;
        SeverityColumn.Width = 28;
        // 
        // SeverityTextColumn
        // 
        SeverityTextColumn.HeaderText = "Severity";
        SeverityTextColumn.Name = "SeverityTextColumn";
        SeverityTextColumn.ReadOnly = true;
        SeverityTextColumn.Width = 85;
        // 
        // MessageColumn
        // 
        MessageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        MessageColumn.HeaderText = "Description";
        MessageColumn.MinimumWidth = 220;
        MessageColumn.Name = "MessageColumn";
        MessageColumn.ReadOnly = true;
        // 
        // FileColumn
        // 
        FileColumn.HeaderText = "File";
        FileColumn.MinimumWidth = 150;
        FileColumn.Name = "FileColumn";
        FileColumn.ReadOnly = true;
        FileColumn.Width = 220;
        // 
        // LocationColumn
        // 
        LocationColumn.HeaderText = "Line";
        LocationColumn.Name = "LocationColumn";
        LocationColumn.ReadOnly = true;
        LocationColumn.Width = 65;
        // 
        // CategoryColumn
        // 
        CategoryColumn.HeaderText = "Project";
        CategoryColumn.Name = "CategoryColumn";
        CategoryColumn.ReadOnly = true;
        // 
        // DateColumn
        // 
        DateColumn.HeaderText = "Date";
        DateColumn.Name = "DateColumn";
        DateColumn.ReadOnly = true;
        DateColumn.Width = 150;
        // 
        // ProjectValidationErrorList
        // 
        AutoScaleDimensions = new SizeF(96F, 96F);
        BackColor = Color.FromArgb(28, 28, 28);
        Controls.Add(ResultsGrid);
        Controls.Add(HeaderPanel);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Name = "ProjectValidationErrorList";
        Size = new Size(900, 300);
        HeaderPanel.ResumeLayout(false);
        HeaderPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)ResultsGrid).EndInit();
        ResumeLayout(false);
    }

    private Panel HeaderPanel;
    private Label SummaryLabel;
    private CheckBox ShowFiles;
    private ComboBox SeverityFilter;
    private Label FilterLabel;
    private DataGridView ResultsGrid;
    private DataGridViewImageColumn SeverityColumn;
    private DataGridViewTextBoxColumn SeverityTextColumn;
    private DataGridViewTextBoxColumn MessageColumn;
    private DataGridViewTextBoxColumn FileColumn;
    private DataGridViewTextBoxColumn LocationColumn;
    private DataGridViewTextBoxColumn CategoryColumn;
    private DataGridViewTextBoxColumn DateColumn;
}
