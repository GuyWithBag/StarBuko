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

        public string ProductName => LineItem.GetProductNameWithSize(Product.Name, Size);
        public string ProductNameOriginal => Product.Name;

        public int Quantity { get; set; }
        private decimal _price;

        public decimal Price
        {
            get => _price + GetSizePrice(Size);
            set => _price = value;
        }
        public String Size { get; set; }

        //public decimal ExtraPrice { get; set; }


        public decimal TotalPrice => (Price * Quantity);

        public LineItem(Product product, decimal price, int quantity)
        {
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public static String GetProductNameWithSize(String productName, String size)
        {
            return  $"{productName} ({size})";
        }

        private static int GetSizePrice(String size)
        {
            var resultPrice = 0;
            if (size == "Grande") resultPrice = 20;
            if (size == "Venti") resultPrice = 30;
            return resultPrice;
        }
    }
}
