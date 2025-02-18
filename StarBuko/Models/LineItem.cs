using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuko.Models
{
    public class LineItem
    {
        [Browsable(false)]
        public Product Product { get; set; }
        public string ProductName => Product.Name;
        public int Quantity { get; set; }
        public decimal Price { get; set; }


        public decimal TotalPrice => Price * Quantity;

        public LineItem(Product product, decimal price, int quantity)
        {
            Product = product;
            Price = price;
            Quantity = quantity;
        }
    }
}
