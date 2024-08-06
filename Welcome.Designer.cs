namespace PART2_TASK1_
{
    partial class Welcome
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
            labelWelcome = new Label();
            button1 = new Button();
            label1 = new Label();
            labelName = new Label();
            labelEmail = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Showcard Gothic", 36F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelWelcome.ForeColor = SystemColors.ControlDarkDark;
            labelWelcome.Location = new Point(393, 62);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(318, 74);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "WELCOME";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(1012, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "LOGOUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(459, 177);
            label1.Name = "label1";
            label1.Size = new Size(222, 33);
            label1.TabIndex = 3;
            label1.Text = "YOUR PROFILE";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ActiveCaptionText;
            labelName.Location = new Point(393, 264);
            labelName.Name = "labelName";
            labelName.Size = new Size(98, 34);
            labelName.TabIndex = 4;
            labelName.Text = "Name:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = SystemColors.ActiveCaptionText;
            labelEmail.Location = new Point(393, 326);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(92, 34);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(393, 391);
            label2.Name = "label2";
            label2.Size = new Size(142, 34);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(558, 264);
            label3.Name = "label3";
            label3.Size = new Size(80, 34);
            label3.TabIndex = 7;
            label3.Text = "NULL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(558, 326);
            label4.Name = "label4";
            label4.Size = new Size(80, 34);
            label4.TabIndex = 8;
            label4.Text = "NULL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 16.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(558, 391);
            label5.Name = "label5";
            label5.Size = new Size(80, 34);
            label5.TabIndex = 9;
            label5.Text = "NULL";
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 648);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(labelWelcome);
            Name = "Welcome";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Button button1;
        private Label label1;
        private Label labelName;
        private Label labelEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}