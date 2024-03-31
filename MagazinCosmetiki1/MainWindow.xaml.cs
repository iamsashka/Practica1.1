using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using MagazinCosmetiki1;

namespace MagazinCosmetiki1
{
    public partial class MainWindow : Window
    {
        MagazinCosmetikiEntities db = new MagazinCosmetikiEntities();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Categories2();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new ProductsPage();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Country1();
        }

        private void PageFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
