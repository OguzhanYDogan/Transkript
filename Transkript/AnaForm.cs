using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transkript
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        public void FormGoster(Form secilenForm)
        {
            secilenForm.StartPosition = 0;
            Width = secilenForm.Width + 100;
            Height = secilenForm.Height + 100;
            bool durum = false; // en başta formun çocuğu yok 

            // Bu anaformun çocukları içerisinde gezelim. - MDI (multiple document interface)

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == secilenForm.Text)
                {
                    durum = true;
                    form.Show(); // istenilenin açılması 
                }
                else
                    form.Close(); // açık olan varsa kapatılsın.
            }
            if (!durum) // Eğer ilk açılış ise ve hiç çocuk yoksa burayı çalıştır.
            {
                secilenForm.MdiParent = this;
                secilenForm.Show();

            }
        }

        private void ogrenciDersEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciDersEkleForm());
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new OgrenciEkleForm());
        }

        private void dersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new DersEkleForm());
        }

        private void donemEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new DonemEkleForm());
        }

        private void transkriptEkraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new TranskriptForm());
        }
    }
}
