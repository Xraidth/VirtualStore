﻿namespace DesktopUI.Reports
{
    partial class formMenuReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            btnSalePerDay = new Button();
            btnStockPorce = new Button();
            btnSalesProductPorce = new Button();
            button3 = new Button();
            btnSalesPerMonth = new Button();
            SuspendLayout();
            // 
            // btnSalePerDay
            // 
            btnSalePerDay.Location = new Point(285, 44);
            btnSalePerDay.Name = "btnSalePerDay";
            btnSalePerDay.Size = new Size(240, 40);
            btnSalePerDay.TabIndex = 6;
            btnSalePerDay.Text = "Sales per Day";
            btnSalePerDay.UseVisualStyleBackColor = true;
            btnSalePerDay.Click += btnSalePerDay_Click;
            // 
            // btnStockPorce
            // 
            btnStockPorce.Location = new Point(12, 44);
            btnStockPorce.Name = "btnStockPorce";
            btnStockPorce.Size = new Size(240, 40);
            btnStockPorce.TabIndex = 7;
            btnStockPorce.Text = "Stock Procentage";
            btnStockPorce.UseVisualStyleBackColor = true;
            btnStockPorce.Click += btnStockPorce_Click;
            // 
            // btnSalesProductPorce
            // 
            btnSalesProductPorce.Location = new Point(12, 115);
            btnSalesProductPorce.Name = "btnSalesProductPorce";
            btnSalesProductPorce.Size = new Size(240, 40);
            btnSalesProductPorce.TabIndex = 8;
            btnSalesProductPorce.Text = "Sales Product Porcentage";
            btnSalesProductPorce.UseVisualStyleBackColor = true;
            btnSalesProductPorce.Click += btnSalesProductPorce_Click;
            // 
            // button3
            // 
            button3.Location = new Point(151, 316);
            button3.Name = "button3";
            button3.Size = new Size(240, 40);
            button3.TabIndex = 9;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnSalesPerMonth
            // 
            btnSalesPerMonth.Location = new Point(285, 115);
            btnSalesPerMonth.Name = "btnSalesPerMonth";
            btnSalesPerMonth.Size = new Size(240, 40);
            btnSalesPerMonth.TabIndex = 10;
            btnSalesPerMonth.Text = "Sales per Month";
            btnSalesPerMonth.UseVisualStyleBackColor = true;
            btnSalesPerMonth.Click += btnSalesPerMonth_Click;
            // 
            // formMenuReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 431);
            Controls.Add(btnSalesPerMonth);
            Controls.Add(button3);
            Controls.Add(btnSalesProductPorce);
            Controls.Add(btnStockPorce);
            Controls.Add(btnSalePerDay);
            Name = "formMenuReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formMenuReports";
            KeyDown += formMenuReports_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalePerDay;
        private Button btnStockPorce;
        private Button btnSalesProductPorce;
        private Button button3;
        private Button btnSalesPerMonth;
    }
}