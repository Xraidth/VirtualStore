namespace DesktopUI.FormsSalesLine
{
    partial class formSaleLineAdd
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
            nudAmount = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            txtProductID = new TextBox();
            cbxProductName = new ComboBox();
            label3 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            btnApply = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            SuspendLayout();
            // 
            // nudAmount
            // 
            nudAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudAmount.Location = new Point(195, 128);
            nudAmount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(62, 25);
            nudAmount.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(132, 119);
            label2.Name = "label2";
            label2.Size = new Size(57, 34);
            label2.TabIndex = 12;
            label2.Text = "Product \r\nAmount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(217, 38);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 13;
            label1.Text = "Product ID:";
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductID.Location = new Point(217, 62);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(100, 25);
            txtProductID.TabIndex = 14;
            txtProductID.TextChanged += txtProductID_TextChanged;
            // 
            // cbxProductName
            // 
            cbxProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbxProductName.FormattingEnabled = true;
            cbxProductName.Location = new Point(48, 62);
            cbxProductName.Name = "cbxProductName";
            cbxProductName.Size = new Size(121, 25);
            cbxProductName.TabIndex = 15;
            cbxProductName.SelectedIndexChanged += cbxProductName_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 38);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 16;
            label3.Text = "Product Name:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(27, 188);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(154, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(277, 188);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 19;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // formSaleLineAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 225);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(cbxProductName);
            Controls.Add(txtProductID);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(nudAmount);
            Name = "formSaleLineAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formSaleLineAdd";
            Load += formSaleLineAdd_Load;
            Shown += formSaleLineAdd_Shown;
            KeyDown += formSaleLineAdd_KeyDown;
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudAmount;
        private Label label2;
        private Label label1;
        private TextBox txtProductID;
        private ComboBox cbxProductName;
        private Label label3;
        private Button btnCancel;
        private Button btnAdd;
        private Button btnApply;
    }
}