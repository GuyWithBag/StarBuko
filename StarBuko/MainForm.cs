using System.ComponentModel;
using StarBuko.Models;
using StarBuko.Views;
using StarBuko.Presenters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StarBuko.Repositories;

namespace StarBuko
{
    public partial class MainForm : Form, IMainForm
    {
        public event EventHandler<Product> OnProductClicked;
        public event EventHandler<string> OnAmountTenderedChanged;
        public event EventHandler OnButtonAddNewItemClicked; 
        public event EventHandler OnButtonAddNewProductClicked;

        private MainPresenter _presenter;
        UserRepository _userRepository; 

        public MainForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            textBoxAmountTendered.TextChanged += (s, e) => OnAmountTenderedChanged?.Invoke(this, textBoxAmountTendered.Text);
            _presenter = new MainPresenter(this);
            buttonAddNewItem.Click += OnButtonAddNewItemClicked;
            buttonAddNewProduct.Click += OnButtonAddNewProductClicked;
            _userRepository = new UserRepository();

            buttonAddNewProduct.Hide();
            if (_userRepository.getUserRole(Program.presenter.currentUserName).ToLower() == "admin")
            {
                buttonAddNewProduct.Show();
            }
        }

        public void DisplayProducts(List<Product> products)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var product in products)
            {
                ProductControl productControl = new ProductControl(product);
                productControl.ProductClicked += (s, p) => OnProductClicked?.Invoke(this, p);
                flowLayoutPanel1.Controls.Add(productControl);
            }
        }

        public void DisplayLineItems(BindingList<LineItem> lineItems)
        {
            dataGridView1.DataSource = lineItems;
            dataGridView1.Refresh();
        }
        public void UpdateTotalAmount(decimal total)
        {
            labelTotalAmount.Text = $"₱ {total:N2}";
        }
        public void UpdateChange(decimal change)
        {
            labelChange.Text = $"₱ {change:N2}";
        }

        public void ResetTotalAmount()
        {
            // Reset Total Amount: 
            labelTotalAmount.Text = "";
            // Make Amount Tendered Blank: 
            textBoxAmountTendered.Text = "";
            labelChange.Text = "";
        }
    }
}
