using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StarBuko.Models;

namespace StarBuko
{
    public partial class ProductControl : UserControl
    {
        private Product _product;
        public event EventHandler<Product>? ProductClicked;

        public ProductControl(Product _product)
        {
            InitializeComponent();
            this._product = _product;

            labelProductName.Text = _product.Name;
            labelProductPrice.Text = $"₱ {_product.Price}";
            string fullImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _product.ImagePath);
            productPhoto.Image = Image.FromFile(fullImagePath);

            this.Click += ProductControl_Click;
            labelProductName.Click += ProductControl_Click;

        }

        private void ProductControl_Click(object? sender, EventArgs e)
        {
            ProductClicked?.Invoke(this, _product);
        }
    }
}
