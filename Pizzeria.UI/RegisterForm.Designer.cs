using System.ComponentModel;

namespace Pizzeria.UI
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogin2 = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtRLogin = new System.Windows.Forms.TextBox();
            this.txtRPassword = new System.Windows.Forms.TextBox();
            this.txtRFirstname = new System.Windows.Forms.TextBox();
            this.txtRLastname = new System.Windows.Forms.TextBox();
            this.txtREmail = new System.Windows.Forms.TextBox();
            this.txtRAddress = new System.Windows.Forms.TextBox();
            this.txtRPhone = new System.Windows.Forms.TextBox();
            this.btnRRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin2
            // 
            this.lblLogin2.Location = new System.Drawing.Point(12, 9);
            this.lblLogin2.Name = "lblLogin2";
            this.lblLogin2.Size = new System.Drawing.Size(100, 23);
            this.lblLogin2.TabIndex = 0;
            this.lblLogin2.Text = "Login";
            // 
            // lblPassword2
            // 
            this.lblPassword2.Location = new System.Drawing.Point(12, 32);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(100, 23);
            this.lblPassword2.TabIndex = 1;
            this.lblPassword2.Text = "Hasło";
            // 
            // lblFirstname
            // 
            this.lblFirstname.Location = new System.Drawing.Point(12, 55);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(100, 23);
            this.lblFirstname.TabIndex = 2;
            this.lblFirstname.Text = "Imię";
            // 
            // lblLastname
            // 
            this.lblLastname.Location = new System.Drawing.Point(12, 78);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(100, 23);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Nazwisko";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(12, 124);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Adres";
            // 
            // lblPhone
            // 
            this.lblPhone.Location = new System.Drawing.Point(12, 147);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 23);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(12, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // txtRLogin
            // 
            this.txtRLogin.Location = new System.Drawing.Point(75, 6);
            this.txtRLogin.Name = "txtRLogin";
            this.txtRLogin.Size = new System.Drawing.Size(97, 20);
            this.txtRLogin.TabIndex = 7;
            // 
            // txtRPassword
            // 
            this.txtRPassword.Location = new System.Drawing.Point(75, 29);
            this.txtRPassword.Name = "txtRPassword";
            this.txtRPassword.Size = new System.Drawing.Size(97, 20);
            this.txtRPassword.TabIndex = 9;
            this.txtRPassword.UseSystemPasswordChar = true;
            // 
            // txtRFirstname
            // 
            this.txtRFirstname.Location = new System.Drawing.Point(75, 52);
            this.txtRFirstname.Name = "txtRFirstname";
            this.txtRFirstname.Size = new System.Drawing.Size(97, 20);
            this.txtRFirstname.TabIndex = 10;
            // 
            // txtRLastname
            // 
            this.txtRLastname.Location = new System.Drawing.Point(75, 75);
            this.txtRLastname.Name = "txtRLastname";
            this.txtRLastname.Size = new System.Drawing.Size(97, 20);
            this.txtRLastname.TabIndex = 11;
            // 
            // txtREmail
            // 
            this.txtREmail.Location = new System.Drawing.Point(75, 98);
            this.txtREmail.Name = "txtREmail";
            this.txtREmail.Size = new System.Drawing.Size(97, 20);
            this.txtREmail.TabIndex = 12;
            // 
            // txtRAddress
            // 
            this.txtRAddress.Location = new System.Drawing.Point(75, 121);
            this.txtRAddress.Name = "txtRAddress";
            this.txtRAddress.Size = new System.Drawing.Size(97, 20);
            this.txtRAddress.TabIndex = 13;
            // 
            // txtRPhone
            // 
            this.txtRPhone.Location = new System.Drawing.Point(75, 144);
            this.txtRPhone.Name = "txtRPhone";
            this.txtRPhone.Size = new System.Drawing.Size(97, 20);
            this.txtRPhone.TabIndex = 14;
            // 
            // btnRRegister
            // 
            this.btnRRegister.Location = new System.Drawing.Point(42, 185);
            this.btnRRegister.Name = "btnRRegister";
            this.btnRRegister.Size = new System.Drawing.Size(105, 24);
            this.btnRRegister.TabIndex = 15;
            this.btnRRegister.Text = "Zarejestruj";
            this.btnRRegister.UseVisualStyleBackColor = true;
            this.btnRRegister.Click += new System.EventHandler(this.btnRRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 221);
            this.Controls.Add(this.btnRRegister);
            this.Controls.Add(this.txtRPhone);
            this.Controls.Add(this.txtRAddress);
            this.Controls.Add(this.txtREmail);
            this.Controls.Add(this.txtRLastname);
            this.Controls.Add(this.txtRFirstname);
            this.Controls.Add(this.txtRPassword);
            this.Controls.Add(this.txtRLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.lblLogin2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "Rejestracja";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        

        private System.Windows.Forms.TextBox txtRPassword;

        private System.Windows.Forms.Button btnRRegister;

        private System.Windows.Forms.TextBox txtRAddress;
        private System.Windows.Forms.TextBox txtREmail;
        private System.Windows.Forms.TextBox txtRFirstname;
        private System.Windows.Forms.TextBox txtRLastname;
        private System.Windows.Forms.TextBox txtRPhone;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtRLogin;

        private System.Windows.Forms.Label lblAddress;

        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastname;

        private System.Windows.Forms.Label lblPassword2;

        private System.Windows.Forms.Label lblLogin2;

        #endregion
    }
}