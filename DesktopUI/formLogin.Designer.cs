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
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(21, 82);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(81, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "UserName:";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(105, 82);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(168, 27);
            txtUserName.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(105, 126);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(168, 27);
            txtPass.TabIndex = 3;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPass.Location = new Point(22, 128);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(73, 20);
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
            btnSignin.Location = new Point(91, 176);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(192, 33);
            btnSignin.TabIndex = 5;
            btnSignin.Text = "Sign in";
            btnSignin.UseVisualStyleBackColor = true;
            btnSignin.Click += btnSignin_Click;
            // 
            // formLogin
            // 
            AcceptButton = btnSignin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(357, 239);
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
            Load += formLogin_Load;
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
    }
}