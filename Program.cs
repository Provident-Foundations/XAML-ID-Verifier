using Microsoft.Build.Locator;

namespace Provident.Xaml.Verify;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        if (!MSBuildLocator.IsRegistered)
        {
            MSBuildLocator.RegisterDefaults();
        }

        Application.EnableVisualStyles();
        Application.SetColorMode(SystemColorMode.Dark);
        Application.SetDefaultVisualStylesMode(VisualStylesMode.Latest);

        MainDialog dialog = new MainDialog();
        dialog.Show();

        Application.Run(dialog);

        dialog.Dispose();
        GC.Collect();
    }
}