using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Pizzeria.Core;
using Pizzeria.Data.Models;
using Pizzeria.UI.ProductForms;

namespace Pizzeria.UI
{
    public partial class MainForm : Form
    {
        private Order order;
        private User user;


        public MainForm()
        {
            InitializeComponent();
            order = new Order();
            user = new User();

            this.Hide();

            LoginForm fLogin = new LoginForm();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                user = UserHelper.LoginUser(fLogin.Login);
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }


        private void btnPizza_Click(object sender, EventArgs e)
        {
            PizzaForm fPizza = new PizzaForm(order);
            ProcessProductForm(fPizza);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainDishForm fMainDish = new MainDishForm(order);
            ProcessProductForm(fMainDish);
        }

        private void btnSoup_Click(object sender, EventArgs e)
        {
            SoupsForm fSoups = new SoupsForm(order);
            ProcessProductForm(fSoups);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            DrinksForm fDrinks = new DrinksForm(order);
            ProcessProductForm(fDrinks);
        }

        private void ProcessProductForm(Form form)
        {
            form.ShowDialog();
            BasketHelper.UpdateBasket(tablePanel, order);
            BasketHelper.UpdatePrice(lblAmount, OrderHelper.CalculatePrice(order));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OrderHelper.RemoveProduct(order, tablePanel);
            BasketHelper.UpdateBasket(tablePanel, order);
            BasketHelper.UpdatePrice(lblAmount, OrderHelper.CalculatePrice(order));
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderHelper.AddNoteToOrder(order, txtNote.Text);

            OrderForm fOrder = new OrderForm(order, user);
            fOrder.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm fHistory = new HistoryForm(user);
            fHistory.ShowDialog();
        }
    }
}