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
using AutoShop.Model;

namespace AutoShop.Product
{
    /// <summary>
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        ShopAutoEntities db = new ShopAutoEntities();
        public ProductWindow()
        {
          
            InitializeComponent();
            _renewControlls();
        }
        public void _renewControlls()
        {
            using (ShopAutoEntities db = new ShopAutoEntities())
            {
                List<Products> list = db.Products.ToList();
                dataGriPriduct.ItemsSource = list;
               
            }
        }


        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //  Products Product = dataGriPriduct.SelectedItem as Products;
            // { DataContext = Product };

         
            AddProductWindow ad1 = new AddProductWindow();           
            ad1.Show();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (dataGriPriduct.SelectedItem != null)
            {

                Products Produc = dataGriPriduct.SelectedItem as Products;


                // Используем LINQ to Entities для обновления базы данных
              

                Products pro = db.Products
                                      .Where(p => p.Id == Produc.Id)
                                      .Single<Products>();
                //обновление   
                pro.Name = Produc.Name;
                pro.Brand = Produc.Brand;
                pro.Catalogue_num = Produc.Catalogue_num;
                pro.Category= Produc.Category;
                pro.Color = Produc.Color;
                pro.ART = Produc.ART;
                pro.Price_first = Produc.Price_first;
                pro.Price_sale = Produc.Price_sale;
                pro.Product_rest = Produc.Product_rest;

                db.SaveChanges();
                _renewControlls();

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (dataGriPriduct.SelectedItem != null)
            {

              Products Produc = dataGriPriduct.SelectedItem as Products;


                // Используем LINQ to Entities для обновления базы данных
            

                Products pro = db.Products
                                      .Where(p => p.Id == Produc.Id)
                                      .Single<Products>();
                //обновление         
                db.Products.Remove(pro);
                db.SaveChanges();
                _renewControlls();

            }
            }
    }
}
