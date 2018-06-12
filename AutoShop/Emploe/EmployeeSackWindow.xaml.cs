using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using AutoShop.Model;

namespace AutoShop.Emploe
{
    /// <summary>
    /// Логика взаимодействия для EmployeeSackWindow.xaml
    /// </summary>
    public partial class EmployeeSackWindow : Window
    {
        public EmployeeSackWindow()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.NoResize;
            _renewControlls();
        }
        private void _renewControlls()
        {
            using (ShopAutoEntities db = new ShopAutoEntities())
            {

                List<Employee> list = db.Employee.Where(c => c.Date_end == null).ToList();
                listBox.ItemsSource = list;
               

            }
            using (ShopAutoEntities db2 = new ShopAutoEntities())
            {
                List<Employee> list2= db2.Employee.Where(c => c.Date_end != null).ToList();
                listBox2.ItemsSource = list2;

            }
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        
            if (listBox.SelectedItem != null)
            {
                Employee emploe = listBox.SelectedItem as Employee;
                SackWindow S1 = new SackWindow(){ DataContext = emploe };
                S1.Show();
            }
        }
    }
}
