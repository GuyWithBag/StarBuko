using System.Drawing;
using System.Windows.Forms;

namespace StarBuko
{
    partial class ProductControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productPhoto = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // productPhoto
            // 
            this.productPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.productPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.productPhoto.Enabled = false;
            this.productPhoto.Location = new System.Drawing.Point(0, 0);
            this.productPhoto.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productPhoto.Name = "productPhoto";
            this.productPhoto.Size = new System.Drawing.Size(156, 138);
            this.productPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPhoto.TabIndex = 0;
            this.productPhoto.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProductName.Location = new System.Drawing.Point(159, 19);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(233, 76);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductPrice.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProductPrice.Location = new System.Drawing.Point(252, 101);
            this.labelProductPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(140, 37);
            this.labelProductPrice.TabIndex = 2;
            this.labelProductPrice.Text = "$ 5.00";
            this.labelProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(53)))), ((int)(((byte)(44)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelProductPrice);
            this.Controls.Add(this.productPhoto);
            this.Controls.Add(this.labelProductName);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(393, 138);
            ((System.ComponentModel.ISupportInitialize)(this.productPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox productPhoto;
        private Label labelProductName;
        private Label labelProductPrice;
    }
}
