namespace application.A_PL
{
    partial class RentView
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
            sct_rentMaterial = new SplitContainer();
            lbl_Ausleihen = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbl_borrow = new Label();
            lbl_return = new Label();
            lbl_material = new Label();
            ((System.ComponentModel.ISupportInitialize)sct_rentMaterial).BeginInit();
            sct_rentMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // sct_rentMaterial
            // 
            sct_rentMaterial.Location = new Point(0, 140);
            sct_rentMaterial.Name = "sct_rentMaterial";
            sct_rentMaterial.Size = new Size(1904, 900);
            sct_rentMaterial.SplitterDistance = 952;
            sct_rentMaterial.TabIndex = 0;
            // 
            // lbl_Ausleihen
            // 
            lbl_Ausleihen.AutoSize = true;
            lbl_Ausleihen.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Ausleihen.Location = new Point(120, 0);
            lbl_Ausleihen.Name = "lbl_Ausleihen";
            lbl_Ausleihen.Size = new Size(837, 128);
            lbl_Ausleihen.TabIndex = 0;
            lbl_Ausleihen.Text = "Material Ausleihen";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
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
            lbl_borrow.Location = new Point(1271, 41);
            lbl_borrow.Name = "lbl_borrow";
            lbl_borrow.Size = new Size(159, 45);
            lbl_borrow.TabIndex = 3;
            lbl_borrow.Text = "Ausleihen";
            // 
            // lbl_return
            // 
            lbl_return.AutoSize = true;
            lbl_return.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_return.Location = new Point(1427, 41);
            lbl_return.Name = "lbl_return";
            lbl_return.Size = new Size(206, 45);
            lbl_return.TabIndex = 4;
            lbl_return.Text = "Zurückgeben";
            // 
            // lbl_material
            // 
            lbl_material.AutoSize = true;
            lbl_material.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_material.Location = new Point(1630, 41);
            lbl_material.Name = "lbl_material";
            lbl_material.Size = new Size(136, 45);
            lbl_material.TabIndex = 5;
            lbl_material.Text = "Material";
            // 
            // RentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(lbl_material);
            Controls.Add(lbl_return);
            Controls.Add(lbl_borrow);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Ausleihen);
            Controls.Add(sct_rentMaterial);
            Name = "RentView";
            Text = "RentView";
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
        private Label lbl_material;
    }
}