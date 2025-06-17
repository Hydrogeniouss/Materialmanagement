namespace application.A_PL
{
    partial class AdminStoragaeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStoragaeView));
            btn_discard = new Button();
            lbl_MatText = new Label();
            btn_borrow = new Button();
            lbl_selectedMaterials = new Label();
            btn_filter = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_Ausleihen = new Label();
            sct_storage = new SplitContainer();
            lbl_members = new Label();
            lbl_Lager = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sct_storage).BeginInit();
            sct_storage.SuspendLayout();
            SuspendLayout();
            // 
            // btn_discard
            // 
            btn_discard.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_discard.Location = new Point(1621, 986);
            btn_discard.Margin = new Padding(3, 2, 3, 2);
            btn_discard.Name = "btn_discard";
            btn_discard.Size = new Size(140, 43);
            btn_discard.TabIndex = 13;
            btn_discard.Text = "verwerfen";
            btn_discard.UseVisualStyleBackColor = true;
            // 
            // lbl_MatText
            // 
            lbl_MatText.AutoSize = true;
            lbl_MatText.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_MatText.Location = new Point(12, 145);
            lbl_MatText.Name = "lbl_MatText";
            lbl_MatText.Size = new Size(434, 50);
            lbl_MatText.TabIndex = 10;
            lbl_MatText.Text = "Ausgeliehene Materialien";
            // 
            // btn_borrow
            // 
            btn_borrow.Location = new Point(1767, 986);
            btn_borrow.Margin = new Padding(3, 2, 3, 2);
            btn_borrow.Name = "btn_borrow";
            btn_borrow.Size = new Size(117, 43);
            btn_borrow.TabIndex = 11;
            btn_borrow.Text = "GENERATED PROGRAMATICALLY";
            btn_borrow.UseVisualStyleBackColor = true;
            // 
            // lbl_selectedMaterials
            // 
            lbl_selectedMaterials.AutoSize = true;
            lbl_selectedMaterials.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_selectedMaterials.Location = new Point(957, 145);
            lbl_selectedMaterials.Name = "lbl_selectedMaterials";
            lbl_selectedMaterials.Size = new Size(255, 50);
            lbl_selectedMaterials.TabIndex = 6;
            lbl_selectedMaterials.Text = "Verleihhistorie";
            // 
            // btn_filter
            // 
            btn_filter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_filter.Location = new Point(852, 145);
            btn_filter.Margin = new Padding(3, 2, 3, 2);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new Size(99, 50);
            btn_filter.TabIndex = 7;
            btn_filter.Text = "Filter";
            btn_filter.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1764, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 14;
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
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lbl_Ausleihen
            // 
            lbl_Ausleihen.AutoSize = true;
            lbl_Ausleihen.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Ausleihen.Location = new Point(261, 22);
            lbl_Ausleihen.Name = "lbl_Ausleihen";
            lbl_Ausleihen.Size = new Size(193, 86);
            lbl_Ausleihen.TabIndex = 8;
            lbl_Ausleihen.Text = "Lager";
            // 
            // sct_storage
            // 
            sct_storage.BackColor = SystemColors.Control;
            sct_storage.Location = new Point(0, 200);
            sct_storage.Name = "sct_storage";
            // 
            // sct_storage.Panel1
            // 
            sct_storage.Panel1.AutoScroll = true;
            // 
            // sct_storage.Panel2
            // 
            sct_storage.Panel2.AutoScroll = true;
            sct_storage.Size = new Size(1920, 781);
            sct_storage.SplitterDistance = 958;
            sct_storage.TabIndex = 9;
            // 
            // lbl_members
            // 
            lbl_members.AutoSize = true;
            lbl_members.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_members.Location = new Point(1574, 40);
            lbl_members.Name = "lbl_members";
            lbl_members.Size = new Size(167, 45);
            lbl_members.TabIndex = 32;
            lbl_members.Text = "Mitglieder";
            lbl_members.Click += lbl_members_Click;
            // 
            // lbl_Lager
            // 
            lbl_Lager.AutoSize = true;
            lbl_Lager.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Lager.Location = new Point(1448, 40);
            lbl_Lager.Name = "lbl_Lager";
            lbl_Lager.Size = new Size(98, 45);
            lbl_Lager.TabIndex = 30;
            lbl_Lager.Text = "Lager";
            // 
            // button1
            // 
            button1.Location = new Point(834, 993);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(117, 43);
            button1.TabIndex = 33;
            button1.Text = "GENERATED PROGRAMATICALLY";
            button1.UseVisualStyleBackColor = true;
            // 
            // AdminStoragaeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(button1);
            Controls.Add(lbl_members);
            Controls.Add(lbl_Lager);
            Controls.Add(btn_discard);
            Controls.Add(lbl_MatText);
            Controls.Add(btn_borrow);
            Controls.Add(lbl_selectedMaterials);
            Controls.Add(btn_filter);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Ausleihen);
            Controls.Add(sct_storage);
            Name = "AdminStoragaeView";
            Text = "AdminStoragaeVeiw";
            FormClosed += AdminStoragaeView_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sct_storage).EndInit();
            sct_storage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_discard;
        private Label lbl_MatText;
        private Button btn_borrow;
        private Label lbl_selectedMaterials;
        private Button btn_filter;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbl_Ausleihen;
        private SplitContainer sct_storage;
        private Label lbl_members;
        private Label lbl_Lager;
        private Button button1;
    }
}