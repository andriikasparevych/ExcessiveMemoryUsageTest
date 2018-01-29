using ExcessiveMemoryUsageTest.Factories;
using ExcessiveMemoryUsageTest.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace ExcessiveMemoryUsageTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Order> Orders = new ObservableCollection<Order>();
        private OrdersFactory _factory;

        public MainWindow()
        {
            InitializeComponent();
            _factory = new OrdersFactory();
            InitializeData();
        }

        private void InitializeData()
        {
            pivotGrid.SetDataSourceAsync(Orders, (res) => {

                for (var i = 0; i< 700000; i++)
                {
                    Orders.Add(_factory.GenerateNewOrder(i));
                }
                pivotGrid.ReloadData();
            });
        }
    }
}