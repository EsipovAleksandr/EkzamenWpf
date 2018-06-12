using System.Linq;
using System.Windows;
using System.Windows.Input;
using AutoShop.Model;

namespace AutoShop.Emploe
{
    /// <summary>
    /// Логика взаимодействия для SackWindow.xaml
    /// </summary>
    public partial class SackWindow : Window
    {
        public SackWindow()
        {
            InitializeComponent();
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee ct = (Employee)DataContext;

            // Используем LINQ to Entities для обновления базы данных
            ShopAutoEntities db = new ShopAutoEntities();

            Employee ct1 = db.Employee
                                  .Where(p => p.Id == ct.Id)
                                  .Single<Employee>();
            //обновление         
            ct1.Date_end = Calendar1.DisplayDate;
            db.SaveChanges();
            this.Hide();
        }
    }
}
