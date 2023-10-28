namespace Transkript
{
    partial class AnaForm
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
            menuStrip1 = new MenuStrip();
            ogrenciDersEkranıToolStripMenuItem = new ToolStripMenuItem();
            ogrenciEkleToolStripMenuItem = new ToolStripMenuItem();
            dersEkleToolStripMenuItem = new ToolStripMenuItem();
            donemEkleToolStripMenuItem = new ToolStripMenuItem();
            transkriptEkraniToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ogrenciDersEkranıToolStripMenuItem, ogrenciEkleToolStripMenuItem, dersEkleToolStripMenuItem, donemEkleToolStripMenuItem, transkriptEkraniToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ogrenciDersEkranıToolStripMenuItem
            // 
            ogrenciDersEkranıToolStripMenuItem.Name = "ogrenciDersEkranıToolStripMenuItem";
            ogrenciDersEkranıToolStripMenuItem.Size = new Size(185, 29);
            ogrenciDersEkranıToolStripMenuItem.Text = "Öğrenci-Ders Ekranı";
            ogrenciDersEkranıToolStripMenuItem.Click += ogrenciDersEkranıToolStripMenuItem_Click;
            // 
            // ogrenciEkleToolStripMenuItem
            // 
            ogrenciEkleToolStripMenuItem.Name = "ogrenciEkleToolStripMenuItem";
            ogrenciEkleToolStripMenuItem.Size = new Size(126, 29);
            ogrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            ogrenciEkleToolStripMenuItem.Click += ogrenciEkleToolStripMenuItem_Click;
            // 
            // dersEkleToolStripMenuItem
            // 
            dersEkleToolStripMenuItem.Name = "dersEkleToolStripMenuItem";
            dersEkleToolStripMenuItem.Size = new Size(100, 29);
            dersEkleToolStripMenuItem.Text = "Ders Ekle";
            dersEkleToolStripMenuItem.Click += dersEkleToolStripMenuItem_Click;
            // 
            // donemEkleToolStripMenuItem
            // 
            donemEkleToolStripMenuItem.Name = "donemEkleToolStripMenuItem";
            donemEkleToolStripMenuItem.Size = new Size(123, 29);
            donemEkleToolStripMenuItem.Text = "Dönem Ekle";
            donemEkleToolStripMenuItem.Click += donemEkleToolStripMenuItem_Click;
            // 
            // transkriptEkraniToolStripMenuItem
            // 
            transkriptEkraniToolStripMenuItem.Name = "transkriptEkraniToolStripMenuItem";
            transkriptEkraniToolStripMenuItem.Size = new Size(156, 29);
            transkriptEkraniToolStripMenuItem.Text = "Transkript Ekranı";
            transkriptEkraniToolStripMenuItem.Click += transkriptEkraniToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AnaForm";
            Text = "AnaForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ogrenciDersEkranıToolStripMenuItem;
        private ToolStripMenuItem ogrenciEkleToolStripMenuItem;
        private ToolStripMenuItem dersEkleToolStripMenuItem;
        private ToolStripMenuItem donemEkleToolStripMenuItem;
        private ToolStripMenuItem transkriptEkraniToolStripMenuItem;
    }
}