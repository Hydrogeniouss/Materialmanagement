namespace application.A_PL
{
    partial class ReturnView
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
            btn_discard = new Button();
            sct_rentMaterial = new SplitContainer();
            lbl_MatText = new Label();
            btn_filter = new Button();
            btn_borrow = new Button();
            lbl_selectedMaterials = new Label();
            lbl_material = new Label();
            lbl_return = new Label();
            lbl_borrow = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_returnText = new Label();
            ((System.ComponentModel.ISupportInitialize)sct_rentMaterial).BeginInit();
            sct_rentMaterial.Panel1.SuspendLayout();
            sct_rentMaterial.Panel2.SuspendLayout();
            sct_rentMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_discard
            // 
            btn_discard.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_discard.Location = new Point(504, 603);
            btn_discard.Margin = new Padding(3, 2, 3, 2);
            btn_discard.Name = "btn_discard";
            btn_discard.Size = new Size(140, 43);
            btn_discard.TabIndex = 2;
            btn_discard.Text = "verwerfen";
            btn_discard.UseVisualStyleBackColor = true;
            // 
            // sct_rentMaterial
            // 
            sct_rentMaterial.Location = new Point(0, 140);
            sct_rentMaterial.Name = "sct_rentMaterial";
            // 
            // sct_rentMaterial.Panel1
            // 
            sct_rentMaterial.Panel1.AutoScroll = true;
            sct_rentMaterial.Panel1.Controls.Add(lbl_MatText);
            sct_rentMaterial.Panel1.Controls.Add(btn_filter);
            // 
            // sct_rentMaterial.Panel2
            // 
            sct_rentMaterial.Panel2.AutoScroll = true;
            sct_rentMaterial.Panel2.Controls.Add(btn_discard);
            sct_rentMaterial.Panel2.Controls.Add(btn_borrow);
            sct_rentMaterial.Panel2.Controls.Add(lbl_selectedMaterials);
            sct_rentMaterial.Size = new Size(1904, 900);
            sct_rentMaterial.SplitterDistance = 952;
            sct_rentMaterial.TabIndex = 6;
            // 
            // lbl_MatText
            // 
            lbl_MatText.AutoSize = true;
            lbl_MatText.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_MatText.Location = new Point(23, 18);
            lbl_MatText.Name = "lbl_MatText";
            lbl_MatText.Size = new Size(205, 50);
            lbl_MatText.TabIndex = 1;
            lbl_MatText.Text = "Materialien";
            // 
            // btn_filter
            // 
            btn_filter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_filter.Location = new Point(703, 24);
            btn_filter.Margin = new Padding(3, 2, 3, 2);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new Size(95, 34);
            btn_filter.TabIndex = 0;
            btn_filter.Text = "Filter";
            btn_filter.UseVisualStyleBackColor = true;
            // 
            // btn_borrow
            // 
            btn_borrow.Location = new Point(662, 603);
            btn_borrow.Margin = new Padding(3, 2, 3, 2);
            btn_borrow.Name = "btn_borrow";
            btn_borrow.Size = new Size(117, 43);
            btn_borrow.TabIndex = 1;
            btn_borrow.Text = "GENERATED PROGRAMATICALLY";
            btn_borrow.UseVisualStyleBackColor = true;
            // 
            // lbl_selectedMaterials
            // 
            lbl_selectedMaterials.AutoSize = true;
            lbl_selectedMaterials.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_selectedMaterials.Location = new Point(21, 18);
            lbl_selectedMaterials.Name = "lbl_selectedMaterials";
            lbl_selectedMaterials.Size = new Size(392, 50);
            lbl_selectedMaterials.TabIndex = 0;
            lbl_selectedMaterials.Text = "Ausgewähltes Material";
            // 
            // lbl_material
            // 
            lbl_material.AutoSize = true;
            lbl_material.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_material.Location = new Point(1630, 41);
            lbl_material.Name = "lbl_material";
            lbl_material.Size = new Size(136, 45);
            lbl_material.TabIndex = 12;
            lbl_material.Text = "Material";
            // 
            // lbl_return
            // 
            lbl_return.AutoSize = true;
            lbl_return.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_return.Location = new Point(1427, 41);
            lbl_return.Name = "lbl_return";
            lbl_return.Size = new Size(206, 45);
            lbl_return.TabIndex = 11;
            lbl_return.Text = "Zurückgeben";
            // 
            // lbl_borrow
            // 
            lbl_borrow.AutoSize = true;
            lbl_borrow.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_borrow.Location = new Point(1271, 41);
            lbl_borrow.Name = "lbl_borrow";
            lbl_borrow.Size = new Size(159, 45);
            lbl_borrow.TabIndex = 10;
            lbl_borrow.Text = "Ausleihen";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1772, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lbl_returnText
            // 
            lbl_returnText.AutoSize = true;
            lbl_returnText.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_returnText.Location = new Point(120, 0);
            lbl_returnText.Name = "lbl_returnText";
            lbl_returnText.Size = new Size(837, 128);
            lbl_returnText.TabIndex = 7;
            lbl_returnText.Text = "Material Ausleihen";
            // 
            // ReturnView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(sct_rentMaterial);
            Controls.Add(lbl_material);
            Controls.Add(lbl_return);
            Controls.Add(lbl_borrow);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_returnText);
            Name = "ReturnView";
            Text = "ReturnView";
            sct_rentMaterial.Panel1.ResumeLayout(false);
            sct_rentMaterial.Panel1.PerformLayout();
            sct_rentMaterial.Panel2.ResumeLayout(false);
            sct_rentMaterial.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sct_rentMaterial).EndInit();
            sct_rentMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_discard;
        private SplitContainer sct_rentMaterial;
        private Label lbl_MatText;
        private Button btn_filter;
        private Button btn_borrow;
        private Label lbl_selectedMaterials;
        private Label lbl_material;
        private Label lbl_return;
        private Label lbl_borrow;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbl_returnText;
    }
}