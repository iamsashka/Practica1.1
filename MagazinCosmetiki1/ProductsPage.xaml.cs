using System.Windows.Controls;
using System.Windows.Shapes;
using System.Data.Entity;
using System.Linq;
using MagazinCosmetiki1;

namespace MagazinCosmetiki1
{

    public partial class ProductsPage : Page
    {
        private MagazinCosmetikiEntities contextPro = new MagazinCosmetikiEntities();
        public ProductsPage()
        {
            InitializeComponent();
            Productsdg.ItemsSource = contextPro.Products.ToList();
        }

    }
}