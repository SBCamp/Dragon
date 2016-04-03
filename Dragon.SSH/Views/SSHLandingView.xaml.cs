using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dragon.Library;

namespace Dragon.SSH.Views
{
    /// <summary>
    /// Interaction logic for SSHLandingView.xaml
    /// </summary>
    public partial class SSHLandingView : UserControl
    {
        public SSHLandingView()
        {
            InitializeComponent();
        }

        private void ConsoleCommandLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                ConsoleCommandLineSub_Click(this, e);
        }

        private void ConsoleCommandLineSub_Click(object sender, RoutedEventArgs e)
        {
            ConsoleWindow.Text = string.Format("{0} " + Environment.NewLine +" {1}", ConsoleWindow.Text.ToSafeString(), ConsoleCommandLine.Text.ToSafeString());
            ConsoleWindow.ScrollToEnd();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
