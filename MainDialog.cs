using Provident.Foundations.VisualStudio.IO;
using Provident.Foundations.VisualStudio.Model;
using Provident.Foundations.VisualStudio.Xaml.Validation;
using Provident.Foundations.WinForm.Dialogs;
using Provident.Foundations.WinForms.CommonDialogs;
using Provident.Xaml.Verify.Controls;
using System.IO;

namespace Provident.Xaml.Verify;

/// <summary>
/// Provides the central dialog for the application.
/// </summary>
public partial class MainDialog : ProvidentDialogBase
{
    #region Private Member Declarations
    /// <summary>
    /// The open solution.
    /// </summary>
    private VsSolutionModel? _xamlSolution;

    /// <summary>
    /// The open or selected project.
    /// </summary>
    private SolutionProjectModel? _currentProject;

    /// <summary>
    /// The color scheme for the application.
    /// </summary>
    private ProfessionalColorTable? _colorScheme;

    private PleaseWaitDialog? _statusDialog;
    private VisualStudioSolutionLoader? _loader;
    private VisualStudioProjectLoader? _projectLoader;

    /// <summary>
    /// The application directory.
    /// </summary>
    private string? _appPath;
    #endregion

    #region Constructor / Dispose Methods
    /// <summary>
    /// Initializes a new instance of the <see cref="MainDialog"/> class.
    /// </summary>
    /// <remarks>
    /// This is the default constructor.
    /// </remarks>
    public MainDialog()
    {
        InitializeComponent();

        // Create and assign the color scheme to the controls.
        _colorScheme = new DarkThemeColors();
        MainMenu.RenderMode = ToolStripRenderMode.Professional;
        MainMenu.Renderer = new ToolStripProfessionalRenderer(_colorScheme);
        MainToolbar.RenderMode = ToolStripRenderMode.Professional;
        MainToolbar.Renderer = new ToolStripProfessionalRenderer(_colorScheme);

        _appPath = Path.GetDirectoryName(Application.ExecutablePath);
        _appPath = @"D:\Provident Foundations\Products\OCB-Office-Manager";
        WindowState = FormWindowState.Maximized;

        _statusDialog = new PleaseWaitDialog();
        _loader = new VisualStudioSolutionLoader();
        _projectLoader = new VisualStudioProjectLoader();
    }

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (!IsDisposed && disposing)
        {
            //_xamlSolution?.Dispose();
            //_currentProject?.Dispose();

            _statusDialog?.Close();
            components?.Dispose();
        }

