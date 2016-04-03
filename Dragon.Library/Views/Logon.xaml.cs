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
                //Load in the Nav bar & Homepage
                Methods.ViewControls.Controls.SetUIElementAndRemovParent(
                    new List<Objects.MultiUIElm>() { 
                    new Objects.MultiUIElm() { Element = new NavBar(), Col = 0, Row = 0}, 
                    new Objects.MultiUIElm() { Element = new Home(), Col = 1, Row = 0 } },
                    this);
            }
        }
    }
}
