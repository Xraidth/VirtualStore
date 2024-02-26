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
            label3 = new Label();
            lblProductName = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            SuspendLayout();
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductID.Location = new Point(153, 42);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(100, 25);
            txtProductID.TabIndex = 15;
            txtProductID.TextChanged += txtProductID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(165, 15);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 16;
            label1.Text = "Product ID:";
            // 
            // nudAmount
            // 
            nudAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudAmount.Location = new Point(311, 41);
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
            label2.Location = new Point(291, 15);
            label2.Name = "label2";
            label2.Size = new Size(105, 17);
            label2.TabIndex = 18;
            label2.Text = "Product Amount:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(443, 34);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 36);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 15);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 21;
            label3.Text = "Product Name:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.ForeColor = Color.Black;
            lblProductName.Location = new Point(26, 44);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(53, 17);
            lblProductName.TabIndex = 22;
            lblProductName.Text = "Product";
            // 
            // formSaleLineAddFaster
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 102);
            Controls.Add(lblProductName);
            Controls.Add(label3);
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
        private Label label3;
        private Label lblProductName;
    }
}