namespace PART2_TASK1_
{
    partial class Login
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
            labelLogin = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonSubmit = new Button();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelLogin.ForeColor = SystemColors.ControlDarkDark;
            labelLogin.Location = new Point(304, 78);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(164, 59);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "LOGIN";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(147, 182);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(152, 41);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(147, 255);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(143, 41);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(377, 191);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(301, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(377, 269);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(301, 27);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = SystemColors.ActiveCaption;
            buttonSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(301, 331);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(167, 47);
            buttonSubmit.TabIndex = 5;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = SystemColors.GradientActiveCaption;
            buttonRegister.ForeColor = SystemColors.InactiveCaptionText;
            buttonRegister.Location = new Point(684, 26);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(94, 29);
            buttonRegister.TabIndex = 6;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegister);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonSubmit;
        private Button buttonRegister;
    }
}
