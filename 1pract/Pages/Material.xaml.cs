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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1pract.Pages
{
    /// <summary>
    /// Логика взаимодействия для Material.xaml
    /// </summary>
    public partial class Material : Page
    {
        public Material()
        {
            InitializeComponent();
            DataGridMaterial.ItemsSource = Entities.GetContext().Material.ToList();
        }

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {

            NavigationService?.Navigate(new AddEditPage());
        }

        private void ButtonDel_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {

        }


    }
}
