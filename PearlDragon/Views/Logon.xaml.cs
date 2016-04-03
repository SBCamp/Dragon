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
using Dragon.Library.Methods.Account;
using Dragon.Library.Entities;
using Dragon.Library.Methods.ViewControls;
using Dragon.Library.Objects;

namespace PearlDragon.Views
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
            Login.CheckLogin(txtUserName.Text, txtPassword.Text);

            if (CustomerCollection.CUS[0].User.LoggedIn)
            {
                //Load in the Nav bar & Homepage
                Controls.SetUIElementAndRemovParent(
                    new List<MultiUIElm>() { 
                    new MultiUIElm() { Element = new NavBar(), Col = 0, Row = 0}, 
                    new MultiUIElm() { Element = new Home(), Col = 1, Row = 0 } },
                    this);
            }
        }
    }
}
