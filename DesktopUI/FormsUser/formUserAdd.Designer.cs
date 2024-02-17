namespace DesktopUI.FormsUser
{
    partial class formUserAdd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            txtUserName = new TextBox();
            txtPass = new TextBox();
            txtConPass = new TextBox();
            btnApply = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 81);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 7;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 129);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 172);
            label3.Name = "label3";
            label3.Size = new Size(60, 30);
            label3.TabIndex = 9;
            label3.Text = "Confirm \r\nPassword:\r\n";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(106, 286);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(17, 286);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(114, 78);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 12;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(114, 126);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 13;
            // 
            // txtConPass
            // 
            txtConPass.Location = new Point(112, 182);
            txtConPass.Name = "txtConPass";
            txtConPass.PasswordChar = '*';
            txtConPass.Size = new Size(100, 23);
            txtConPass.TabIndex = 14;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(201, 286);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 17;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // formUserAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 339);
            Controls.Add(btnApply);
            Controls.Add(txtConPass);
            Controls.Add(txtPass);
            Controls.Add(txtUserName);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formUserAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formUserAdd";
            Load += formUserAdd_Load;
            Shown += formUserAdd_Shown;
            KeyDown += formUserAdd_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnCancel;
        private TextBox txtUserName;
        private TextBox txtPass;
        private TextBox txtConPass;
        private Button btnApply;
    }
}