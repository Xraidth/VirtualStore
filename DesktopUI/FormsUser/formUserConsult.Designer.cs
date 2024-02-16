namespace DesktopUI.FormsUser
{
    partial class formUserConsult
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
            label2 = new Label();
            label1 = new Label();
            lblUserName = new Label();
            lblPass = new Label();
            label4 = new Label();
            lblID = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 135);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 16;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 87);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 15;
            label1.Text = "User Name:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(164, 87);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(20, 15);
            lblUserName.TabIndex = 18;
            lblUserName.Text = "lbl";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(164, 135);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(20, 15);
            lblPass.TabIndex = 19;
            lblPass.Text = "lbl";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 45);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 21;
            label4.Text = "ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(164, 45);
            lblID.Name = "lblID";
            lblID.Size = new Size(20, 15);
            lblID.TabIndex = 22;
            lblID.Text = "lbl";
            // 
            // formUserConsult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 200);
            Controls.Add(lblID);
            Controls.Add(label4);
            Controls.Add(lblPass);
            Controls.Add(lblUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formUserConsult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formUserConsult";
            Load += formUserConsult_Load;
            KeyDown += formUserConsult_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Label lblUserName;
        private Label lblPass;
        private Label label4;
        private Label lblID;
    }
}