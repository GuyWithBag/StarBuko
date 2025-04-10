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
                ImagePath = pictureBox1.ImageLocation
            };
            _productRepository.AddProduct(product);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string img = GetFile();
            pictureBox1.Image = Image.FromFile(img);
            pictureBox1.ImageLocation = img;
        }

        public string GetFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configure dialog
                openFileDialog.Title = "Select an Image File";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the selected image
                        return openFileDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                        return null;
                    }
                }
            }
            return null;
        }

    }
}
