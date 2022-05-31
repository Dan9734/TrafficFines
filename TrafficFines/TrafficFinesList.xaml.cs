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
using TrafficFines.DB;

namespace TrafficFines
{
    /// <summary>
    /// Логика взаимодействия для TrafficFinesList.xaml
    /// </summary>
    public partial class TrafficFinesList : Window
    {
       List<DB.AreaOfViolation> Fines = new List<DB.AreaOfViolation>();
    
        public TrafficFinesList()
        {
            InitializeComponent();
            AllInformation.ItemsSource = context.Fine.ToList();
            cbAreaOfViolation.ItemsSource = context.AreaOfViolation.ToList();
            cbTypeOfPunishment.ItemsSource = context.TypeOfPunishment.ToList();
            cbAreaOfViolation.DisplayMemberPath = "Title";
            cbAreaOfViolation.SelectedIndex = 0;
            //Filter();

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        //private void Filter()
        //{
        //    var list = context.AreaOfViolation.ToList();
        //    if (cbAreaOfViolation.SelectedIndex != 0)
        //    {
        //        var Area = cbAreaOfViolation.SelectedIndex as AreaOfViolation;
        //    }
        //    Fines = ClassEntities.context.Fine.ToList();
        //    Fines = Fines.Where(e => e.CodeOfAdminOfenses.Contains(tbSearch.Text) || e.Description.Contains(tbSearch.Text) || e.Phone.Punishment(tbSearch.Text)).ToList();

        //    switch (AreaOfViolation.SelectedIndex)
        //    {
        //        case 0:
        //            AreaOfViolation = AreaOfViolation.OrderBy(e => e.ID).ToList();
        //            break;
        //        case 1:
        //            AreaOfViolation = AreaOfViolation.OrderBy(e => e.Title).ToList();
        //            break;
        //    }
        //    if (Fines.Count == 0)
        //    {
        //        MessageBox.Show("Записей нет");
        //    }
        //    TrafficFines.ItemsSource = Fines;
        //}

        private void TrafficFines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Filter();
        }
    }
}
