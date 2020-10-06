using System;
using System.Windows.Forms;
using Pizzeria.Core;
using Pizzeria.Core.Enums;

namespace Pizzeria.UI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void btnRRegister_Click(object sender, EventArgs e)
        {
            var result = UserHelper.AddUser(
                txtRLogin.Text, 
                txtRPassword.Text, 
                txtRFirstname.Text, 
                txtRLastname.Text,
                txtREmail.Text, 
                txtRAddress.Text, 
                txtRPhone.Text
                );

            if (result == OperationResult.Success)
            {
                MessageBox.Show("Użytkownik stworzony!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Login zajęty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}