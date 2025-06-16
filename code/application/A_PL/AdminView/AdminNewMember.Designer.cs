namespace application.A_PL.AdminView
{
    partial class AdminNewMember
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
            tbx_phone = new TextBox();
            lbl_phone = new Label();
            tbx_email = new TextBox();
            lbl_email = new Label();
            tbx_passKey = new TextBox();
            lbl_passKey = new Label();
            tbx_lastName = new TextBox();
            lbl_lastName = new Label();
            tbx_firstName = new TextBox();
            lbl_firstName = new Label();
            btn_save = new Button();
            rad_member = new RadioButton();
            rad_admin = new RadioButton();
            SuspendLayout();
            // 
            // tbx_phone
            // 
            tbx_phone.Font = new Font("Segoe UI", 16F);
            tbx_phone.Location = new Point(202, 337);
            tbx_phone.Margin = new Padding(3, 2, 3, 2);
            tbx_phone.Name = "tbx_phone";
            tbx_phone.Size = new Size(600, 36);
            tbx_phone.TabIndex = 51;
            // 
            // lbl_phone
            // 
            lbl_phone.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_phone.Location = new Point(12, 340);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(160, 25);
            lbl_phone.TabIndex = 50;
            lbl_phone.Text = "Telefonnummer";
            // 
            // tbx_email
            // 
            tbx_email.Font = new Font("Segoe UI", 16F);
            tbx_email.Location = new Point(202, 267);
            tbx_email.Margin = new Padding(3, 2, 3, 2);
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(600, 36);
            tbx_email.TabIndex = 49;
            // 
            // lbl_email
            // 
            lbl_email.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(12, 270);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(160, 25);
            lbl_email.TabIndex = 48;
            lbl_email.Text = "E-Mail Adresse";
            // 
            // tbx_passKey
            // 
            tbx_passKey.Font = new Font("Segoe UI", 16F);
            tbx_passKey.Location = new Point(202, 198);
            tbx_passKey.Margin = new Padding(3, 2, 3, 2);
            tbx_passKey.Name = "tbx_passKey";
            tbx_passKey.Size = new Size(600, 36);
            tbx_passKey.TabIndex = 47;
            // 
            // lbl_passKey
            // 
            lbl_passKey.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_passKey.Location = new Point(12, 201);
            lbl_passKey.Name = "lbl_passKey";
            lbl_passKey.Size = new Size(123, 25);
            lbl_passKey.TabIndex = 46;
            lbl_passKey.Text = "Passwort";
            // 
            // tbx_lastName
            // 
            tbx_lastName.Font = new Font("Segoe UI", 16F);
            tbx_lastName.Location = new Point(202, 131);
            tbx_lastName.Margin = new Padding(3, 2, 3, 2);
            tbx_lastName.Name = "tbx_lastName";
            tbx_lastName.Size = new Size(600, 36);
            tbx_lastName.TabIndex = 45;
            // 
            // lbl_lastName
            // 
            lbl_lastName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_lastName.Location = new Point(12, 134);
            lbl_lastName.Name = "lbl_lastName";
            lbl_lastName.Size = new Size(123, 25);
            lbl_lastName.TabIndex = 44;
            lbl_lastName.Text = "Nachname";
            // 
            // tbx_firstName
            // 
            tbx_firstName.Font = new Font("Segoe UI", 16F);
            tbx_firstName.Location = new Point(202, 70);
            tbx_firstName.Margin = new Padding(3, 2, 3, 2);
            tbx_firstName.Name = "tbx_firstName";
            tbx_firstName.Size = new Size(600, 36);
            tbx_firstName.TabIndex = 43;
            // 
            // lbl_firstName
            // 
            lbl_firstName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_firstName.Location = new Point(12, 73);
            lbl_firstName.Name = "lbl_firstName";
            lbl_firstName.Size = new Size(123, 25);
            lbl_firstName.TabIndex = 42;
            lbl_firstName.Text = "Vorname";
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 18F);
            btn_save.Location = new Point(556, 398);
            btn_save.Margin = new Padding(3, 2, 3, 2);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(246, 38);
            btn_save.TabIndex = 52;
            btn_save.Text = "speichern";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // rad_member
            // 
            rad_member.AutoSize = true;
            rad_member.Font = new Font("Segoe UI", 15.75F);
            rad_member.Location = new Point(12, 12);
            rad_member.Name = "rad_member";
            rad_member.Size = new Size(107, 34);
            rad_member.TabIndex = 54;
            rad_member.TabStop = true;
            rad_member.Text = "Mitglied";
            rad_member.UseVisualStyleBackColor = true;
            // 
            // rad_admin
            // 
            rad_admin.AutoSize = true;
            rad_admin.Font = new Font("Segoe UI", 15.75F);
            rad_admin.Location = new Point(202, 12);
            rad_admin.Name = "rad_admin";
            rad_admin.Size = new Size(157, 34);
            rad_admin.TabIndex = 55;
            rad_admin.TabStop = true;
            rad_admin.Text = "Administrator";
            rad_admin.UseVisualStyleBackColor = true;
            // 
            // AdminNewMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 449);
            Controls.Add(rad_admin);
            Controls.Add(rad_member);
            Controls.Add(btn_save);
            Controls.Add(tbx_phone);
            Controls.Add(lbl_phone);
            Controls.Add(tbx_email);
            Controls.Add(lbl_email);
            Controls.Add(tbx_passKey);
            Controls.Add(lbl_passKey);
            Controls.Add(tbx_lastName);
            Controls.Add(lbl_lastName);
            Controls.Add(tbx_firstName);
            Controls.Add(lbl_firstName);
            Name = "AdminNewMember";
            Text = "AdminNewMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_phone;
        private Label lbl_phone;
        private TextBox tbx_email;
        private Label lbl_email;
        private TextBox tbx_passKey;
        private Label lbl_passKey;
        private TextBox tbx_lastName;
        private Label lbl_lastName;
        private TextBox tbx_firstName;
        private Label lbl_firstName;
        private Button btn_save;
        private RadioButton rad_member;
        private RadioButton rad_admin;
    }
}