using System;
using System.Windows.Forms;
using Pizzeria.Core;
using Pizzeria.Core.Enums;
using Pizzeria.Data.Models;

namespace Pizzeria.UI
{
    public partial class LoginForm : Form
    {
        public string Login { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = UserHelper.ValidateUser(txtLogin.Text, txtPassword.Text);

            if (result == OperationResult.Success)
            {
                Login = txtLogin.Text;
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Złe dane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }
    }
}