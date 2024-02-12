namespace DesktopUI
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            lblUserName = new Label();
            txtUserName = new TextBox();
            txtPass = new TextBox();
            lblPass = new Label();
            label1 = new Label();
            btnSignin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(56, 79);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(87, 21);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "UserName:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(163, 76);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(168, 29);
            txtUserName.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(163, 120);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(168, 29);
            txtPass.TabIndex = 3;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPass.Location = new Point(64, 123);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(79, 21);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 28);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 4;
            label1.Text = "\"Wellcome to VirtualStore\"";
            // 
            // btnSignin
            // 
            btnSignin.Location = new Point(296, 188);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(75, 23);
            btnSignin.TabIndex = 5;
            btnSignin.Text = "Sign in";
            btnSignin.UseVisualStyleBackColor = true;
            btnSignin.Click += btnSignin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(38, 188);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // formLogin
            // 
            AcceptButton = btnSignin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 238);
            Controls.Add(btnCancel);
            Controls.Add(btnSignin);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private TextBox txtUserName;
        private TextBox txtPass;
        private Label lblPass;
        private Label label1;
        private Button btnSignin;
        private Button btnCancel;
    }
}