namespace DesktopUI.FormsProduct
{
    partial class formProductConsult
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblName = new Label();
            lblStock = new Label();
            lblPrice = new Label();
            label4 = new Label();
            lblID = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 186);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 17;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 134);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 16;
            label2.Text = "Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 86);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 14;
            label1.Text = "Name:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(142, 86);
            lblName.Name = "lblName";
            lblName.Size = new Size(20, 15);
            lblName.TabIndex = 18;
            lblName.Text = "lbl";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(142, 134);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(20, 15);
            lblStock.TabIndex = 19;
            lblStock.Text = "lbl";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(142, 186);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(20, 15);
            lblPrice.TabIndex = 20;
            lblPrice.Text = "lbl";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 44);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 21;
            label4.Text = "ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(142, 44);
            lblID.Name = "lblID";
            lblID.Size = new Size(20, 15);
            lblID.TabIndex = 22;
            lblID.Text = "lbl";
            // 
            // formProductConsult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 265);
            Controls.Add(lblID);
            Controls.Add(label4);
            Controls.Add(lblPrice);
            Controls.Add(lblStock);
            Controls.Add(lblName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formProductConsult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formProductConsult";
            Load += formProductConsult_Load;
            KeyDown += formProductConsult_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblName;
        private Label lblStock;
        private Label lblPrice;
        private Label label4;
        private Label lblID;
    }
}