        _statusDialog = null;
        _loader = null;
        _projectLoader = null;
        _appPath = null;
        _xamlSolution = null;
        _currentProject = null;
        _colorScheme = null;
        components = null;
        base.Dispose(disposing);
    }
    #endregion

    #region Protected Method Overrides
    /// <summary>
    /// Creates and assigns the event handlers for the controls on the dialog.
    /// </summary>
    protected override void AssignEventHandlers()
    {
        FileMenuOpenSolution.Click += HandleOpenSolutionClicked;
        FileMenuOpenProject.Click += HandleOpenProjectClicked;
        FileMenuClose.Click += HandleSolutionClosed;
        FileMenuExit.Click += HandleExitClicked;

        OpenSolutionButton.Click += HandleOpenSolutionClicked; 
        BuldMenuValidateStyleId.Click += HandleValidateSolutionClicked;
    }

    /// <summary>
    /// Removes the event handlers for the controls on the dialog.
    /// </summary>
    protected override void RemoveEventHandlers()
    {
        FileMenuOpenSolution.Click -= HandleOpenSolutionClicked;
        FileMenuOpenProject.Click -= HandleOpenProjectClicked;
        FileMenuClose.Click -= HandleSolutionClosed;
        FileMenuExit.Click -= HandleExitClicked;

        OpenSolutionButton.Click -= HandleOpenSolutionClicked;
        BuldMenuValidateStyleId.Click -= HandleValidateSolutionClicked;
    }

    /// <summary>
    /// Sets the state of the dialog while busy.
    /// </summary>
    protected override void SetPreLoadState()
    {
        Cursor = Cursors.WaitCursor;
        MainMenu.Enabled = false;
        MainToolbar.Enabled = false;
        Application.DoEvents();
        SuspendLayout();
    }

    /// <summary>
    /// Sets the state of the dialog when no longer busy.
    /// </summary>
    protected override void SetPostLoadState()
    {
        Cursor = Cursors.Default;
        MainMenu.Enabled = true;
        MainToolbar.Enabled = true;
        CloseStatusDialog();
        ResumeLayout();
    }

    /// <summary>
    /// Sets the UI controls' states based on current conditions.
    /// </summary>
    protected override void SetDisplayState()
    {
        bool isOpen = (_xamlSolution is not null) || (_currentProject is not null);

        FileMenuClose.Visible = isOpen;
        FileMenuDivB.Visible = isOpen;
        FileMenuSave.Visible = isOpen;
        FileMenuDivC.Visible = isOpen;

        BuildMenu.Enabled = isOpen;
        BuldMenuValidateStyleId.Enabled = isOpen;
        BuildButton.Enabled = isOpen;

    }
    #endregion

    #region Private Event Handlers
    /// <summary>
    /// Handles the event when the File -> Open -> Solution menu item is clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HandleOpenSolutionClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        string? solutionFile = CommonDialogProvider.GetFileToOpen(
            new OpenFileProfile
            {
                AddExtension = true,
                AddToRecent = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".sln",
                Filter = "Visual Studio Solution Files (*.sln,*.slnx)|*.sln;*.slnx|All Files (*.*)|*.*",
                FilterIndex = 0,
                SupportMultiDottedExtensions = true,
                InitialDirectory = _appPath,
                Multiselect = false,
                ShowHelp = false,
                Title = "Open A Visual Studio Solution File"
            });

        if (!string.IsNullOrEmpty(solutionFile))
        {
            Cursor = Cursors.WaitCursor;
            DisplayStatus("Loading Solution...");
            Application.DoEvents();

            _appPath = Path.GetDirectoryName(solutionFile);
            _xamlSolution = _loader?.LoadSolution(solutionFile);
            SolutionExplorer.Solution = _xamlSolution;
            SolutionExplorer.Visible = true;

            CloseStatusDialog();
        }

        SetState();
        SetPostLoadState();

    }

    /// <summary>
    /// Handles the event when the File -> Open -> Project menu item is clicked.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void HandleOpenProjectClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        string? projectFile = CommonDialogProvider.GetFileToOpen(
            new OpenFileProfile
            {
                AddExtension = true,
                AddToRecent = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".csproj",
                Filter = "Visual Studio Project Files (*.csproj,*.vbproj)|*.csproj;*.vbproj|All Files (*.*)|*.*",
                FilterIndex = 0,
                SupportMultiDottedExtensions = true,
                InitialDirectory = _appPath,
                Multiselect = false,
                ShowHelp = false,
                Title = "Open A Visual Studio Project File"
            });

        if (!string.IsNullOrEmpty(projectFile))
        {
            _appPath = Path.GetDirectoryName(projectFile);
        }

        SetState();
        SetPostLoadState();
    }
    private void HandleValidateSolutionClicked(object? sender, EventArgs e)
    {
        SetPreLoadState();
        if (_xamlSolution is not null)
        {
            DisplayStatus("Preparing To Analyze Solution...");
            Application.DoEvents();

            PerformSolutionValidation();
        }
        else
        {
            SetPostLoadState();
            SetState();
        }
    }
    private void HandleSolutionClosed(object? sender, EventArgs e)
    {
        SetPreLoadState();
        DisplayStatus("Closing Solution...");

        _xamlSolution = null;
        _currentProject = null;
        SolutionExplorer.Solution = null;
        SolutionExplorer.Visible = false;
        ErrorList.Results = null;
        ErrorList.Visible = false;

        SetState();
        SetPostLoadState();
    }

    private void HandleStatusUpdate(object? sender, string statusText)
    {
        DisplayStatus(statusText);
    }
    private void HandleExitClicked(object? sender, EventArgs e)
    {
        HandleSolutionClosed(sender, e);
        SetPreLoadState();
        Close();
    }
    #endregion

    #region Private Methods / Functions
    private void PerformSolutionValidation()
    {
        StartSolutionValidationAsync();
    }
    private async Task StartSolutionValidationAsync()
    {
        XamlStyleIdValidator validator = new XamlStyleIdValidator();
        validator.StatusUpdate += HandleStatusUpdate;

        DisplayStatus($"Validating Solution: {_xamlSolution.Name} ...");
        var result = await validator.ValidateXamlSolutionAsync(_xamlSolution);

        validator.StatusUpdate -= HandleStatusUpdate;

        ContinueInMainThread(() =>
        {
            if (result is not null)
            {
                ErrorList.Results = result.CombinedResultsList;
            }
            ErrorList.Visible = true;
            SolutionExplorer.Visible = true;
            SolutionExplorer.Solution = _xamlSolution;

            SetPostLoadState();
            SetState();
        });
    }
    private async Task StartProjectValidationAsync()
    {
        XamlStyleIdValidator validator = new XamlStyleIdValidator();
        validator.StatusUpdate += HandleStatusUpdate;

        DisplayStatus($"Validating Project: {_currentProject.Project.Name} ...");
        var result = await validator.ValidateXamlProjectAsync(_currentProject);
        
        validator.StatusUpdate -= HandleStatusUpdate;
        
        ContinueInMainThread(() =>
        {
            if (result is not null)
            {
                ErrorList.Results = [result];
            }
            ErrorList.Visible = true;
            SolutionExplorer.Visible = true;
            SolutionExplorer.Solution = _xamlSolution;

            SetPostLoadState();
            SetState();
        });
    }
    private void DisplayStatus(string statusMessage)
    {
        ContinueInMainThread(() =>
        {
            if (_statusDialog is not null)
            {
                _statusDialog.Message = statusMessage;
                if (!_statusDialog.IsVisible)
                {
                    _statusDialog?.Show();
                }
            }
        });
    }
    private void CloseStatusDialog()
    {
        ContinueInMainThread(() =>
        {
            if (_statusDialog is not null)
            {
                _statusDialog?.Hide();
            }
        });
    }
    #endregion
}
