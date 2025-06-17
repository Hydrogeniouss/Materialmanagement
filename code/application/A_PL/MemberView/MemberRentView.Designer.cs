namespace application.A_PL
{
    partial class MemberRentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberRentView));
            sct_rentMaterial = new SplitContainer();
            btn_discard = new Button();
            btn_borrow = new Button();
            lbl_MatText = new Label();
            btn_filter = new Button();
            lbl_selectedMaterials = new Label();
            lbl_Ausleihen = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbl_borrow = new Label();
            lbl_return = new Label();
            ((System.ComponentModel.ISupportInitialize)sct_rentMaterial).BeginInit();
            sct_rentMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // sct_rentMaterial
            // 
            sct_rentMaterial.BackColor = SystemColors.Control;
            sct_rentMaterial.Location = new Point(0, 201);
            sct_rentMaterial.Name = "sct_rentMaterial";
            // 
            // sct_rentMaterial.Panel1
            // 
            sct_rentMaterial.Panel1.AutoScroll = true;
            // 
            // sct_rentMaterial.Panel2
            // 
            sct_rentMaterial.Panel2.AutoScroll = true;
            sct_rentMaterial.Size = new Size(1920, 781);
            sct_rentMaterial.SplitterDistance = 958;
            sct_rentMaterial.TabIndex = 0;
            // 
            // btn_discard
            // 
            btn_discard.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_discard.Location = new Point(1629, 987);
            btn_discard.Margin = new Padding(3, 2, 3, 2);
            btn_discard.Name = "btn_discard";
            btn_discard.Size = new Size(140, 43);
            btn_discard.TabIndex = 2;
            btn_discard.Text = "verwerfen";
            btn_discard.UseVisualStyleBackColor = true;
            // 
            // btn_borrow
            // 
            btn_borrow.Location = new Point(1775, 987);
            btn_borrow.Margin = new Padding(3, 2, 3, 2);
            btn_borrow.Name = "btn_borrow";
            btn_borrow.Size = new Size(117, 43);
            btn_borrow.TabIndex = 1;
            btn_borrow.Text = "GENERATED PROGRAMATICALLY";
            btn_borrow.UseVisualStyleBackColor = true;
            btn_borrow.Click += btn_borrow_Click;
            // 
            // lbl_MatText
            // 
            lbl_MatText.AutoSize = true;
            lbl_MatText.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_MatText.Location = new Point(12, 146);
            lbl_MatText.Name = "lbl_MatText";
            lbl_MatText.Size = new Size(205, 50);
            lbl_MatText.TabIndex = 1;
            lbl_MatText.Text = "Materialien";
            // 
            // btn_filter
            // 
            btn_filter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_filter.Location = new Point(860, 146);
            btn_filter.Margin = new Padding(3, 2, 3, 2);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new Size(99, 50);
            btn_filter.TabIndex = 0;
            btn_filter.Text = "Filter";
            btn_filter.UseVisualStyleBackColor = true;
            btn_filter.Click += btn_filter_Click;
            // 
            // lbl_selectedMaterials
            // 
            lbl_selectedMaterials.AutoSize = true;
            lbl_selectedMaterials.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_selectedMaterials.Location = new Point(965, 146);
            lbl_selectedMaterials.Name = "lbl_selectedMaterials";
            lbl_selectedMaterials.Size = new Size(392, 50);
            lbl_selectedMaterials.TabIndex = 0;
            lbl_selectedMaterials.Text = "Ausgewähltes Material";
            // 
            // lbl_Ausleihen
            // 
            lbl_Ausleihen.AutoSize = true;
            lbl_Ausleihen.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Ausleihen.Location = new Point(269, 23);
            lbl_Ausleihen.Name = "lbl_Ausleihen";
            lbl_Ausleihen.Size = new Size(561, 86);
            lbl_Ausleihen.TabIndex = 0;
            lbl_Ausleihen.Text = "Material Ausleihen";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1772, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lbl_borrow
            // 
            lbl_borrow.AutoSize = true;
            lbl_borrow.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_borrow.Location = new Point(1404, 41);
            lbl_borrow.Name = "lbl_borrow";
            lbl_borrow.Size = new Size(159, 45);
            lbl_borrow.TabIndex = 3;
            lbl_borrow.Text = "Ausleihen";
            // 
            // lbl_return
            // 
            lbl_return.AutoSize = true;
            lbl_return.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_return.Location = new Point(1560, 41);
            lbl_return.Name = "lbl_return";
            lbl_return.Size = new Size(206, 45);
            lbl_return.TabIndex = 4;
            lbl_return.Text = "Zurückgeben";
            lbl_return.Click += lbl_return_Click;
            // 
            // MemberRentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btn_discard);
            Controls.Add(lbl_MatText);
            Controls.Add(btn_borrow);
            Controls.Add(lbl_selectedMaterials);
            Controls.Add(btn_filter);
            Controls.Add(lbl_return);
            Controls.Add(lbl_borrow);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Ausleihen);
            Controls.Add(sct_rentMaterial);
            Name = "MemberRentView";
            Text = "RentView";
            FormClosing += MemberRentView_FormClosing;
            Load += RentView_Load;
            ((System.ComponentModel.ISupportInitialize)sct_rentMaterial).EndInit();
            sct_rentMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer sct_rentMaterial;
        private Label lbl_Ausleihen;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbl_borrow;
        private Label lbl_return;
        private Button btn_filter;
        private Label lbl_MatText;
        private Label lbl_selectedMaterials;
        private Button btn_discard;
        private Button btn_borrow;
    }
}