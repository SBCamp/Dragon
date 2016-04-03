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

namespace Dragon.Library.Views
{
    /// <summary>
    /// Interaction logic for Logon.xaml
    /// </summary>
    public partial class Logon : UserControl
    {
        public Logon()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Methods.Account.Login.CheckLogin(txtUserName.Text, txtPassword.Text);
            if (Entities.CustomerCollection.CUS[0].User.LoggedIn)
            {
                NavBar test = new NavBar();
                Grid.SetColumn(test, 0);
                Grid.SetRow(test, 0);
                ((Panel)this.Parent).Children.Add(test);
                ((Panel)this.Parent).Children.Remove(this);
            }
                
        }
    }
}
