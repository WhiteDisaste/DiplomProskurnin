using DiplomProskurnin.View.Windows;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace DiplomProskurnin
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    var userObj = Connect.entities.Users.Where(x => x.Login == txtUsername.Text && x.Password == txtPassword.Password).FirstOrDefault();
            //    if (userObj == null)
            //    {
            //        MessageBox.Show("Такого пользователя нет", "Mistake", MessageBoxButton.OK, MessageBoxImage.Error);
            //    }
            //    else
            //    {
            //        switch (userObj.IdRoles)
            //        {
            //            case 1:
            //                MessageBox.Show("Здравствуйте, воспитатель " + userObj.FIO + "!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            //                Menu menu = new Menu();
            //                menu.Show();
            //                Close();
            //                break;

            //            case 2:
            //                MessageBox.Show("Здравствуйте, родитель " + userObj.FIO + "!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            //                break;
            //            default:
            //                MessageBox.Show("No data detected!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            //                break;
            //        }
            //    }
            //}
            //catch (Exception Ex)
            //{

            //    MessageBox.Show("Mistake" + Ex.Message.ToString() + "Critical operation of the application", "Notification", MessageBoxButton.OK, MessageBoxImage.Warning);

            //}
        }
        
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Close();
        }
    }
}
