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
using static TrafficFines.ClassEntities;

namespace TrafficFines
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }
        private void btAuth_Click(object sender, RoutedEventArgs e)
        {
            var User = context.Driver.ToList().Where(i => i.Login == this.txtLog.Text && i.Password == this.txtPass.Text).FirstOrDefault();
            if (User != null)
            {         
                var Name = User.FirstName.ToString();
                var LName = User.LastName.ToString();

                MainWindow mainWindow = new MainWindow( Height,  Name, LName);
                mainWindow.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильно введен логин или пароль");
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            RegistrWindow registrWindow = new RegistrWindow();
            registrWindow.ShowDialog();
        }
    }
}
