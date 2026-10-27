namespace Provident.Xaml.Verify.Controls;

/// <summary>
/// Provides the color definition for the "dark" theme color scheme.
/// </summary>
public sealed class DarkThemeColors : ProfessionalColorTable
{

    public override Color ToolStripGradientBegin => Color.FromArgb(255, 20, 20, 20);
    public override Color ToolStripGradientMiddle => Color.FromArgb(255, 24, 24, 24);
    public override Color ToolStripGradientEnd => Color.FromArgb(255, 28, 28, 28);

    public override Color MenuStripGradientBegin => Color.FromArgb(255, 20, 20, 08);
    public override Color MenuStripGradientEnd => Color.FromArgb(255, 32, 32, 32);

    public override Color ToolStripDropDownBackground => Color.FromArgb(255, 32, 32, 32);
    public override Color MenuItemSelected => Color.FromArgb(255, 32, 32, 32);
    public override Color MenuItemPressedGradientBegin => Color.FromArgb(255, 32, 32, 32);
    public override Color MenuItemPressedGradientMiddle => Color.FromArgb(255, 42, 42, 42);
    public override Color MenuItemPressedGradientEnd => Color.FromArgb(255, 52, 42, 52);

    public override Color MenuItemSelectedGradientBegin => Color.FromArgb(255, 64, 64, 64);
    public override Color MenuItemSelectedGradientEnd => Color.FromArgb(255, 74, 64, 74);
    //public override Color MenuItemBorder => Color.Purple;
    public override Color GripDark => Color.FromArgb(255, 28, 28, 28);
    public override Color ImageMarginGradientBegin => Color.FromArgb(255, 28, 28, 28);
    public override Color ImageMarginGradientMiddle => Color.FromArgb(255, 28, 28, 28);

    public override Color ImageMarginGradientEnd => Color.FromArgb(255, 28, 28, 28);
    public override Color SeparatorLight => Color.FromArgb(255, 28, 28, 28);
    public override Color SeparatorDark => Color.FromArgb(255, 64, 64, 64);

    public override Color MenuBorder => Color.Purple;


}