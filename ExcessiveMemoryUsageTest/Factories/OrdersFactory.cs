using ExcessiveMemoryUsageTest.Models;
using System;
using System.Collections.Generic;

namespace ExcessiveMemoryUsageTest.Factories
{
    public class OrdersFactory
    {
        private List<string> _productNames;
        private List<string> _clientNames;
        private List<string> _descriptions;

        private Random _random = new Random(DateTime.Now.Millisecond);

        public OrdersFactory()
        {
            _clientNames = GenerateStrings("Client Name", 400);
            _productNames = GenerateStrings("Product ", 4000);
            _descriptions = GenerateStrings("Description", 400);
            _random = new Random(DateTime.Now.Millisecond);
        }

        public Order GenerateNewOrder(int id = 0)
        {
            var order = new Order();
            order.Product = GenerateNewProduct();
            order.Id = id;
            order.Quantity = _random.Next(0, 1000);
            order.ClientName = _clientNames.GetRandom();
            order.ExecutionDate = DateTime.Now.AddDays(_random.Next(-100, 100));

            order.SomeNumber1 = _random.Next(1000, 99999999) / 1000;
            order.SomeNumber2 = _random.Next(1000, 99999999) / 1000;
            order.SomeNumber3 = _random.Next(1000, 99999999) / 1000;
            order.SomeNumber4 = _random.Next(1000, 99999999) / 1000;
            order.SomeNumber5 = _random.Next(1000, 99999999) / 1000;

            return order;
        }

        public Product GenerateNewProduct()
        {
            var product = new Product();

            product.Description = _descriptions.GetRandom();
            product.Name = _productNames.GetRandom();
            product.Price = _random.Next(1000, 99999999) / 1000;
            product.Type = (ProductType)_random.Next(0, 2);

            return product;
        }

        public List<string> GenerateStrings(string pattern, int count)
        {
            var list = new List<string>();
            for (int i = 0; i < count; i++)
            {
                list.Add($"{pattern}_{i}");
            }
            return list;
        }
    }
}