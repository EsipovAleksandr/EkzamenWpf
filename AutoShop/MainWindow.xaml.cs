using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using AutoShop.Admin;
using AutoShop.Model;

namespace AutoShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.NoResize;
          

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShopAutoEntities db = new ShopAutoEntities();
            var list = db.Users.ToList();
            foreach (var item in list)
            {
                if (UsernameLabel.Text == item.Login && PasswordLabel.Password == item.Password)
                {
                    Window r1 = new AdminWindow();
                    r1.Show();
                    this.Close();
                    Console.WriteLine("1");
                    Console.WriteLine(UsernameLabel.Text+" "+ item.Login);
                }
                else
                {
                    Console.WriteLine("текст :"+"   "+UsernameLabel.Text + "     " +"бд:"+"    "+item.Login);           
                }


            }
        }
        //    if (UsernameLabel.Text == "admin" && PasswordLabel.Password == "admin")
        //    {   
        //        error1.Background = Brushes.Green;
        //        error2.Background = Brushes.Green;     
            
        //        Window r1 = new AdminWindow();
        //        r1.Show();
        //        this.Close();
        //    }
        //    else
        //    {
        //        UsernameLabel.Text = "";
        //        PasswordLabel.Password = "";
        //        error1.Background = Brushes.Red;
        //        error2.Background = Brushes.Red;
               
        //    }
        //}

        //кнопка закрытия
        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        
        }
        //ссылка создание аккаунта

    }
}
