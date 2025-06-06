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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMemberView));
            btn_discard = new Button();
            lbl_allMembers = new Label();
            btn_printMember = new Button();
            lbl_selectedMember = new Label();
            btn_filter = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_Mitglieder = new Label();
            sct_members = new SplitContainer();
            lbl_members = new Label();
            lbl_material = new Label();
            lbl_Lager = new Label();
            btn_printAllMembers = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sct_members).BeginInit();
            sct_members.SuspendLayout();
            SuspendLayout();
            // 
            // btn_discard
            // 
            btn_discard.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_discard.Location = new Point(1613, 986);
            btn_discard.Margin = new Padding(3, 2, 3, 2);
            btn_discard.Name = "btn_discard";
            btn_discard.Size = new Size(140, 43);
            btn_discard.TabIndex = 25;
            btn_discard.Text = "verwerfen";
            btn_discard.UseVisualStyleBackColor = true;
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
            // btn_printMember
            // 
            btn_printMember.Location = new Point(1759, 986);
            btn_printMember.Margin = new Padding(3, 2, 3, 2);
            btn_printMember.Name = "btn_printMember";
            btn_printMember.Size = new Size(117, 43);
            btn_printMember.TabIndex = 23;
            btn_printMember.Text = "GENERATED PROGRAMATICALLY";
            btn_printMember.UseVisualStyleBackColor = true;
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
            btn_filter.Click += btn_filter_Click;
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
            sct_members.Size = new Size(1920, 781);
            sct_members.SplitterDistance = 958;
            sct_members.TabIndex = 21;
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
            // btn_printAllMembers
            // 
            btn_printAllMembers.Location = new Point(826, 986);
            btn_printAllMembers.Margin = new Padding(3, 2, 3, 2);
            btn_printAllMembers.Name = "btn_printAllMembers";
            btn_printAllMembers.Size = new Size(117, 43);
            btn_printAllMembers.TabIndex = 30;
            btn_printAllMembers.Text = "GENERATED PROGRAMATICALLY";
            btn_printAllMembers.UseVisualStyleBackColor = true;
            // 
            // AdminMemberView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btn_printAllMembers);
            Controls.Add(btn_discard);
            Controls.Add(lbl_allMembers);
            Controls.Add(btn_printMember);
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
            ((System.ComponentModel.ISupportInitialize)sct_members).EndInit();
            sct_members.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_discard;
        private Label lbl_allMembers;
        private Button btn_printMember;
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
    }
}