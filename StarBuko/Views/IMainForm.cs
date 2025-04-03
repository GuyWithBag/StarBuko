using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarBuko.Models;

namespace StarBuko.Views
{
    public interface IMainForm
    {
        event EventHandler<Product> OnProductClicked;
        event EventHandler<string> OnAmountTenderedChanged;
        event EventHandler OnButtonAddNewItemClicked;
        event EventHandler OnButtonAddNewProductClicked;

        void DisplayProducts(List<Product> products);
        void DisplayLineItems(BindingList<LineItem> lineItems);
        void UpdateTotalAmount(decimal total);
        void UpdateChange(decimal change);
        void ResetTotalAmount();
    }
}
