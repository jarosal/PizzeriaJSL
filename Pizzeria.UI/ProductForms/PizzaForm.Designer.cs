using System.ComponentModel;

namespace Pizzeria.UI.ProductForms
{
    partial class PizzaForm
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
            this.grpPizza = new System.Windows.Forms.GroupBox();
            this.radioPizza4 = new System.Windows.Forms.RadioButton();
            this.radioPizza3 = new System.Windows.Forms.RadioButton();
            this.radioPizza2 = new System.Windows.Forms.RadioButton();
            this.radioPizza1 = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.checkShrooms = new System.Windows.Forms.CheckBox();
            this.checkSzynka = new System.Windows.Forms.CheckBox();
            this.checkSalami = new System.Windows.Forms.CheckBox();
            this.checkCheese = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpPizza.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPizza
            // 
            this.grpPizza.Controls.Add(this.radioPizza4);
            this.grpPizza.Controls.Add(this.radioPizza3);
            this.grpPizza.Controls.Add(this.radioPizza2);
            this.grpPizza.Controls.Add(this.radioPizza1);
            this.grpPizza.Location = new System.Drawing.Point(12, 12);
            this.grpPizza.Name = "grpPizza";
            this.grpPizza.Size = new System.Drawing.Size(200, 153);
            this.grpPizza.TabIndex = 0;
            this.grpPizza.TabStop = false;
            this.grpPizza.Text = "Wybierz rodzaj pizzy";
            // 
            // radioPizza4
            // 
            this.radioPizza4.Location = new System.Drawing.Point(6, 109);
            this.radioPizza4.Name = "radioPizza4";
            this.radioPizza4.Size = new System.Drawing.Size(104, 24);
            this.radioPizza4.TabIndex = 3;
            this.radioPizza4.Tag = "25";
            this.radioPizza4.Text = "Venecia";
            this.radioPizza4.UseVisualStyleBackColor = true;
            // 
            // radioPizza3
            // 
            this.radioPizza3.Location = new System.Drawing.Point(6, 79);
            this.radioPizza3.Name = "radioPizza3";
            this.radioPizza3.Size = new System.Drawing.Size(104, 24);
            this.radioPizza3.TabIndex = 2;
            this.radioPizza3.Tag = "25";
            this.radioPizza3.Text = "Tosca";
            this.radioPizza3.UseVisualStyleBackColor = true;
            // 
            // radioPizza2
            // 
            this.radioPizza2.Location = new System.Drawing.Point(6, 49);
            this.radioPizza2.Name = "radioPizza2";
            this.radioPizza2.Size = new System.Drawing.Size(104, 24);
            this.radioPizza2.TabIndex = 1;
            this.radioPizza2.Tag = "22";
            this.radioPizza2.Text = "Vegetariana";
            this.radioPizza2.UseVisualStyleBackColor = true;
            // 
            // radioPizza1
            // 
            this.radioPizza1.Location = new System.Drawing.Point(6, 19);
            this.radioPizza1.Name = "radioPizza1";
            this.radioPizza1.Size = new System.Drawing.Size(104, 24);
            this.radioPizza1.TabIndex = 0;
            this.radioPizza1.Tag = "20";
            this.radioPizza1.Text = "Margheritta";
            this.radioPizza1.UseVisualStyleBackColor = true;
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.checkShrooms);
            this.grpToppings.Controls.Add(this.checkSzynka);
            this.grpToppings.Controls.Add(this.checkSalami);
            this.grpToppings.Controls.Add(this.checkCheese);
            this.grpToppings.Location = new System.Drawing.Point(12, 171);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(200, 160);
            this.grpToppings.TabIndex = 1;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Wybierz dodatki - 2 zł";
            // 
            // checkShrooms
            // 
            this.checkShrooms.Location = new System.Drawing.Point(6, 109);
            this.checkShrooms.Name = "checkShrooms";
            this.checkShrooms.Size = new System.Drawing.Size(104, 24);
            this.checkShrooms.TabIndex = 3;
            this.checkShrooms.Tag = "2";
            this.checkShrooms.Text = "Pieczkarki";
            this.checkShrooms.UseVisualStyleBackColor = true;
            // 
            // checkSzynka
            // 
            this.checkSzynka.Location = new System.Drawing.Point(6, 79);
            this.checkSzynka.Name = "checkSzynka";
            this.checkSzynka.Size = new System.Drawing.Size(104, 24);
            this.checkSzynka.TabIndex = 2;
            this.checkSzynka.Tag = "2";
            this.checkSzynka.Text = "Szynka";
            this.checkSzynka.UseVisualStyleBackColor = true;
            // 
            // checkSalami
            // 
            this.checkSalami.Location = new System.Drawing.Point(6, 49);
            this.checkSalami.Name = "checkSalami";
            this.checkSalami.Size = new System.Drawing.Size(104, 24);
            this.checkSalami.TabIndex = 1;
            this.checkSalami.Tag = "2";
            this.checkSalami.Text = "Salami";
            this.checkSalami.UseVisualStyleBackColor = true;
            // 
            // checkCheese
            // 
            this.checkCheese.Location = new System.Drawing.Point(6, 19);
            this.checkCheese.Name = "checkCheese";
            this.checkCheese.Size = new System.Drawing.Size(104, 24);
            this.checkCheese.TabIndex = 0;
            this.checkCheese.Tag = "2";
            this.checkCheese.Text = "Podwójny ser";
            this.checkCheese.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 365);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpPizza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PizzaForm";
            this.Text = "Pizza";
            this.grpPizza.ResumeLayout(false);
            this.grpToppings.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpPizza;
        private System.Windows.Forms.GroupBox grpToppings;

        private System.Windows.Forms.CheckBox checkCheese;
        private System.Windows.Forms.CheckBox checkSalami;
        private System.Windows.Forms.CheckBox checkShrooms;
        private System.Windows.Forms.CheckBox checkSzynka;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.RadioButton radioPizza4;

        private System.Windows.Forms.RadioButton radioPizza1;
        private System.Windows.Forms.RadioButton radioPizza2;
        private System.Windows.Forms.RadioButton radioPizza3;

        #endregion
    }
}