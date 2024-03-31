using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using MagazinCosmetiki1;

namespace MagazinCosmetiki1
{
    /// <summary>
    /// Логика взаимодействия для Country.xaml
    /// </summary>
    public partial class Country1 : Page
    {
        private MagazinCosmetikiEntities contextCoun = new MagazinCosmetikiEntities();
        public Country1()
        {
            InitializeComponent();
            CountryGrid.ItemsSource = contextCoun.Country.ToList();
            CountryGrid.DisplayMemberPath = "CountryName";
        }
    }
}
