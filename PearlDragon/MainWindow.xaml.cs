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

namespace PearlDragon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Dragon.Library.Views.NavBar NB = new Dragon.Library.Views.NavBar();
            TextBox TB = new TextBox() { Name = "TEST", Height = 100, Width = 100, Visibility = System.Windows.Visibility.Visible, VerticalAlignment = System.Windows.VerticalAlignment.Top, Text="FUCK" };
            Grid.SetColumn(NB, 0);
            Grid.SetRow(NB, 0);
            MainGrid.Children.Add(NB);
            //Dragon.Library.Views.Logon lgn = new Dragon.Library.Views.Logon();
            //Set the Logon screen
            
        }

        public void Login(string Username, string Password)
        {
            if(Username.ToSafeString() == "steve" && Password == "")

            else
        }
    }
}
