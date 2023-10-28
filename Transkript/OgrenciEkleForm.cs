using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transkript.Class;

namespace Transkript
{
    public partial class OgrenciEkleForm : Form
    {
        public static List<Ogrenci> Ogrenciler = new List<Ogrenci>()
        {
            new Ogrenci { Ad = "Ali" , Soyad = "Yıldız" , Numara = "12345678" },
            new Ogrenci { Ad = "Veli" , Soyad = "Yıldız" , Numara = "1234567" },
            new Ogrenci { Ad = "Ayşe" , Soyad = "Yıldız" , Numara = "123456" },
            new Ogrenci { Ad = "Mehmet" , Soyad = "Yıldız" , Numara = "12345" }
        };
        public OgrenciEkleForm()
        {
            InitializeComponent();
            if (dgvOgrenciler.SelectedRows.Count == 0)
            {
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
            }
            Listele();
        }

        private void Listele()
        {
            dgvOgrenciler.DataSource = Ogrenciler.ToList();
            dgvOgrenciler.Refresh();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtNumara.Text))
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
                return;
            }
            if (Ogrenciler.Any(x => x.Numara == txtNumara.Text))
            {
                MessageBox.Show("Girdiğiniz numara kullanımda.","HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txtAd.Text.Trim();
            ogrenci.Soyad = txtSoyad.Text.Trim();
            ogrenci.Numara = txtNumara.Text.Trim();
            Ogrenciler.Add(ogrenci);
            dgvOgrenciler.DataSource = Ogrenciler.ToList();
            dgvOgrenciler.Refresh();
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
        }

        private void dgvOgrenciler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Ogrenci ogrenci = (Ogrenci)dgvOgrenciler.SelectedRows[0].DataBoundItem;
            txtAd.Text = ogrenci.Ad;
            txtSoyad.Text = ogrenci.Soyad;
            txtNumara.Text = ogrenci.Numara;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = (Ogrenci)dgvOgrenciler.SelectedRows[0].DataBoundItem;
            Ogrenci secilenOgrenci = Ogrenciler.Find(o => o.Numara == ogrenci.Numara);
            if (Ogrenciler.Any(x => x.Numara == txtNumara.Text.Trim()) && txtNumara.Text.Trim() != ogrenci.Numara)
            {
                MessageBox.Show("Girdiğiniz numara kullanımda.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (secilenOgrenci != null)
            {
                secilenOgrenci.Ad = txtAd.Text.Trim();
                secilenOgrenci.Soyad = txtSoyad.Text.Trim();
                secilenOgrenci.Numara = txtNumara.Text.Trim();
            }
            else
            {
                MessageBox.Show("Hata");
                return;
            }
            dgvOgrenciler.Refresh();
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = (Ogrenci)dgvOgrenciler.SelectedRows[0].DataBoundItem;
            Ogrenci secilenOgrenci = Ogrenciler.Find(o => o.Numara == ogrenci.Numara);
            if (secilenOgrenci != null)
                Ogrenciler.Remove(ogrenci);
            dgvOgrenciler.DataSource = Ogrenciler.ToList();
            dgvOgrenciler.Refresh();
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
    }
}
