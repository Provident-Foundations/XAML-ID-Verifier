using Provident.Xaml.Verify.Controls;
using System.ComponentModel;
using System.Windows.Forms.Integration;

namespace Provident.Xaml.Verify;

public partial class TextEditorWindow : Form
{
    private string? _fileName;
    private SimpleTextEditorControl _ctl;

    public TextEditorWindow()
    {
        InitializeComponent();
        var wpfHost = new ElementHost()
        {
            Dock = DockStyle.Fill
        };
        Controls.Add(wpfHost);

        _ctl = new SimpleTextEditorControl
        {
            Name = "TextEditor"
        };
        wpfHost.Child = _ctl;
    }


    [Browsable(false),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string? FileName
    {
        get => _fileName;
        set
        {
            _fileName = value;
            _ctl.Content = System.IO.File.ReadAllText(_fileName);

        }
    }
}
   
