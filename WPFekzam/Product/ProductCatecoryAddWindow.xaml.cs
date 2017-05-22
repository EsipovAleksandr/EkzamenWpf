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
    /// 

    public partial class ProductCatecoryAddWindow : Window
    {
       
       // List<String> CategoreList1 = new List<string>();
        public ProductCatecoryAddWindow()
        {
            InitializeComponent();
            tbCategory.Text = " ";
            ShowCategory();
        }

   //public List<string> Categore()
   //     {
   //       return   CategoreList1;
   //     }

        public  void ShowCategory()
        {
            using (ShopAuto db = new ShopAuto())
            {
                List<ProductCategorry> list = db.ProductCategorry.ToList();
               DataGridCategory.ItemsSource = list;

            }
            
            //        CategoreList1.Add("Двигатель");
            //CategoreList1.Add("ВЫХЛОПНАЯ СИСТЕМА"); ;
            //CategoreList1.Add("ДЕТАЛИ ДЛЯ СЕРВИСА, ТО, УХОДА");
            //CategoreList1.Add("ДОПОЛНИТЕЛЬНЫЕ УДОБСТВА");
            //CategoreList1.Add("КОЛЁСА, КОМПЛЕКТУЮЩИ");
            //CategoreList1.Add("ПОДВЕСКА, АМОРТИЗАЦИ");
            //CategoreList1.Add("РУЛЕВОЕ УПРАВЛЕН");
            //CategoreListBox.ItemsSource = CategoreList1;
           
           
        }
     


        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (tbCategory.Text != " ")
            {
                using (ShopAuto db1 = new ShopAuto())
                {

                    try
                    {
                        ProductCategorry ProCa = (new ProductCategorry() { CategoryExtra = tbCategory.Text });
                        db1.ProductCategorry.Add(ProCa);
                        db1.SaveChanges();
                        ShowCategory();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }

                tbCategory.Text = " ";
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (DataGridCategory.SelectedItem != null)
            {

              ProductCategorry CategoreProd = DataGridCategory.SelectedItem as ProductCategorry;


                // Используем LINQ to Entities для обновления базы данных
                ShopAuto db = new ShopAuto();

                ProductCategorry pro = db.ProductCategorry
                                      .Where(p => p.Id == CategoreProd.Id)
                                      .Single<ProductCategorry>();
                //обновление         
                db.ProductCategorry.Remove(pro);
                db.SaveChanges();
                ShowCategory();

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (DataGridCategory.SelectedItem != null)
            {

                ProductCategorry CategoreProd = DataGridCategory.SelectedItem as ProductCategorry;



                // Используем LINQ to Entities для обновления базы данных
                ShopAuto db = new ShopAuto();


                ProductCategorry pro = db.ProductCategorry
                                      .Where(p => p.Id == CategoreProd.Id)
                                      .Single<ProductCategorry>();
                //обновление   
                pro.CategoryExtra = CategoreProd.CategoryExtra;           
                db.SaveChanges();
            

            }
        }
    }
}
