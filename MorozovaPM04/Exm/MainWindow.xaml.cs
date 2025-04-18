using Exm.Models;
using Microsoft.EntityFrameworkCore;
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
using System.Linq;

namespace Exm
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            using (var db = new MorozovaPM04Context())
            {
                OrdersList.ItemsSource = db.OrdersAssortment
                    .Include(oa => oa.IdAssortmentPizzaNavigation).ToList();
            }
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(sender is Border border && border.DataContext is OrdersAssortment selectedOrders)//если в рамке есть данные тогда отркрывает редактирование
                if (new EditWindow(selectedOrders).ShowDialog() == true)
                    LoadOrders();
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            if(new AddWindow().ShowDialog() == true)            
                LoadOrders();            
        }
    }
}
