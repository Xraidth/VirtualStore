namespace DesktopUI.FormsSalesLine
{
    partial class formSaleLineAddFaster
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
            txtProductID = new TextBox();
            label1 = new Label();
            nudAmount = new NumericUpDown();
            label2 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            SuspendLayout();
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductID.Location = new Point(32, 42);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(100, 25);
            txtProductID.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 16;
            label1.Text = "Product ID:";
            // 
            // nudAmount
            // 
            nudAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudAmount.Location = new Point(201, 42);
            nudAmount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(62, 25);
            nudAmount.TabIndex = 17;
            nudAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(173, 9);
            label2.Name = "label2";
            label2.Size = new Size(105, 17);
            label2.TabIndex = 18;
            label2.Text = "Product Amount:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(351, 42);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // formSaleLineAddFaster
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 97);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(nudAmount);
            Controls.Add(label1);
            Controls.Add(txtProductID);
            Name = "formSaleLineAddFaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formSaleLineAddFaster";
            Load += formSaleLineAddFaster_Load;
            KeyDown += formSaleLineAddFaster_KeyDown;
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductID;
        private Label label1;
        private NumericUpDown nudAmount;
        private Label label2;
        private Button btnAdd;
    }
}