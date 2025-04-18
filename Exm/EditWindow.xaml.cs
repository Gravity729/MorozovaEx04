using Exm.Models;
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

namespace Exm
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        OrdersAssortment _selectedOrders;
        public EditWindow(OrdersAssortment selectedOrders)
        {
            InitializeComponent();
            _selectedOrders = selectedOrders;
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SaveButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
