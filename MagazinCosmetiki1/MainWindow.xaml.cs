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
            PageFrame.Content = new Categories();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Products();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Country();
        }

        private void PageFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}