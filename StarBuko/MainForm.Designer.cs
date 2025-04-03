
namespace StarBuko
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddNewItem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmountTendered = new System.Windows.Forms.TextBox();
            this.labelChange = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "StarBuko";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAddNewProduct);
            this.panel1.Controls.Add(this.buttonAddNewItem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 56);
            this.panel1.TabIndex = 1;
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNewItem.Location = new System.Drawing.Point(743, 13);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(179, 24);
            this.buttonAddNewItem.TabIndex = 2;
            this.buttonAddNewItem.Text = "Add New Transaction";
            this.buttonAddNewItem.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1171, 497);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(126, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 497);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(638, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 497);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textBoxAmountTendered);
            this.panel4.Controls.Add(this.labelChange);
            this.panel4.Controls.Add(this.labelTotalAmount);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 397);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(533, 100);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Change";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(21, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Tendered";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Amount";
            // 
            // textBoxAmountTendered
            // 
            this.textBoxAmountTendered.Location = new System.Drawing.Point(143, 39);
            this.textBoxAmountTendered.Name = "textBoxAmountTendered";
            this.textBoxAmountTendered.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmountTendered.TabIndex = 2;
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelChange.Location = new System.Drawing.Point(143, 76);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(38, 15);
            this.labelChange.TabIndex = 1;
            this.labelChange.Text = "₱ 0.00";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTotalAmount.Location = new System.Drawing.Point(143, 21);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(38, 15);
            this.labelTotalAmount.TabIndex = 0;
            this.labelTotalAmount.Text = "₱ 0.00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Quantity,
            this.Price,
            this.TotalPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(533, 497);
            this.dataGridView1.TabIndex = 0;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Qty";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Location = new System.Drawing.Point(964, 14);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(145, 23);
            this.buttonAddNewProduct.TabIndex = 3;
            this.buttonAddNewProduct.Text = "Add New Product";
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1171, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "StarBuko";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox textBoxAmountTendered;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddNewItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Button buttonAddNewProduct;
    }
}

