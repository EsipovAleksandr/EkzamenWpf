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

namespace WPFekzam.Product
{
    /// <summary>
    /// Interaction logic for ProductCatecoryAddWindow.xaml
    /// </summary>
    public partial class ProductCatecoryAddWindow : Window
    {
        public ProductCatecoryAddWindow()
        {
            InitializeComponent();
       
            CategoreList();


        }

        private void CategoreList()
        {
            
             List<String> CategoreList1 = new List<string>();
            CategoreList1.Add("Двигатель");
            CategoreList1.Add("ВЫХЛОПНАЯ СИСТЕМА"); ;
            CategoreList1.Add("ДЕТАЛИ ДЛЯ СЕРВИСА, ТО, УХОДА");
            CategoreList1.Add("ДОПОЛНИТЕЛЬНЫЕ УДОБСТВА");
            CategoreList1.Add("КОЛЁСА, КОМПЛЕКТУЮЩИ");
            CategoreList1.Add("ПОДВЕСКА, АМОРТИЗАЦИ");
            CategoreList1.Add("РУЛЕВОЕ УПРАВЛЕН");
            CategoreListBox.ItemsSource = CategoreList1;
        }



        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow ad1 = new AddProductWindow();
            ad1.ComboBoxCategory.Items.Add(CategoreListBox.Items);
        }
    }
}
