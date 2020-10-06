using System.ComponentModel;

namespace Pizzeria.UI.ProductForms
{
    partial class SoupsForm
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
            this.grpSoups = new System.Windows.Forms.GroupBox();
            this.radioSoup2 = new System.Windows.Forms.RadioButton();
            this.radioSoup1 = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpSoups.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSoups
            // 
            this.grpSoups.Controls.Add(this.radioSoup2);
            this.grpSoups.Controls.Add(this.radioSoup1);
            this.grpSoups.Location = new System.Drawing.Point(12, 12);
            this.grpSoups.Name = "grpSoups";
            this.grpSoups.Size = new System.Drawing.Size(200, 81);
            this.grpSoups.TabIndex = 0;
            this.grpSoups.TabStop = false;
            this.grpSoups.Text = "Zupy";
            // 
            // radioSoup2
            // 
            this.radioSoup2.Location = new System.Drawing.Point(6, 49);
            this.radioSoup2.Name = "radioSoup2";
            this.radioSoup2.Size = new System.Drawing.Size(104, 24);
            this.radioSoup2.TabIndex = 1;
            this.radioSoup2.TabStop = true;
            this.radioSoup2.Tag = "10";
            this.radioSoup2.Text = "Rosół";
            this.radioSoup2.UseVisualStyleBackColor = true;
            // 
            // radioSoup1
            // 
            this.radioSoup1.Location = new System.Drawing.Point(6, 19);
            this.radioSoup1.Name = "radioSoup1";
            this.radioSoup1.Size = new System.Drawing.Size(104, 24);
            this.radioSoup1.TabIndex = 0;
            this.radioSoup1.TabStop = true;
            this.radioSoup1.Tag = "12";
            this.radioSoup1.Text = "Pomidorowa";
            this.radioSoup1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(71, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // SoupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 126);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpSoups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoupsForm";
            this.Text = "Zupy";
            this.grpSoups.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpSoups;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton radioSoup1;
        private System.Windows.Forms.RadioButton radioSoup2;

        #endregion
    }
}