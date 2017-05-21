using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace WPFekzam.Emploe
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
            using (ShopAuto db = new ShopAuto())
            {

                List<Employee> list = db.Employee.Where(c => c.Date_end == null).ToList();
                listBox.ItemsSource = list;
               

            }
            using (ShopAuto db2 = new ShopAuto())
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
