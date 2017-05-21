using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WPFekzam.Admin;

namespace WPFekzam
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
            if (UsernameLabel.Text == "admin" && PasswordLabel.Password == "admin")
            {   
                error1.Background = Brushes.Green;
                error2.Background = Brushes.Green;     
            
                Window r1 = new AdminWindow();
                r1.Show();
                this.Close();
            }
            else
            {
                UsernameLabel.Text = "";
                PasswordLabel.Password = "";
                error1.Background = Brushes.Red;
                error2.Background = Brushes.Red;
               
            }
        }

        //кнопка закрытия
        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        
        }
        //ссылка создание аккаунта

    }
}
