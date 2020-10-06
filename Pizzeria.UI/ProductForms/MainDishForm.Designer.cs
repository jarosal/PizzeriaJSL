using System.ComponentModel;

namespace Pizzeria.UI.ProductForms
{
    partial class MainDishForm
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
            this.grpMainDishes = new System.Windows.Forms.GroupBox();
            this.radioDish5 = new System.Windows.Forms.RadioButton();
            this.radioDish4 = new System.Windows.Forms.RadioButton();
            this.radioDish3 = new System.Windows.Forms.RadioButton();
            this.radioDish2 = new System.Windows.Forms.RadioButton();
            this.radioDish1 = new System.Windows.Forms.RadioButton();
            this.grpAdditions = new System.Windows.Forms.GroupBox();
            this.checkSauce = new System.Windows.Forms.CheckBox();
            this.checkSalad = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpMainDishes.SuspendLayout();
            this.grpAdditions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMainDishes
            // 
            this.grpMainDishes.Controls.Add(this.radioDish5);
            this.grpMainDishes.Controls.Add(this.radioDish4);
            this.grpMainDishes.Controls.Add(this.radioDish3);
            this.grpMainDishes.Controls.Add(this.radioDish2);
            this.grpMainDishes.Controls.Add(this.radioDish1);
            this.grpMainDishes.Location = new System.Drawing.Point(12, 12);
            this.grpMainDishes.Name = "grpMainDishes";
            this.grpMainDishes.Size = new System.Drawing.Size(200, 172);
            this.grpMainDishes.TabIndex = 0;
            this.grpMainDishes.TabStop = false;
            this.grpMainDishes.Text = "Dania główne";
            // 
            // radioDish5
            // 
            this.radioDish5.Location = new System.Drawing.Point(6, 139);
            this.radioDish5.Name = "radioDish5";
            this.radioDish5.Size = new System.Drawing.Size(188, 24);
            this.radioDish5.TabIndex = 4;
            this.radioDish5.TabStop = true;
            this.radioDish5.Tag = "27";
            this.radioDish5.Text = "Placek po węgiersku";
            this.radioDish5.UseVisualStyleBackColor = true;
            // 
            // radioDish4
            // 
            this.radioDish4.Location = new System.Drawing.Point(6, 109);
            this.radioDish4.Name = "radioDish4";
            this.radioDish4.Size = new System.Drawing.Size(104, 24);
            this.radioDish4.TabIndex = 3;
            this.radioDish4.TabStop = true;
            this.radioDish4.Tag = "28";
            this.radioDish4.Text = "Ryba z frytkami";
            this.radioDish4.UseVisualStyleBackColor = true;
            // 
            // radioDish3
            // 
            this.radioDish3.Location = new System.Drawing.Point(6, 79);
            this.radioDish3.Name = "radioDish3";
            this.radioDish3.Size = new System.Drawing.Size(188, 24);
            this.radioDish3.TabIndex = 2;
            this.radioDish3.TabStop = true;
            this.radioDish3.Tag = "30";
            this.radioDish3.Text = "Schabowy z ziemniakami";
            this.radioDish3.UseVisualStyleBackColor = true;
            // 
            // radioDish2
            // 
            this.radioDish2.Location = new System.Drawing.Point(6, 49);
            this.radioDish2.Name = "radioDish2";
            this.radioDish2.Size = new System.Drawing.Size(188, 24);
            this.radioDish2.TabIndex = 1;
            this.radioDish2.TabStop = true;
            this.radioDish2.Tag = "30";
            this.radioDish2.Text = "Schabowy z ryżem";
            this.radioDish2.UseVisualStyleBackColor = true;
            // 
            // radioDish1
            // 
            this.radioDish1.Location = new System.Drawing.Point(6, 19);
            this.radioDish1.Name = "radioDish1";
            this.radioDish1.Size = new System.Drawing.Size(188, 24);
            this.radioDish1.TabIndex = 0;
            this.radioDish1.TabStop = true;
            this.radioDish1.Tag = "30";
            this.radioDish1.Text = "Schabowy z frytkami";
            this.radioDish1.UseVisualStyleBackColor = true;
            // 
            // grpAdditions
            // 
            this.grpAdditions.Controls.Add(this.checkSauce);
            this.grpAdditions.Controls.Add(this.checkSalad);
            this.grpAdditions.Location = new System.Drawing.Point(12, 190);
            this.grpAdditions.Name = "grpAdditions";
            this.grpAdditions.Size = new System.Drawing.Size(200, 82);
            this.grpAdditions.TabIndex = 1;
            this.grpAdditions.TabStop = false;
            this.grpAdditions.Text = "Dodatki do dań głównych";
            // 
            // checkSauce
            // 
            this.checkSauce.Location = new System.Drawing.Point(6, 49);
            this.checkSauce.Name = "checkSauce";
            this.checkSauce.Size = new System.Drawing.Size(104, 24);
            this.checkSauce.TabIndex = 1;
            this.checkSauce.Tag = "6";
            this.checkSauce.Text = "Zestaw sosów";
            this.checkSauce.UseVisualStyleBackColor = true;
            // 
            // checkSalad
            // 
            this.checkSalad.Location = new System.Drawing.Point(6, 19);
            this.checkSalad.Name = "checkSalad";
            this.checkSalad.Size = new System.Drawing.Size(104, 24);
            this.checkSalad.TabIndex = 0;
            this.checkSalad.Tag = "5";
            this.checkSalad.Text = "Bar sałatkowy";
            this.checkSalad.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(75, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 311);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpAdditions);
            this.Controls.Add(this.grpMainDishes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDishForm";
            this.Text = "Dania główne";
            this.grpMainDishes.ResumeLayout(false);
            this.grpAdditions.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox checkSauce;

        private System.Windows.Forms.CheckBox checkSalad;
        private System.Windows.Forms.GroupBox grpAdditions;

        private System.Windows.Forms.RadioButton radioDish1;
        private System.Windows.Forms.RadioButton radioDish2;
        private System.Windows.Forms.RadioButton radioDish3;
        private System.Windows.Forms.RadioButton radioDish4;
        private System.Windows.Forms.RadioButton radioDish5;

        private System.Windows.Forms.GroupBox grpMainDishes;

        #endregion
    }
}