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
using AutoShop.Emploe;
using AutoShop.Product;

namespace AutoShop.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            EmployeeWindow r1 = new EmployeeWindow();
            r1.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeWindow recuiment = new AddEmployeWindow();
            recuiment.Show();
        }

     

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ProductWindow p1 = new ProductWindow();
            p1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EmployeeSackWindow e1 = new EmployeeSackWindow();
            e1.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ProductCatecoryAddWindow p1 = new ProductCatecoryAddWindow();
            p1.Show();
        }
    }
}
