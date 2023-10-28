namespace Transkript
{
    partial class OgrenciDersEkleForm
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
            cboOgrenci = new ComboBox();
            cboDonem = new ComboBox();
            cboDers = new ComboBox();
            cboHarfNotu = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // cboOgrenci
            // 
            cboOgrenci.FormattingEnabled = true;
            cboOgrenci.Location = new Point(145, 134);
            cboOgrenci.Name = "cboOgrenci";
            cboOgrenci.Size = new Size(311, 33);
            cboOgrenci.TabIndex = 0;
            // 
            // cboDonem
            // 
            cboDonem.FormattingEnabled = true;
            cboDonem.Location = new Point(554, 134);
            cboDonem.Name = "cboDonem";
            cboDonem.Size = new Size(311, 33);
            cboDonem.TabIndex = 1;
            // 
            // cboDers
            // 
            cboDers.FormattingEnabled = true;
            cboDers.Location = new Point(145, 245);
            cboDers.Name = "cboDers";
            cboDers.Size = new Size(311, 33);
            cboDers.TabIndex = 2;
            // 
            // cboHarfNotu
            // 
            cboHarfNotu.FormattingEnabled = true;
            cboHarfNotu.Location = new Point(554, 245);
            cboHarfNotu.Name = "cboHarfNotu";
            cboHarfNotu.Size = new Size(311, 33);
            cboHarfNotu.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(145, 91);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 4;
            label1.Text = "Öğrenci";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(554, 91);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 5;
            label2.Text = "Dönem";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(145, 200);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 6;
            label3.Text = "Ders";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(554, 200);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 7;
            label4.Text = "Harf Notu";
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(387, 369);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(233, 84);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // OgrenciDersEkleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 582);
            Controls.Add(btnEkle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboHarfNotu);
            Controls.Add(cboDers);
            Controls.Add(cboDonem);
            Controls.Add(cboOgrenci);
            Name = "OgrenciDersEkleForm";
            Text = "OgrenciDersEkleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboOgrenci;
        private ComboBox cboDonem;
        private ComboBox cboDers;
        private ComboBox cboHarfNotu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnEkle;
    }
}