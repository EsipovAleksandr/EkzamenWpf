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


namespace WPFekzam.Emploe
{
    /// <summary>
    /// Логика взаимодействия для AddEmployeWindow.xaml
    /// </summary>
    public partial class AddEmployeWindow : Window
    {
        public AddEmployeWindow()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.NoResize;
        }

        private void ButAdd_Click(object sender, RoutedEventArgs e)
        {
            using (ShopAuto db = new ShopAuto())
            {
                try
                {
                    Employee emp = (new Employee()
                    {                                       
                        Post = tbPosition.Text,
                        FIO = tbName.Text + " " + tbfamile.Text + " " + tbochesvo.Text,
                        Date_start = Convert.ToDateTime(DateStart.Text),
                        Birthday = Convert.ToDateTime(tbbirdDay.Text),
                        Passport_data = tbPassportData.Text,
                        Phone1 = tbPhone.Text,               
                        Phone2 = tbPhone2.Text
                        
                    });
                    db.Employee.Add(emp);
                    db.SaveChanges();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }




        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();

        }



    }
}
