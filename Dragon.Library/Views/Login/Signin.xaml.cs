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

namespace Dragon.Library.Views.Login
{
    /// <summary>
    /// Interaction logic for Signin.xaml
    /// </summary>
    public partial class Signin : UserControl
    {
        public Signin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            var cust = new Dragon.Library.Entities.Customer();
        }
    }
}
