using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarBuko.Models;
using StarBuko.Views;

namespace StarBuko.Presenters
{
    public class MainPresenter
    {
        private IMainForm _view;
        private List<Product> _products;
        private BindingList<LineItem> _lineItems;

        public MainPresenter(IMainForm view)
        {
            _view = view;
            _lineItems = new BindingList<LineItem>();

            _products = new List<Product>
            {
                new Product { Name = "Creamy Pure Matcha Latte", Price = 180.00m, ImagePath = "Images/matcha_latte.jpeg" },
                new Product { Name = "XOXO Frappuccino", Price = 150.00m, ImagePath = "Images/xoxo_frappucino.jpeg" },
                new Product { Name = "Strawberry Açaí with Lemonade", Price = 160.00m, ImagePath = "Images/strawberry_acai.jpeg" },
                new Product { Name = "Pink Drink with Strawberry Açaí", Price = 165.00m, ImagePath = "Images/pink_drink.jpeg" },
                new Product { Name = "Dragon Drink with Mango Dragonfruit ", Price = 170.00m, ImagePath = "Images/dragon_drink.jpeg" },
                new Product { Name = "Strawberries & Cream Frappuccino", Price = 175.00m, ImagePath = "Images/strawberries_cream.jpg" },
                new Product { Name = "Chocolate Chip Cream Frappuccino", Price = 180.00m, ImagePath = "Images/chocolate_chip.jpg" },
                new Product { Name = "Dark Caramel Coffee Frappuccino", Price = 170.00m, ImagePath = "Images/dark_caramel_frappucino.jpg" },
            };

            _view.DisplayProducts(_products);
            _view.DisplayLineItems(_lineItems);

            _view.OnProductClicked += HandleProductClicked;
            _view.OnAmountTenderedChanged += HandleAmountTenderedChanged;
        }

        private void HandleProductClicked(object sender, Product product)
        {
            var existingItem = _lineItems.FirstOrDefault(item => item.ProductName == product.Name);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                LineItem newItem = new LineItem(product, product.Price, 1);
                _lineItems.Add(newItem);
            }

            _view.DisplayLineItems(_lineItems);
            UpdateTotalAmount();
        }

        private void HandleAmountTenderedChanged(object sender, string inputValue)
        {
            decimal totalAmount = _lineItems.Sum(item => item.TotalPrice);
           
            if (decimal.TryParse(inputValue, out decimal amountTendered))
            {
                _view.UpdateChange(amountTendered - totalAmount);
            }
            else
            {
                _view.UpdateChange(-1);
            }
        }

        private void UpdateTotalAmount()
        {
            decimal totalAmount = _lineItems.Sum(item => item.TotalPrice);
            _view.UpdateTotalAmount(totalAmount);
        }


       
    }
}
