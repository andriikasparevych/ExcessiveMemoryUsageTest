using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcessiveMemoryUsageTest.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        
        public decimal Total { get { return Quantity * Product.Price; } }

        public Product Product { get; set; }

        public string ClientName { get; set; }
        public decimal SomeNumber1 { get; set; }
        public decimal SomeNumber2 { get; set; }
        public decimal SomeNumber3 { get; set; }
        public decimal SomeNumber4 { get; set; }
        public decimal SomeNumber5 { get; set; }
    }

}

