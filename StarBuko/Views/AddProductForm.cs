using StarBuko.Models;
using StarBuko.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StarBuko.Views
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            ProductRepository _productRepository = new ProductRepository();
            Product product = new Product {
                Name = textBoxName.Text,
                Price = Convert.ToDecimal(textBoxPrice.Text),
                ImagePath = textBoxImage.Text
            };
            _productRepository.AddProduct(product);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
