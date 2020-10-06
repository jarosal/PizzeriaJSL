using System;
using System.Windows.Forms;
using Pizzeria.Core;
using Pizzeria.Data.Models;

namespace Pizzeria.UI.ProductForms
{
    public partial class PizzaForm : Form
    {
        private Order _order;

        public PizzaForm(Order order)
        {
            InitializeComponent();
            _order = order;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderHelper.AddProductToOrder(_order, grpPizza, grpToppings);
            this.Close();
        }
    }
}