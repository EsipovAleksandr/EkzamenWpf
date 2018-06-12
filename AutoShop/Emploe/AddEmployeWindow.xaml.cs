using System;
using System.Windows;
using System.Windows.Input;
using AutoShop.Model;


namespace AutoShop.Emploe
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
            using (ShopAutoEntities db = new ShopAutoEntities())
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
                    Users us = (new Users()
                    {
                        Login = tbLogin.Text,
                        Password = tbPassword.Text

                    });
                    db.Users.Add(us);
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
