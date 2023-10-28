namespace Transkript
{
    partial class TranskriptForm
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
            cboDersiEklenenOgrenciler = new ComboBox();
            btnGor = new Button();
            cboDonemler = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dgvTranskript = new DataGridView();
            label3 = new Label();
            lblDonemKredi = new Label();
            label5 = new Label();
            lblDonemOrt = new Label();
            label7 = new Label();
            lblGenelOrt = new Label();
            lblDonemAdi = new Label();
            lblGenelKredi = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTranskript).BeginInit();
            SuspendLayout();
            // 
            // cboDersiEklenenOgrenciler
            // 
            cboDersiEklenenOgrenciler.FormattingEnabled = true;
            cboDersiEklenenOgrenciler.Location = new Point(169, 69);
            cboDersiEklenenOgrenciler.Name = "cboDersiEklenenOgrenciler";
            cboDersiEklenenOgrenciler.Size = new Size(329, 33);
            cboDersiEklenenOgrenciler.TabIndex = 1;
            cboDersiEklenenOgrenciler.SelectedIndexChanged += cboDersiEklenenOgrenciler_SelectedIndexChanged;
            // 
            // btnGor
            // 
            btnGor.Location = new Point(427, 108);
            btnGor.Name = "btnGor";
            btnGor.Size = new Size(182, 34);
            btnGor.TabIndex = 2;
            btnGor.Text = "Transkript Gör";
            btnGor.UseVisualStyleBackColor = true;
            btnGor.Click += btnGor_Click;
            // 
            // cboDonemler
            // 
            cboDonemler.FormattingEnabled = true;
            cboDonemler.Location = new Point(504, 69);
            cboDonemler.Name = "cboDonemler";
            cboDonemler.Size = new Size(329, 33);
            cboDonemler.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 41);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 5;
            label1.Text = "Öğrenci";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 41);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 6;
            label2.Text = "Dönem";
            // 
            // dgvTranskript
            // 
            dgvTranskript.AllowUserToAddRows = false;
            dgvTranskript.AllowUserToDeleteRows = false;
            dgvTranskript.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTranskript.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTranskript.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTranskript.Location = new Point(12, 171);
            dgvTranskript.Name = "dgvTranskript";
            dgvTranskript.ReadOnly = true;
            dgvTranskript.RowHeadersWidth = 62;
            dgvTranskript.RowTemplate.Height = 33;
            dgvTranskript.Size = new Size(1057, 414);
            dgvTranskript.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 608);
            label3.Name = "label3";
            label3.Size = new Size(170, 30);
            label3.TabIndex = 8;
            label3.Text = "Dönem Kredisi:";
            // 
            // lblDonemKredi
            // 
            lblDonemKredi.AutoSize = true;
            lblDonemKredi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonemKredi.Location = new Point(231, 608);
            lblDonemKredi.Name = "lblDonemKredi";
            lblDonemKredi.Size = new Size(22, 30);
            lblDonemKredi.TabIndex = 9;
            lblDonemKredi.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 662);
            label5.Name = "label5";
            label5.Size = new Size(213, 30);
            label5.TabIndex = 10;
            label5.Text = "Dönem Ortalaması:";
            // 
            // lblDonemOrt
            // 
            lblDonemOrt.AutoSize = true;
            lblDonemOrt.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonemOrt.Location = new Point(231, 662);
            lblDonemOrt.Name = "lblDonemOrt";
            lblDonemOrt.Size = new Size(22, 30);
            lblDonemOrt.TabIndex = 11;
            lblDonemOrt.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(789, 662);
            label7.Name = "label7";
            label7.Size = new Size(182, 30);
            label7.TabIndex = 12;
            label7.Text = "Genel Ortalama:";
            // 
            // lblGenelOrt
            // 
            lblGenelOrt.AutoSize = true;
            lblGenelOrt.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenelOrt.Location = new Point(994, 662);
            lblGenelOrt.Name = "lblGenelOrt";
            lblGenelOrt.Size = new Size(22, 30);
            lblGenelOrt.TabIndex = 13;
            lblGenelOrt.Text = "-";
            // 
            // lblDonemAdi
            // 
            lblDonemAdi.AutoSize = true;
            lblDonemAdi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonemAdi.Location = new Point(12, 138);
            lblDonemAdi.Name = "lblDonemAdi";
            lblDonemAdi.Size = new Size(0, 30);
            lblDonemAdi.TabIndex = 14;
            // 
            // lblGenelKredi
            // 
            lblGenelKredi.AutoSize = true;
            lblGenelKredi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenelKredi.Location = new Point(994, 608);
            lblGenelKredi.Name = "lblGenelKredi";
            lblGenelKredi.Size = new Size(22, 30);
            lblGenelKredi.TabIndex = 16;
            lblGenelKredi.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(832, 608);
            label6.Name = "label6";
            label6.Size = new Size(139, 30);
            label6.TabIndex = 15;
            label6.Text = "Genel Kredi:";
            // 
            // TranskriptForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 706);
            Controls.Add(lblGenelKredi);
            Controls.Add(label6);
            Controls.Add(lblDonemAdi);
            Controls.Add(lblGenelOrt);
            Controls.Add(label7);
            Controls.Add(lblDonemOrt);
            Controls.Add(label5);
            Controls.Add(lblDonemKredi);
            Controls.Add(label3);
            Controls.Add(dgvTranskript);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboDonemler);
            Controls.Add(btnGor);
            Controls.Add(cboDersiEklenenOgrenciler);
            Name = "TranskriptForm";
            Text = "TranskriptForm";
            ((System.ComponentModel.ISupportInitialize)dgvTranskript).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboDersiEklenenOgrenciler;
        private Button btnGor;
        private ComboBox cboDonemler;
        private Label label1;
        private Label label2;
        private DataGridView dgvTranskript;
        private Label label3;
        private Label lblDonemKredi;
        private Label label5;
        private Label lblDonemOrt;
        private Label label7;
        private Label lblGenelOrt;
        private Label lblDonemAdi;
        private Label lblGenelKredi;
        private Label label6;
    }
}