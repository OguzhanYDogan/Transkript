namespace Transkript
{
    partial class OgrenciEkleForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNumara = new TextBox();
            dgvOgrenciler = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 52);
            label1.Name = "label1";
            label1.Size = new Size(43, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 126);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 200);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 2;
            label3.Text = "Numara:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(139, 52);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(249, 31);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(139, 126);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(249, 31);
            txtSoyad.TabIndex = 4;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(139, 200);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(249, 31);
            txtNumara.TabIndex = 5;
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.AllowUserToAddRows = false;
            dgvOgrenciler.AllowUserToDeleteRows = false;
            dgvOgrenciler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOgrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgrenciler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Location = new Point(409, 12);
            dgvOgrenciler.MultiSelect = false;
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.ReadOnly = true;
            dgvOgrenciler.RowHeadersWidth = 62;
            dgvOgrenciler.RowTemplate.Height = 33;
            dgvOgrenciler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgrenciler.Size = new Size(574, 712);
            dgvOgrenciler.TabIndex = 6;
            dgvOgrenciler.CellContentClick += dgvOgrenciler_CellContentClick;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(30, 289);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(358, 57);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(30, 372);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(358, 57);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(30, 460);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(358, 57);
            btnSil.TabIndex = 9;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // OgrenciEkleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 736);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgvOgrenciler);
            Controls.Add(txtNumara);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciEkleForm";
            Text = "OgrenciEkleForm";
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNumara;
        private DataGridView dgvOgrenciler;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
    }
}