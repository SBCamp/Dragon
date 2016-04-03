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

namespace Dragon.Library.Views
{
    /// <summary>
    /// Interaction logic for NavBar.xaml
    /// </summary>
    public partial class NavBar : UserControl
    {
        public NavBar()
        {
            InitializeComponent();
        }

        private void Button_Home_Click(object sender, RoutedEventArgs e)
        {
            Methods.ViewControls.Controls.SetUIElement(new Views.Home(), 1, 0, this);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_SSH_Click(object sender, RoutedEventArgs e)
        {
            Methods.ViewControls.Controls.SetUIElement(new Dragon.SSH.Views.SSHLandingView(), 1, 0, this);
        }
    }
}
