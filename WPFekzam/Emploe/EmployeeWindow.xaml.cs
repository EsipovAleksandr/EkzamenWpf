using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace WPFekzam.Emploe
{
    /// <summary>
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();
            // this.ResizeMode = ResizeMode.NoResize;
            _renewControlls();
        }

        private void _renewControlls()
        {
            using (ShopAuto db = new ShopAuto())
            {
                List<Employee> list = db.Employee.Where(c => c.Date_end == null).ToList();        
                listBox.ItemsSource = list;

            }
        }
        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {

            this.Close();

        }

        private void listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                Employee emploe = listBox.SelectedItem as Employee;
                EditEmployeesWindow e1 = new EditEmployeesWindow() { DataContext = emploe };
                e1.Show();
            }
        }
    }
}
