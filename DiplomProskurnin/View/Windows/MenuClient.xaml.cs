using DiplomProskurnin.View.Pages;
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
using System.Windows.Shapes;

namespace DiplomProskurnin.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuClient.xaml
    /// </summary>
    public partial class MenuClient : Window
    {
        public MenuClient()
        {
            InitializeComponent();
        }

        private void txtSearch_Click(object sender, RoutedEventArgs e)
        {
            frmNav.Navigate(new SeachTrener());
        }

        private void txtExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void txtPersonal_Click(object sender, RoutedEventArgs e)
        {
            frmNav.Navigate(new PersonalAccount());
        }
    }
}
