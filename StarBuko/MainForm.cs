using System.ComponentModel;
using StarBuko.Models;
using StarBuko.Views;
using StarBuko.Presenters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StarBuko
{
    public partial class MainForm : Form, IMainForm
    {
        public event EventHandler<Product> OnProductClicked;
        public event EventHandler<string> OnAmountTenderedChanged;
  
        private MainPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            textBoxAmountTendered.TextChanged += (s, e) => OnAmountTenderedChanged?.Invoke(this, textBoxAmountTendered.Text);
            _presenter = new MainPresenter(this);
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
