﻿using System;
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
            //Dragon.Library.Views.NavBar NB = new Dragon.Library.Views.NavBar();
            Dragon.Library.Views.Logon lgn = new Dragon.Library.Views.Logon();
            Grid.SetColumn(lgn, 1);
            Grid.SetRow(lgn, 1);
            MainGrid.Children.Add(lgn);
            //Set the Logon screen
            
        }
    }
}
