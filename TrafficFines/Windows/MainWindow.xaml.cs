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

namespace TrafficFines
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

        public MainWindow(double height, string name, string lName)
        {
            Height = height;
            Name = name;
            LName = lName;
        }

        public MainWindow(object weight, object height, object age, object name, object lName)
        {
        }

        public string LName { get; }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AuthWindow authWindow = new AuthWindow();
            authWindow.ShowDialog();
            this.Close();
        }

        private void Fines_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            TrafficFinesList trafficFinesList = new TrafficFinesList();
            trafficFinesList.ShowDialog();
            this.Close();
        }
    }
}
