namespace Transkript
{
    partial class DonemEkleForm
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
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            dgvDonemler = new DataGridView();
            txtDonemAd = new TextBox();
            label3 = new Label();
            label1 = new Label();
            nudDonemNo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvDonemler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDonemNo).BeginInit();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(27, 371);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(358, 57);
            btnSil.TabIndex = 4;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(27, 283);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(358, 57);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(27, 200);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(358, 57);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvDonemler
            // 
            dgvDonemler.AllowUserToAddRows = false;
            dgvDonemler.AllowUserToDeleteRows = false;
            dgvDonemler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDonemler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonemler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDonemler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonemler.Location = new Point(425, 12);
            dgvDonemler.MultiSelect = false;
            dgvDonemler.Name = "dgvDonemler";
            dgvDonemler.ReadOnly = true;
            dgvDonemler.RowHeadersWidth = 62;
            dgvDonemler.RowTemplate.Height = 33;
            dgvDonemler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonemler.Size = new Size(613, 784);
            dgvDonemler.TabIndex = 5;
            dgvDonemler.CellContentClick += dgvDonemler_CellContentClick;
            // 
            // txtDonemAd
            // 
            txtDonemAd.Location = new Point(136, 62);
            txtDonemAd.Name = "txtDonemAd";
            txtDonemAd.Size = new Size(249, 31);
            txtDonemAd.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 117);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 1;
            label3.Text = "Numara:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 62);
            label1.Name = "label1";
            label1.Size = new Size(43, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // nudDonemNo
            // 
            nudDonemNo.Location = new Point(136, 117);
            nudDonemNo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDonemNo.Name = "nudDonemNo";
            nudDonemNo.Size = new Size(249, 31);
            nudDonemNo.TabIndex = 1;
            nudDonemNo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DonemEkleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 813);
            Controls.Add(nudDonemNo);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgvDonemler);
            Controls.Add(txtDonemAd);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "DonemEkleForm";
            Text = "DonemEkleForm";
            ((System.ComponentModel.ISupportInitialize)dgvDonemler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDonemNo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private DataGridView dgvDonemler;
        private TextBox txtDonemAd;
        private Label label3;
        private Label label1;
        private NumericUpDown nudDonemNo;
    }
}