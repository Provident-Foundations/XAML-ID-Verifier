using System.Windows;

namespace Provident.Xaml.Verify
{
    /// <summary>
    /// Interaction logic for PleaseWaitDialog.xaml
    /// </summary>
    public partial class PleaseWaitDialog : Window
    {
        public PleaseWaitDialog()
        {
            InitializeComponent();
        }
        public void Dispose()
        {
            
        }

        /// <summary>
        /// Gets or sets the message to be displayed.
        /// </summary>
        public string Message
        {
            get => (string)MessageLabel.Text;
            set
            {
                MessageLabel.Text = value;
                InvalidateVisual();
            }
        }
    }
}
