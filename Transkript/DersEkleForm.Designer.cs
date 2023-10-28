namespace Transkript
{
    partial class DersEkleForm
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
            btnDersSil = new Button();
            btnDersGuncelle = new Button();
            btnDersEkle = new Button();
            dgvDersler = new DataGridView();
            txtKredi = new TextBox();
            txtDersAd = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtKod = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            SuspendLayout();
            // 
            // btnDersSil
            // 
            btnDersSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDersSil.Location = new Point(50, 460);
            btnDersSil.Name = "btnDersSil";
            btnDersSil.Size = new Size(332, 57);
            btnDersSil.TabIndex = 5;
            btnDersSil.Text = "SİL";
            btnDersSil.UseVisualStyleBackColor = true;
            btnDersSil.Click += btnDersSil_Click;
            // 
            // btnDersGuncelle
            // 
            btnDersGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDersGuncelle.Location = new Point(50, 372);
            btnDersGuncelle.Name = "btnDersGuncelle";
            btnDersGuncelle.Size = new Size(332, 57);
            btnDersGuncelle.TabIndex = 4;
            btnDersGuncelle.Text = "GÜNCELLE";
            btnDersGuncelle.UseVisualStyleBackColor = true;
            btnDersGuncelle.Click += btnDersGuncelle_Click;
            // 
            // btnDersEkle
            // 
            btnDersEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDersEkle.Location = new Point(50, 289);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(332, 57);
            btnDersEkle.TabIndex = 3;
            btnDersEkle.Text = "EKLE";
            btnDersEkle.UseVisualStyleBackColor = true;
            btnDersEkle.Click += btnDersEkle_Click;
            // 
            // dgvDersler
            // 
            dgvDersler.AllowUserToAddRows = false;
            dgvDersler.AllowUserToDeleteRows = false;
            dgvDersler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDersler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.Location = new Point(436, 12);
            dgvDersler.MultiSelect = false;
            dgvDersler.Name = "dgvDersler";
            dgvDersler.ReadOnly = true;
            dgvDersler.RowHeadersWidth = 62;
            dgvDersler.RowTemplate.Height = 33;
            dgvDersler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDersler.Size = new Size(689, 754);
            dgvDersler.TabIndex = 6;
            dgvDersler.CellContentClick += dgvDersler_CellContentClick;
            // 
            // txtKredi
            // 
            txtKredi.Location = new Point(133, 203);
            txtKredi.Name = "txtKredi";
            txtKredi.Size = new Size(249, 31);
            txtKredi.TabIndex = 2;
            // 
            // txtDersAd
            // 
            txtDersAd.Location = new Point(133, 150);
            txtDersAd.Name = "txtDersAd";
            txtDersAd.Size = new Size(249, 31);
            txtDersAd.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 206);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 12;
            label3.Text = "Kredi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 150);
            label1.Name = "label1";
            label1.Size = new Size(43, 28);
            label1.TabIndex = 10;
            label1.Text = "Ad:";
            // 
            // txtKod
            // 
            txtKod.Location = new Point(133, 101);
            txtKod.Name = "txtKod";
            txtKod.Size = new Size(249, 31);
            txtKod.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(63, 101);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 20;
            label2.Text = "Kod:";
            // 
            // DersEkleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 778);
            Controls.Add(txtKod);
            Controls.Add(label2);
            Controls.Add(btnDersSil);
            Controls.Add(btnDersGuncelle);
            Controls.Add(btnDersEkle);
            Controls.Add(dgvDersler);
            Controls.Add(txtKredi);
            Controls.Add(txtDersAd);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "DersEkleForm";
            Text = "DersEkleForm";
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDersSil;
        private Button btnDersGuncelle;
        private Button btnDersEkle;
        private DataGridView dgvDersler;
        private TextBox txtKredi;
        private TextBox txtDersAd;
        private Label label3;
        private Label label1;
        private TextBox txtKod;
        private Label label2;
    }
}