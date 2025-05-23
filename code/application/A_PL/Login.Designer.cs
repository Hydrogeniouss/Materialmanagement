namespace application
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
            btn_adminLogin = new Button();
            panel1 = new Panel();
            lbl_login = new Label();
            lbl_username = new Label();
            lbl_pin = new Label();
            tbx_username = new TextBox();
            tbx_pin = new TextBox();
            btn_submit = new Button();
            lbl_register = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_adminLogin
            // 
            btn_adminLogin.Location = new Point(776, 13);
            btn_adminLogin.Margin = new Padding(3, 4, 3, 4);
            btn_adminLogin.Name = "btn_adminLogin";
            btn_adminLogin.Size = new Size(126, 31);
            btn_adminLogin.TabIndex = 0;
            btn_adminLogin.Text = "Log in as Admin";
            btn_adminLogin.UseVisualStyleBackColor = true;
            btn_adminLogin.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btn_submit);
            panel1.Controls.Add(tbx_pin);
            panel1.Controls.Add(tbx_username);
            panel1.Controls.Add(lbl_pin);
            panel1.Controls.Add(lbl_username);
            panel1.Location = new Point(334, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 201);
            panel1.TabIndex = 1;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI", 20F);
            lbl_login.Location = new Point(347, 122);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(112, 46);
            lbl_login.TabIndex = 2;
            lbl_login.Text = "Log in";
            lbl_login.Click += this.label1_Click;
            // 
            // lbl_username
            // 
            lbl_username.Location = new Point(23, 27);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(114, 21);
            lbl_username.TabIndex = 3;
            lbl_username.Text = "Benutzername";
            // 
            // lbl_pin
            // 
            lbl_pin.Location = new Point(23, 94);
            lbl_pin.Name = "lbl_pin";
            lbl_pin.Size = new Size(89, 21);
            lbl_pin.TabIndex = 4;
            lbl_pin.Text = "PIN";
            // 
            // tbx_username
            // 
            tbx_username.Location = new Point(23, 51);
            tbx_username.Name = "tbx_username";
            tbx_username.Size = new Size(165, 27);
            tbx_username.TabIndex = 5;
            // 
            // tbx_pin
            // 
            tbx_pin.Location = new Point(23, 118);
            tbx_pin.Name = "tbx_pin";
            tbx_pin.Size = new Size(165, 27);
            tbx_pin.TabIndex = 6;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(23, 151);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(165, 29);
            btn_submit.TabIndex = 3;
            btn_submit.Text = "Einloggen";
            btn_submit.UseVisualStyleBackColor = true;
            // 
            // lbl_register
            // 
            lbl_register.AutoSize = true;
            lbl_register.Location = new Point(358, 375);
            lbl_register.Name = "lbl_register";
            lbl_register.Size = new Size(88, 20);
            lbl_register.TabIndex = 3;
            lbl_register.Text = "Registrieren";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lbl_register);
            Controls.Add(lbl_login);
            Controls.Add(panel1);
            Controls.Add(btn_adminLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_adminLogin;
        private Panel panel1;
        private Label lbl_login;
        private TextBox tbx_pin;
        private TextBox tbx_username;
        private Label lbl_pin;
        private Label lbl_username;
        private Button btn_submit;
        private Label lbl_register;
    }
}
