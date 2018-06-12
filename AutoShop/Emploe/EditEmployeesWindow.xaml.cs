using System.Linq;
using System.Windows;
using System.Windows.Input;
using AutoShop.Model;

namespace AutoShop.Emploe
{
    /// <summary>
    /// Логика взаимодействия для EditEmployeesWindow.xaml
    /// </summary>
    public partial class EditEmployeesWindow : Window
    {
        public EditEmployeesWindow()
        {
            InitializeComponent();
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void ButAdd_Click(object sender, RoutedEventArgs e)
        {
            Employee ct = (Employee)DataContext;

            // Используем LINQ to Entities для обновления базы данных
            ShopAutoEntities db = new ShopAutoEntities();

            Employee ct1 = db.Employee
                                  .Where(p => p.Id == ct.Id)
                                  .Single<Employee>();
            //обновление
            ct1.FIO = ct.FIO;
            ct1.Birthday = ct.Birthday;
            ct1.Date_start = ct.Date_start;
            ct1.Passport_data = ct.Passport_data;
            ct1.Phone1 = ct.Phone1;
            ct1.Phone2 = ct.Phone2;
            ct1.Post = ct.Post;
            db.SaveChanges();
            this.Hide();
        }
    }
}
