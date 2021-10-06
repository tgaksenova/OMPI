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
    /// Логика взаимодействия для postup.xaml
    /// </summary>
    public partial class postup : Page
    {
        public postup()
        {
            InitializeComponent();
        }

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AddEditpostup()); 
        }

        private void ButtonDel_OnClick(object sender, RoutedEventArgs e)
        {

        }
        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
