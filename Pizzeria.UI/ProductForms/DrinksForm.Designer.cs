using System.ComponentModel;

namespace Pizzeria.UI.ProductForms
{
    partial class DrinksForm
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
            this.grpDrinks = new System.Windows.Forms.GroupBox();
            this.radioDrink3 = new System.Windows.Forms.RadioButton();
            this.radioDrink2 = new System.Windows.Forms.RadioButton();
            this.radioDrink1 = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpDrinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDrinks
            // 
            this.grpDrinks.Controls.Add(this.radioDrink3);
            this.grpDrinks.Controls.Add(this.radioDrink2);
            this.grpDrinks.Controls.Add(this.radioDrink1);
            this.grpDrinks.Location = new System.Drawing.Point(12, 12);
            this.grpDrinks.Name = "grpDrinks";
            this.grpDrinks.Size = new System.Drawing.Size(200, 113);
            this.grpDrinks.TabIndex = 0;
            this.grpDrinks.TabStop = false;
            this.grpDrinks.Text = "Napoje";
            // 
            // radioDrink3
            // 
            this.radioDrink3.Location = new System.Drawing.Point(6, 77);
            this.radioDrink3.Name = "radioDrink3";
            this.radioDrink3.Size = new System.Drawing.Size(104, 24);
            this.radioDrink3.TabIndex = 1;
            this.radioDrink3.TabStop = true;
            this.radioDrink3.Tag = "5";
            this.radioDrink3.Text = "Cola";
            this.radioDrink3.UseVisualStyleBackColor = true;
            // 
            // radioDrink2
            // 
            this.radioDrink2.Location = new System.Drawing.Point(6, 49);
            this.radioDrink2.Name = "radioDrink2";
            this.radioDrink2.Size = new System.Drawing.Size(104, 24);
            this.radioDrink2.TabIndex = 1;
            this.radioDrink2.TabStop = true;
            this.radioDrink2.Tag = "5";
            this.radioDrink2.Text = "Herbata";
            this.radioDrink2.UseVisualStyleBackColor = true;
            // 
            // radioDrink1
            // 
            this.radioDrink1.Location = new System.Drawing.Point(6, 19);
            this.radioDrink1.Name = "radioDrink1";
            this.radioDrink1.Size = new System.Drawing.Size(104, 24);
            this.radioDrink1.TabIndex = 0;
            this.radioDrink1.TabStop = true;
            this.radioDrink1.Tag = "5";
            this.radioDrink1.Text = "Kawa";
            this.radioDrink1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DrinksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 159);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpDrinks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrinksForm";
            this.Text = "Napoje";
            this.grpDrinks.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpDrinks;
        private System.Windows.Forms.RadioButton radioDrink1;
        private System.Windows.Forms.RadioButton radioDrink2;
        private System.Windows.Forms.RadioButton radioDrink3;

        #endregion
    }
}