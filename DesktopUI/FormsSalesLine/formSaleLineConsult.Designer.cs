namespace DesktopUI.FormsSalesLine
{
    partial class formSaleLineConsult
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
            label1 = new Label();
            label2 = new Label();
            lblProductId = new Label();
            lblProductName = new Label();
            lblProductAmount = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(99, 95);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 22;
            label3.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(122, 56);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 19;
            label1.Text = "Product ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(137, 136);
            label2.Name = "label2";
            label2.Size = new Size(57, 34);
            label2.TabIndex = 18;
            label2.Text = "Product \r\nAmount:";
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductId.Location = new Point(200, 56);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(22, 17);
            lblProductId.TabIndex = 23;
            lblProductId.Text = "lbl";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(200, 95);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(22, 17);
            lblProductName.TabIndex = 24;
            lblProductName.Text = "lbl";
            // 
            // lblProductAmount
            // 
            lblProductAmount.AutoSize = true;
            lblProductAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductAmount.Location = new Point(200, 147);
            lblProductAmount.Name = "lblProductAmount";
            lblProductAmount.Size = new Size(22, 17);
            lblProductAmount.TabIndex = 25;
            lblProductAmount.Text = "lbl";
            // 
            // formSaleLineConsult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 225);
            Controls.Add(lblProductAmount);
            Controls.Add(lblProductName);
            Controls.Add(lblProductId);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "formSaleLineConsult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formSaleLineConsult";
            Load += formSaleLineConsult_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblProductAmount;
    }
}