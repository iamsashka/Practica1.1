using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MagazinCosmetiki1;

namespace MagazinCosmetiki1
{
    /// <summary>
    /// Логика взаимодействия для Categories.xaml
    /// </summary>
    public partial class Categories2 : Page
    {
        private MagazinCosmetikiEntities contextCat = new MagazinCosmetikiEntities();
        public Categories2()
        {
            InitializeComponent();
            Categoriesdg.ItemsSource = contextCat.Categories.ToList();

        }
    }
}
