using Microsoft.Extensions.Logging;
using Provident.Foundations.VisualStudio.Xaml.Validation;
using Provident.Foundations.WinForms.Controls.Inheritable;
using System.ComponentModel;

namespace Provident.Xaml.Verify;

/// <summary>
/// Displays project validation diagnostics in a Visual Studio Error List-style grid.
/// </summary>
public partial class ProjectValidationErrorList : ProvidentControlBase
{
    private List<XamlProjectValidationResult>? _results;
    private readonly Bitmap _errorIcon;
    private readonly Bitmap _warningIcon;
    private readonly Bitmap _informationIcon;
    private readonly Bitmap _fileIcon;

    /// <summary>
    /// Initializes a new instance of the <see cref="ProjectValidationErrorList"/> class.
    /// </summary>
    public ProjectValidationErrorList()
    {
        InitializeComponent();
        _errorIcon = CreateStatusIcon(Color.FromArgb(196, 43, 28), true);
        _warningIcon = CreateStatusIcon(Color.FromArgb(224, 155, 0), false);
        _informationIcon = CreateInformationIcon();
        _fileIcon = CreateFileIcon();
        SeverityFilter.SelectedIndex = 0;
    }

    /// <summary>
    /// Gets or sets the validation result displayed by the control.
    /// </summary>
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public List<XamlProjectValidationResult>? Results
    {
        get => _results;
        set
        {
            _results = value;
            RefreshResults();
        }
    }

    /// <summary>
    /// Rebuilds the Error List rows from the current validation result.
    /// </summary>
    public void RefreshResults()
    {
        if (IsDisposed)
        {
            return;
        }

        ResultsGrid.Rows.Clear();
        if (_results is null)
        {
            UpdateSummary(0, 0);
            return;
        }

        int xamlFileCount = 0;
        int diagnosticCount = 0;
        foreach (var result in _results)
        {
            foreach (var entry in result.Log.Entries)
            {
                DiagnosticSeverity severity = GetSeverity(entry.Level);
                if (!IsSeverityVisible(severity))
                {
                    continue;
                }

                string message = entry.Message ?? string.Empty;
                if (entry.Exceptions.Count > 0)
                {
                    message += Environment.NewLine + string.Join(
                        Environment.NewLine,
                        entry.Exceptions.Select(exception => exception.Message)
                    );
                }

                AddRow(
                    severity,
                    "Validation",
                    message,
                    string.Empty,
                    string.Empty,
                    entry.LogDateTime.ToString("G")
                );
                diagnosticCount++;
            }


            if (ShowFiles.Checked)
            {
                foreach (string fileName in result.XamlFiles.Keys.OrderBy(file => file))
                {
                    AddRow(
                        DiagnosticSeverity.File,
                        "XAML",
                        "Loaded XAML file",
                        fileName,
                        string.Empty,
                        string.Empty
                    );
                }
            }
            xamlFileCount += result.XamlFiles.Count;
        }
        UpdateSummary(diagnosticCount, xamlFileCount);
    }

    private void AddRow(
        DiagnosticSeverity severity,
        string category,
        string message,
        string file,
        string location,
        string date)
    {
        int rowIndex = ResultsGrid.Rows.Add(
            GetIcon(severity),
            severity.ToString(),
            message,
            file,
            location,
            category,
            date
        );
        ResultsGrid.Rows[rowIndex].Tag = severity;
    }

    private void UpdateSummary(int diagnosticCount, int fileCount)
    {
        SummaryLabel.Text = $"{diagnosticCount} diagnostic(s), {fileCount} XAML file(s)";
    }

    private bool IsSeverityVisible(DiagnosticSeverity severity)
    {
        return SeverityFilter.SelectedIndex switch
        {
            1 => severity == DiagnosticSeverity.Error,
            2 => severity == DiagnosticSeverity.Warning,
            3 => severity == DiagnosticSeverity.Information,
            _ => true,
        };
    }

    private static DiagnosticSeverity GetSeverity(LogLevel level)
    {
        return level switch
        {
            LogLevel.Critical or LogLevel.Error => DiagnosticSeverity.Error,
            LogLevel.Warning => DiagnosticSeverity.Warning,
            _ => DiagnosticSeverity.Information,
        };
    }

    private Bitmap GetIcon(DiagnosticSeverity severity)
    {
        return severity switch
        {
            DiagnosticSeverity.Error => _errorIcon,
            DiagnosticSeverity.Warning => _warningIcon,
            DiagnosticSeverity.File => _fileIcon,
            _ => _informationIcon,
        };
    }

    private void HandleSeverityFilterChanged(object? sender, EventArgs e)
    {
        RefreshResults();
    }

    private void HandleShowFilesChanged(object? sender, EventArgs e)
    {
        RefreshResults();
    }

    private static Bitmap CreateStatusIcon(Color color, bool error)
    {
        Bitmap bitmap = new(16, 16);
        using Graphics graphics = Graphics.FromImage(bitmap);
        using SolidBrush brush = new(color);
        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        graphics.Clear(Color.Transparent);
        graphics.FillEllipse(brush, 1, 1, 14, 14);
        using Pen pen = new(Color.White, 2);
        graphics.DrawLine(pen, error ? 5 : 4, 8, error ? 11 : 8, error ? 8 : 12);
        if (error)
        {
            graphics.DrawLine(pen, 8, 5, 8, 9);
            graphics.FillEllipse(Brushes.White, 7, 11, 2, 2);
        }

        return bitmap;
    }

    private static Bitmap CreateInformationIcon()
    {
        Bitmap bitmap = new(16, 16);
        using Graphics graphics = Graphics.FromImage(bitmap);
        using SolidBrush brush = new(Color.FromArgb(45, 111, 181));
        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        graphics.Clear(Color.Transparent);
        graphics.FillEllipse(brush, 1, 1, 14, 14);
        using Pen pen = new(Color.White, 2);
        graphics.DrawLine(pen, 8, 7, 8, 12);
        graphics.FillEllipse(Brushes.White, 7, 4, 2, 2);
        return bitmap;
    }

    private static Bitmap CreateFileIcon()
    {
        Bitmap bitmap = new(16, 16);
        using Graphics graphics = Graphics.FromImage(bitmap);
        using SolidBrush brush = new(Color.FromArgb(110, 110, 110));
        graphics.Clear(Color.Transparent);
        graphics.FillRectangle(Brushes.White, 3, 1, 9, 14);
        graphics.FillPolygon(brush, [new Point(9, 1), new Point(12, 4), new Point(9, 4)]);
        graphics.DrawRectangle(Pens.Gray, 3, 1, 9, 14);
        graphics.DrawLine(Pens.Gray, 5, 7, 11, 7);
        graphics.DrawLine(Pens.Gray, 5, 10, 11, 10);
        graphics.DrawLine(Pens.Gray, 5, 13, 9, 13);
        return bitmap;
    }

    private enum DiagnosticSeverity
    {
        Error,
        Warning,
        Information,
        File,
    }
}
