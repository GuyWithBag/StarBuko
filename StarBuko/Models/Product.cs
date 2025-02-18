using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuko.Models
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0.00m;
        public string Description { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
    }
}
