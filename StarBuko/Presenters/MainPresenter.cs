using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarBuko.Models;
using StarBuko.Views;
using StarBuko.Repositories;

namespace StarBuko.Presenters
{
    public class MainPresenter
    {
        private IMainForm _view;
        //private List<Product> _products;
        private BindingList<LineItem> _lineItems;
        ProductRepository _repository;
        List<Product> _products;

        public MainPresenter(IMainForm view)
        {
            _view = view;
            _lineItems = new BindingList<LineItem>();
            _repository = new ProductRepository();
            _products = _repository.GetProducts();

            //_products = new List<Product>
            //{
            //    new Product { Name = "Creamy Pure Matcha Latte", Price = 180.00m, ImagePath = "Images/matcha_latte.jpeg" },
            //    new Product { Name = "XOXO Frappuccino", Price = 150.00m, ImagePath = "Images/xoxo_frappucino.jpeg" },
            //    new Product { Name = "Strawberry Açaí with Lemonade", Price = 160.00m, ImagePath = "Images/strawberry_acai.jpeg" },
            //    new Product { Name = "Pink Drink with Strawberry Açaí", Price = 165.00m, ImagePath = "Images/pink_drink.jpeg" },
            //    new Product { Name = "Dragon Drink with Mango Dragonfruit ", Price = 170.00m, ImagePath = "Images/dragon_drink.jpeg" },
            //    new Product { Name = "Strawberries & Cream Frappuccino", Price = 175.00m, ImagePath = "Images/strawberries_cream.jpg" },
            //    new Product { Name = "Chocolate Chip Cream Frappuccino", Price = 180.00m, ImagePath = "Images/chocolate_chip.jpg" },
            //    new Product { Name = "Dark Caramel Coffee Frappuccino", Price = 170.00m, ImagePath = "Images/dark_caramel_frappucino.jpg" },
            //};

            _view.DisplayProducts(_products);
            _view.DisplayLineItems(_lineItems);

            _view.OnProductClicked += HandleProductClicked;
            _view.OnAmountTenderedChanged += HandleAmountTenderedChanged;
            _view.OnButtonAddNewItemClicked += HandleButtonAddNewItem;
            _view.OnButtonAddNewProductClicked += HandleButtonAddNewProduct;
        }

        private void HandleProductClicked(object sender, Product product)
        {
            var sizeResult = ShowSizeSelectionPopup();
            LineItem newItem = new LineItem(product, product.Price, 1);
            newItem.Size = sizeResult;

            var existingItem = _lineItems.FirstOrDefault(item => LineItem.GetProductNameWithSize(newItem.Product.Name, newItem.Size) == LineItem.GetProductNameWithSize(item.Product.Name, item.Size));
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                _lineItems.Add(newItem);
            }

            _view.DisplayLineItems(_lineItems);
            UpdateTotalAmount();
        }
        private void HandleButtonAddNewProduct(object sender, dynamic _)
        {
            using (AddProductForm form = new AddProductForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _products = _repository.GetProducts();
                    _view.DisplayProducts(_products);
                }
            }
        }

        private void HandleButtonAddNewItem(object sender, dynamic _)
        {
            // Clear line items: 
            _lineItems.Clear();
            _view.DisplayLineItems(null);
            _view.ResetTotalAmount();
            
        }

        private String ShowSizeSelectionPopup()
        {
            var result = MessageBox.Show(
                "Choose Cup Size:\n" +
                "Yes for Grande (+20), " +
                "No for Venti (+30), " + 
                "Cancel for Regular", 
                "Select Cup Size", 
                MessageBoxButtons.YesNoCancel
            );

            if (result == DialogResult.Yes) return "Grande";
            if (result == DialogResult.No) return "Venti";
            return "Regular"; 
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
