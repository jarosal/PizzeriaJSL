using System.ComponentModel;

namespace Pizzeria.UI
{
    partial class MainForm
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
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnMaindish = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnSoup = new System.Windows.Forms.Button();
            this.grpBasket = new System.Windows.Forms.GroupBox();
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBasket.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(12, 12);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(100, 23);
            this.btnPizza.TabIndex = 0;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnMaindish
            // 
            this.btnMaindish.Location = new System.Drawing.Point(12, 41);
            this.btnMaindish.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaindish.Name = "btnMaindish";
            this.btnMaindish.Size = new System.Drawing.Size(100, 23);
            this.btnMaindish.TabIndex = 1;
            this.btnMaindish.Text = "Dania główne";
            this.btnMaindish.UseVisualStyleBackColor = true;
            this.btnMaindish.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(12, 99);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(100, 23);
            this.btnDrinks.TabIndex = 3;
            this.btnDrinks.Text = "Napoje";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnSoup
            // 
            this.btnSoup.Location = new System.Drawing.Point(12, 70);
            this.btnSoup.Name = "btnSoup";
            this.btnSoup.Size = new System.Drawing.Size(100, 23);
            this.btnSoup.TabIndex = 4;
            this.btnSoup.Text = "Zupy";
            this.btnSoup.UseVisualStyleBackColor = true;
            this.btnSoup.Click += new System.EventHandler(this.btnSoup_Click);
            // 
            // grpBasket
            // 
            this.grpBasket.Controls.Add(this.tablePanel);
            this.grpBasket.Location = new System.Drawing.Point(118, 12);
            this.grpBasket.Name = "grpBasket";
            this.grpBasket.Size = new System.Drawing.Size(200, 217);
            this.grpBasket.TabIndex = 5;
            this.grpBasket.TabStop = false;
            this.grpBasket.Text = "Koszyk";
            // 
            // tablePanel
            // 
            this.tablePanel.ColumnCount = 1;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(3, 16);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 9;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanel.Size = new System.Drawing.Size(194, 198);
            this.tablePanel.TabIndex = 0;
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.lblAmount.Location = new System.Drawing.Point(158, 235);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 23);
            this.lblAmount.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(243, 235);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(324, 38);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(211, 188);
            this.txtNote.TabIndex = 8;
            this.txtNote.Text = "";
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(387, 12);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(148, 23);
            this.lblNote.TabIndex = 9;
            this.lblNote.Text = "Uwagi do zamówienia";
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(12, 235);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(100, 23);
            this.btnHistory.TabIndex = 10;
            this.btnHistory.Text = "Historia zamówień";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(324, 235);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(211, 23);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Złóż zamówienie";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(121, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kwota: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.grpBasket);
            this.Controls.Add(this.btnSoup);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnMaindish);
            this.Controls.Add(this.btnPizza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pizzeria";
            this.grpBasket.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnOrder;

        private System.Windows.Forms.Button btnHistory;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Label lblNote;

        private System.Windows.Forms.RichTextBox txtNote;

        private System.Windows.Forms.TableLayoutPanel tablePanel;

        private System.Windows.Forms.Label lblAmount;

        private System.Windows.Forms.GroupBox grpBasket;

        private System.Windows.Forms.Button btnDrinks;

        private System.Windows.Forms.Button btnMaindish;

        private System.Windows.Forms.Button btnSoup;

        private System.Windows.Forms.Button btnPizza;

        #endregion
    }
}