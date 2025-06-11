namespace application.A_PL.AdminView
{
    partial class AdminMemberView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMemberView));
            btn_newMember = new Button();
            lbl_allMembers = new Label();
            btn_save = new Button();
            lbl_selectedMember = new Label();
            btn_filter = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_Mitglieder = new Label();
            sct_members = new SplitContainer();
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
            lbl_memberHeading = new Label();
            lbl_members = new Label();
            lbl_material = new Label();
            lbl_Lager = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sct_members).BeginInit();
            sct_members.Panel2.SuspendLayout();
            sct_members.SuspendLayout();
            SuspendLayout();
            // 
            // btn_newMember
            // 
            btn_newMember.Font = new Font("Segoe UI", 18F);
            btn_newMember.Location = new Point(962, 987);
            btn_newMember.Margin = new Padding(3, 2, 3, 2);
            btn_newMember.Name = "btn_newMember";
            btn_newMember.Size = new Size(214, 43);
            btn_newMember.TabIndex = 25;
            btn_newMember.Text = "neuer Benutzer";
            btn_newMember.UseVisualStyleBackColor = true;
            btn_newMember.Click += btn_newMember_Click;
            // 
            // lbl_allMembers
            // 
            lbl_allMembers.AutoSize = true;
            lbl_allMembers.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_allMembers.Location = new Point(12, 145);
            lbl_allMembers.Name = "lbl_allMembers";
            lbl_allMembers.Size = new Size(261, 50);
            lbl_allMembers.TabIndex = 22;
            lbl_allMembers.Text = "Alle Mitglieder";
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Segoe UI", 18F);
            btn_save.Location = new Point(1717, 987);
            btn_save.Margin = new Padding(3, 2, 3, 2);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(175, 43);
            btn_save.TabIndex = 23;
            btn_save.Text = "Speichern";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // lbl_selectedMember
            // 
            lbl_selectedMember.AutoSize = true;
            lbl_selectedMember.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_selectedMember.Location = new Point(963, 145);
            lbl_selectedMember.Name = "lbl_selectedMember";
            lbl_selectedMember.Size = new Size(394, 50);
            lbl_selectedMember.TabIndex = 18;
            lbl_selectedMember.Text = "Ausgewähltes Mitglied";
            // 
            // btn_filter
            // 
            btn_filter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_filter.Location = new Point(858, 145);
            btn_filter.Margin = new Padding(3, 2, 3, 2);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new Size(99, 50);
            btn_filter.TabIndex = 19;
            btn_filter.Text = "Filter";
            btn_filter.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1756, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // lbl_Mitglieder
            // 
            lbl_Mitglieder.AutoSize = true;
            lbl_Mitglieder.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Mitglieder.Location = new Point(253, 22);
            lbl_Mitglieder.Name = "lbl_Mitglieder";
            lbl_Mitglieder.Size = new Size(328, 86);
            lbl_Mitglieder.TabIndex = 20;
            lbl_Mitglieder.Text = "Mitglieder";
            // 
            // sct_members
            // 
            sct_members.BackColor = SystemColors.Control;
            sct_members.Location = new Point(0, 200);
            sct_members.Name = "sct_members";
            // 
            // sct_members.Panel1
            // 
            sct_members.Panel1.AutoScroll = true;
            // 
            // sct_members.Panel2
            // 
            sct_members.Panel2.AutoScroll = true;
            sct_members.Panel2.Controls.Add(tbx_phone);
            sct_members.Panel2.Controls.Add(lbl_phone);
            sct_members.Panel2.Controls.Add(tbx_email);
            sct_members.Panel2.Controls.Add(lbl_email);
            sct_members.Panel2.Controls.Add(tbx_passKey);
            sct_members.Panel2.Controls.Add(lbl_passKey);
            sct_members.Panel2.Controls.Add(tbx_lastName);
            sct_members.Panel2.Controls.Add(lbl_lastName);
            sct_members.Panel2.Controls.Add(tbx_firstName);
            sct_members.Panel2.Controls.Add(lbl_firstName);
            sct_members.Panel2.Controls.Add(lbl_memberHeading);
            sct_members.Size = new Size(1920, 781);
            sct_members.SplitterDistance = 958;
            sct_members.TabIndex = 21;
            // 
            // tbx_phone
            // 
            tbx_phone.Font = new Font("Segoe UI", 16F);
            tbx_phone.Location = new Point(207, 357);
            tbx_phone.Margin = new Padding(3, 2, 3, 2);
            tbx_phone.Name = "tbx_phone";
            tbx_phone.Size = new Size(600, 36);
            tbx_phone.TabIndex = 41;
            // 
            // lbl_phone
            // 
            lbl_phone.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_phone.Location = new Point(17, 360);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(160, 30);
            lbl_phone.TabIndex = 40;
            lbl_phone.Text = "Telefonnummer";
            // 
            // tbx_email
            // 
            tbx_email.Font = new Font("Segoe UI", 16F);
            tbx_email.Location = new Point(207, 287);
            tbx_email.Margin = new Padding(3, 2, 3, 2);
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(600, 36);
            tbx_email.TabIndex = 39;
            // 
            // lbl_email
            // 
            lbl_email.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_email.Location = new Point(17, 290);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(160, 30);
            lbl_email.TabIndex = 38;
            lbl_email.Text = "E-Mail Adresse";
            // 
            // tbx_passKey
            // 
            tbx_passKey.Font = new Font("Segoe UI", 16F);
            tbx_passKey.Location = new Point(207, 218);
            tbx_passKey.Margin = new Padding(3, 2, 3, 2);
            tbx_passKey.Name = "tbx_passKey";
            tbx_passKey.Size = new Size(600, 36);
            tbx_passKey.TabIndex = 37;
            // 
            // lbl_passKey
            // 
            lbl_passKey.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_passKey.Location = new Point(17, 221);
            lbl_passKey.Name = "lbl_passKey";
            lbl_passKey.Size = new Size(123, 30);
            lbl_passKey.TabIndex = 36;
            lbl_passKey.Text = "Passwort";
            // 
            // tbx_lastName
            // 
            tbx_lastName.Font = new Font("Segoe UI", 16F);
            tbx_lastName.Location = new Point(207, 151);
            tbx_lastName.Margin = new Padding(3, 2, 3, 2);
            tbx_lastName.Name = "tbx_lastName";
            tbx_lastName.Size = new Size(600, 36);
            tbx_lastName.TabIndex = 35;
            // 
            // lbl_lastName
            // 
            lbl_lastName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_lastName.Location = new Point(17, 154);
            lbl_lastName.Name = "lbl_lastName";
            lbl_lastName.Size = new Size(123, 30);
            lbl_lastName.TabIndex = 34;
            lbl_lastName.Text = "Nachname";
            // 
            // tbx_firstName
            // 
            tbx_firstName.Font = new Font("Segoe UI", 16F);
            tbx_firstName.Location = new Point(207, 90);
            tbx_firstName.Margin = new Padding(3, 2, 3, 2);
            tbx_firstName.Name = "tbx_firstName";
            tbx_firstName.Size = new Size(600, 36);
            tbx_firstName.TabIndex = 33;
            // 
            // lbl_firstName
            // 
            lbl_firstName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_firstName.Location = new Point(17, 93);
            lbl_firstName.Name = "lbl_firstName";
            lbl_firstName.Size = new Size(123, 30);
            lbl_firstName.TabIndex = 32;
            lbl_firstName.Text = "Vorname";
            // 
            // lbl_memberHeading
            // 
            lbl_memberHeading.AutoSize = true;
            lbl_memberHeading.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_memberHeading.Location = new Point(17, 18);
            lbl_memberHeading.Name = "lbl_memberHeading";
            lbl_memberHeading.Size = new Size(350, 50);
            lbl_memberHeading.TabIndex = 31;
            lbl_memberHeading.Text = "[Mitgliedernummer]";
            // 
            // lbl_members
            // 
            lbl_members.AutoSize = true;
            lbl_members.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_members.Location = new Point(1567, 40);
            lbl_members.Name = "lbl_members";
            lbl_members.Size = new Size(167, 45);
            lbl_members.TabIndex = 29;
            lbl_members.Text = "Mitglieder";
            // 
            // lbl_material
            // 
            lbl_material.AutoSize = true;
            lbl_material.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_material.Location = new Point(1379, 40);
            lbl_material.Name = "lbl_material";
            lbl_material.Size = new Size(136, 45);
            lbl_material.TabIndex = 28;
            lbl_material.Text = "Material";
            // 
            // lbl_Lager
            // 
            lbl_Lager.AutoSize = true;
            lbl_Lager.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Lager.Location = new Point(1233, 40);
            lbl_Lager.Name = "lbl_Lager";
            lbl_Lager.Size = new Size(98, 45);
            lbl_Lager.TabIndex = 27;
            lbl_Lager.Text = "Lager";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(191, 94);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 36);
            textBox2.TabIndex = 33;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 97);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 32;
            label3.Text = "Vorname";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 97);
            label4.Name = "label4";
            label4.Size = new Size(123, 30);
            label4.TabIndex = 32;
            label4.Text = "Vorname";
            // 
            // AdminMemberView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btn_newMember);
            Controls.Add(lbl_allMembers);
            Controls.Add(btn_save);
            Controls.Add(lbl_members);
            Controls.Add(lbl_selectedMember);
            Controls.Add(btn_filter);
            Controls.Add(lbl_material);
            Controls.Add(lbl_Lager);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Mitglieder);
            Controls.Add(sct_members);
            Name = "AdminMemberView";
            Text = "AdminMemberView";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sct_members.Panel2.ResumeLayout(false);
            sct_members.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sct_members).EndInit();
            sct_members.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_newMember;
        private Label lbl_allMembers;
        private Button btn_save;
        private Label lbl_selectedMember;
        private Button btn_filter;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbl_Mitglieder;
        private SplitContainer sct_members;
        private Label lbl_members;
        private Label lbl_material;
        private Label lbl_Lager;
        private Button btn_printAllMembers;
        private Label lbl_memberHeading;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox tbx_passKey;
        private Label lbl_passKey;
        private TextBox tbx_lastName;
        private Label lbl_lastName;
        private TextBox tbx_firstName;
        private Label lbl_firstName;
        private TextBox tbx_email;
        private Label lbl_email;
        private TextBox tbx_phone;
        private Label lbl_phone;
    }
}