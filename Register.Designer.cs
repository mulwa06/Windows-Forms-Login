namespace PART2_TASK1_
{
    partial class Register
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
            labelRegister = new Label();
            buttonLogin = new Button();
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonSubmit = new Button();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelRegister.ForeColor = SystemColors.ControlDarkDark;
            labelRegister.Location = new Point(282, 58);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(244, 59);
            labelRegister.TabIndex = 7;
            labelRegister.Text = "REGISTER";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.GradientActiveCaption;
            buttonLogin.ForeColor = SystemColors.InactiveCaptionText;
            buttonLogin.Location = new Point(679, 31);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(151, 162);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(152, 41);
            labelUsername.TabIndex = 9;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(151, 282);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(143, 41);
            labelPassword.TabIndex = 10;
            labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(360, 176);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(301, 27);
            textBoxUsername.TabIndex = 11;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(360, 296);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(301, 27);
            textBoxPassword.TabIndex = 12;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = SystemColors.ActiveCaption;
            buttonSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(315, 354);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(167, 47);
            buttonSubmit.TabIndex = 13;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(151, 225);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(88, 41);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(360, 239);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(301, 27);
            textBoxEmail.TabIndex = 15;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelRegister);
            Controls.Add(buttonLogin);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegister;
        private Button buttonLogin;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonSubmit;
        private Label labelEmail;
        private TextBox textBoxEmail;
    }
}