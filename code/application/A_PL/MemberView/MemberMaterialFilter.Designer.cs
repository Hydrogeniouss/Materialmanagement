namespace application.A_PL
{
    partial class MemberMaterialFilter
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
            lbl_name = new Label();
            cbx_brand = new ComboBox();
            tbx_name = new TextBox();
            tbx_description = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbl_type = new Label();
            cbx_type = new ComboBox();
            btn_submit = new Button();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(34, 38);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(42, 15);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name:";
            // 
            // cbx_brand
            // 
            cbx_brand.FormattingEnabled = true;
            cbx_brand.Location = new Point(143, 114);
            cbx_brand.Name = "cbx_brand";
            cbx_brand.Size = new Size(121, 23);
            cbx_brand.TabIndex = 1;
            // 
            // tbx_name
            // 
            tbx_name.Location = new Point(143, 35);
            tbx_name.Name = "tbx_name";
            tbx_name.Size = new Size(100, 23);
            tbx_name.TabIndex = 2;
            // 
            // tbx_description
            // 
            tbx_description.Location = new Point(143, 64);
            tbx_description.Name = "tbx_description";
            tbx_description.Size = new Size(100, 23);
            tbx_description.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 67);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 3;
            label1.Text = "Beschreibung:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 117);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Brand:";
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.Location = new Point(34, 148);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new Size(28, 15);
            lbl_type.TabIndex = 7;
            lbl_type.Text = "Typ:";
            // 
            // cbx_type
            // 
            cbx_type.FormattingEnabled = true;
            cbx_type.Location = new Point(143, 145);
            cbx_type.Name = "cbx_type";
            cbx_type.Size = new Size(121, 23);
            cbx_type.TabIndex = 6;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(669, 397);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(75, 23);
            btn_submit.TabIndex = 8;
            btn_submit.Text = "suchen";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // MaterialFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_submit);
            Controls.Add(lbl_type);
            Controls.Add(cbx_type);
            Controls.Add(label2);
            Controls.Add(tbx_description);
            Controls.Add(label1);
            Controls.Add(tbx_name);
            Controls.Add(cbx_brand);
            Controls.Add(lbl_name);
            Name = "MaterialFilter";
            Text = "MaterialFilter";
            Load += MaterialFilter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private ComboBox cbx_brand;
        private TextBox tbx_name;
        private TextBox tbx_description;
        private Label label1;
        private Label label2;
        private Label lbl_type;
        private ComboBox cbx_type;
        private Button btn_submit;
    }
}