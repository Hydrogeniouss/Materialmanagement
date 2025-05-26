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
            tbx_lastName = new TextBox();
            lbl_lastName = new Label();
            btn_submit = new Button();
            tbx_pin = new TextBox();
            tbx_firstName = new TextBox();
            lbl_pin = new Label();
            lbl_firstName = new Label();
            lbl_login = new Label();
            lbl_register = new Label();
            lbl_errorMessage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_adminLogin
            // 
            btn_adminLogin.Location = new Point(1544, 10);
            btn_adminLogin.Name = "btn_adminLogin";
            btn_adminLogin.Size = new Size(110, 23);
            btn_adminLogin.TabIndex = 0;
            btn_adminLogin.Text = "Log in as Admin";
            btn_adminLogin.UseVisualStyleBackColor = true;
            btn_adminLogin.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(tbx_lastName);
            panel1.Controls.Add(lbl_lastName);
            panel1.Controls.Add(btn_submit);
            panel1.Controls.Add(tbx_pin);
            panel1.Controls.Add(tbx_firstName);
            panel1.Controls.Add(lbl_pin);
            panel1.Controls.Add(lbl_firstName);
            panel1.Location = new Point(752, 245);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 164);
            panel1.TabIndex = 1;
            // 
            // tbx_lastName
            // 
            tbx_lastName.Location = new Point(11, 68);
            tbx_lastName.Margin = new Padding(3, 2, 3, 2);
            tbx_lastName.Name = "tbx_lastName";
            tbx_lastName.Size = new Size(186, 23);
            tbx_lastName.TabIndex = 8;
            // 
            // lbl_lastName
            // 
            lbl_lastName.Location = new Point(11, 50);
            lbl_lastName.Name = "lbl_lastName";
            lbl_lastName.Size = new Size(100, 16);
            lbl_lastName.TabIndex = 7;
            lbl_lastName.Tag = "";
            lbl_lastName.Text = "Nachname";
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(11, 133);
            btn_submit.Margin = new Padding(3, 2, 3, 2);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(186, 22);
            btn_submit.TabIndex = 3;
            btn_submit.Text = "Einloggen";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // tbx_pin
            // 
            tbx_pin.Location = new Point(11, 108);
            tbx_pin.Margin = new Padding(3, 2, 3, 2);
            tbx_pin.Name = "tbx_pin";
            tbx_pin.Size = new Size(186, 23);
            tbx_pin.TabIndex = 6;
            // 
            // tbx_firstName
            // 
            tbx_firstName.Location = new Point(11, 27);
            tbx_firstName.Margin = new Padding(3, 2, 3, 2);
            tbx_firstName.Name = "tbx_firstName";
            tbx_firstName.Size = new Size(186, 23);
            tbx_firstName.TabIndex = 5;
            // 
            // lbl_pin
            // 
            lbl_pin.Location = new Point(11, 90);
            lbl_pin.Name = "lbl_pin";
            lbl_pin.Size = new Size(78, 16);
            lbl_pin.TabIndex = 4;
            lbl_pin.Text = "PIN";
            // 
            // lbl_firstName
            // 
            lbl_firstName.Location = new Point(11, 9);
            lbl_firstName.Name = "lbl_firstName";
            lbl_firstName.Size = new Size(100, 16);
            lbl_firstName.TabIndex = 3;
            lbl_firstName.Text = "Vorname";
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI", 20F);
            lbl_login.Location = new Point(764, 208);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(91, 37);
            lbl_login.TabIndex = 2;
            lbl_login.Text = "Log in";
            // 
            // lbl_register
            // 
            lbl_register.AutoSize = true;
            lbl_register.Location = new Point(764, 412);
            lbl_register.Name = "lbl_register";
            lbl_register.Size = new Size(69, 15);
            lbl_register.TabIndex = 3;
            lbl_register.Text = "Registrieren";
            // 
            // lbl_errorMessage
            // 
            lbl_errorMessage.AutoSize = true;
            lbl_errorMessage.ForeColor = Color.Red;
            lbl_errorMessage.Location = new Point(764, 434);
            lbl_errorMessage.Name = "lbl_errorMessage";
            lbl_errorMessage.Size = new Size(0, 15);
            lbl_errorMessage.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(lbl_errorMessage);
            Controls.Add(lbl_register);
            Controls.Add(lbl_login);
            Controls.Add(panel1);
            Controls.Add(btn_adminLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
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
        private TextBox tbx_firstName;
        private Label lbl_pin;
        private Label lbl_firstName;
        private Button btn_submit;
        private TextBox tbx_lastName;
        private Label lbl_lastName;
        private Label lbl_register;
        private Label lbl_errorMessage;
    }
}
