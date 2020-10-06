using System;
using System.Windows.Forms;
using Pizzeria.Core;
using Pizzeria.Data.Models;

namespace Pizzeria.UI
{
    public partial class OrderForm : Form
    {
        private Order _order;
        private User _user;

        public OrderForm(Order order, User user)
        {
            InitializeComponent();
            _order = order;
            _user = user;

            txtFirstName.Text = user.Firstname;
            txtLastName.Text = user.Lastname;
            txtEmail.Text = user.Email;
            txtAddress.Text = user.Address;
            txtPhone.Text = user.Phone;
        }


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            _user.Firstname = txtFirstName.Text;
            _user.Lastname = txtLastName.Text;
            _user.Email = txtEmail.Text;
            _user.Address = txtAddress.Text;
            _user.Phone = txtPhone.Text;

            OrderHelper.PlaceOrder(_user, _order);

            var body = EmailHelper.BuildEmailBody(_user, _order);
            EmailHelper.SendEmail(body, _user.Email);

            Application.Exit();
        }
    }
}