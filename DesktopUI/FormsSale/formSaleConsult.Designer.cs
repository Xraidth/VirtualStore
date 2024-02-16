namespace DesktopUI.FormsSale
{
    partial class formSaleConsult
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
            lbl10 = new Label();
            lbl11 = new Label();
            lbl12 = new Label();
            lblSaleId = new Label();
            lblUserName = new Label();
            lblSaleDay = new Label();
            lblTotal = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbl10
            // 
            lbl10.AutoSize = true;
            lbl10.Location = new Point(126, 60);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(41, 15);
            lbl10.TabIndex = 3;
            lbl10.Text = "SaleId:";
            // 
            // lbl11
            // 
            lbl11.AutoSize = true;
            lbl11.Location = new Point(102, 104);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(65, 15);
            lbl11.TabIndex = 4;
            lbl11.Text = "UserName:";
            // 
            // lbl12
            // 
            lbl12.AutoSize = true;
            lbl12.Location = new Point(116, 155);
            lbl12.Name = "lbl12";
            lbl12.Size = new Size(51, 15);
            lbl12.TabIndex = 5;
            lbl12.Text = "SaleDay:";
            // 
            // lblSaleId
            // 
            lblSaleId.AutoSize = true;
            lblSaleId.Location = new Point(210, 60);
            lblSaleId.Name = "lblSaleId";
            lblSaleId.Size = new Size(20, 15);
            lblSaleId.TabIndex = 6;
            lblSaleId.Text = "lbl";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(210, 104);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(20, 15);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "lbl";
            // 
            // lblSaleDay
            // 
            lblSaleDay.AutoSize = true;
            lblSaleDay.Location = new Point(210, 156);
            lblSaleDay.Name = "lblSaleDay";
            lblSaleDay.Size = new Size(20, 15);
            lblSaleDay.TabIndex = 8;
            lblSaleDay.Text = "lbl";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(210, 201);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(20, 15);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "lbl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 201);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 9;
            label2.Text = "Total:";
            // 
            // formSaleConsult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 297);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(lblSaleDay);
            Controls.Add(lblUserName);
            Controls.Add(lblSaleId);
            Controls.Add(lbl12);
            Controls.Add(lbl11);
            Controls.Add(lbl10);
            Name = "formSaleConsult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formSaleConsult";
            Load += formSaleConsult_Load;
            KeyDown += formSaleConsult_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl10;
        private Label lbl11;
        private Label lbl12;
        private Label lblSaleId;
        private Label lblUserName;
        private Label lblSaleDay;
        private Label lblTotal;
        private Label label2;
    }
}