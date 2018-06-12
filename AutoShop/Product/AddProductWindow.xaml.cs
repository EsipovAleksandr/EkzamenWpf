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
    /// Логика взаимодействия для AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        string AllBrand;
        public AddProductWindow()
        {
            InitializeComponent();
            ShowCategory();
          //  ProductCatecoryAddWindow p1 = new ProductCatecoryAddWindow();
            //foreach (var item in p1.Categore())
            //{
            //    ComboBoxCategory.Items.Add(item);

            //}



        }
        public void ShowCategory()
        {
            using (ShopAutoEntities db = new ShopAutoEntities())
            {
                List<ProductCategorry> list = db.ProductCategorry.ToList();
                foreach (var item in list)
                {
                   ComboBoxCategory.Items.Add(item.CategoryExtra);

                }

            }
        }

            private void Button_Click(object sender, RoutedEventArgs e)
        {

            using (ShopAutoEntities db = new ShopAutoEntities())
            {
                //  Binding binding = new Binding();
                try
                {
                    Products Prod = (new Products()
                    {
                        Name = tbName.Text,
                        Brand = AllBrand,
                        Category = ComboBoxCategory.Text,
                        ART = tbArt.Text,
                        Catalogue_num = tbCatalogNum.Text,
                        Manufacturer = tbManufacturer.Text,
                        Price_first = Convert.ToDecimal(tbPriceFirst.Text),
                        Price_sale = Convert.ToDecimal(tbPriceFirst.Text),
                        Color = tbColor.Text,
                        Product_rest = Convert.ToInt32(tbProductRest.Text)
                    });
                    db.Products.Add(Prod);
                    db.SaveChanges();
                               
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ComboBox comboBox = (ComboBox)sender;
            //ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            //Console.WriteLine((selectedItem.Content.ToString()));
            int selectedIndex = ComboBox1.SelectedIndex;
            Object selectedItem = ComboBox1.SelectedItem;
            Console.WriteLine((selectedIndex.ToString()));
            if (selectedIndex == 0)
            {
                AllBrand = "BMW";
            }
            if (selectedIndex == 1)
            {
                AllBrand = "Audi";
            }
            if (selectedIndex == 2)
            {
                AllBrand = "Mersedes";
            }
        }
    }

}
