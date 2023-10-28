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
    public partial class DersEkleForm : Form
    {
        public static List<Ders> Dersler = new()
        {
            new Ders { DersKod = "MAT101", DersAd = "Matematik", DersKredi = 6 },
            new Ders { DersKod = "FİZ101", DersAd = "Fizik", DersKredi = 5 },
            new Ders { DersKod = "KİM101", DersAd = "Kimya", DersKredi = 4 },
            new Ders { DersKod = "BİO101", DersAd = "Biyoloji", DersKredi = 5 },
            new Ders { DersKod = "GEO101", DersAd = "Geometri", DersKredi = 3 },
            new Ders { DersKod = "ENG101", DersAd = "İngilizce", DersKredi = 2 },
        };
        public DersEkleForm()
        {
            InitializeComponent();
            if (dgvDersler.SelectedRows.Count == 0)
            {
                btnDersGuncelle.Enabled = false;
                btnDersSil.Enabled = false;
            }
            Listele();
            dgvDersler.Columns[3].Visible = false;
            dgvDersler.Columns[4].Visible = false;
        }

        private void Listele()
        {
            dgvDersler.DataSource = Dersler;
            dgvDersler.Refresh();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDersAd.Text) || string.IsNullOrWhiteSpace(txtKod.Text) || string.IsNullOrWhiteSpace(txtKredi.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }
            if (!int.TryParse(txtKredi.Text, out int sonuc))
            {
                MessageBox.Show("Kredi sadece rakam olabilir.");
                return;
            }
            if (Dersler.Any(d => d.DersKod == txtKod.Text.Trim()))
            {
                MessageBox.Show("Aynı kodda ders mevcut!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Ders ders = new Ders();
            ders.DersKod = txtKod.Text.Trim().ToUpper();
            ders.DersAd = txtDersAd.Text.Trim();
            ders.DersKredi = Convert.ToInt32(txtKredi.Text.Trim());
            Dersler.Add(ders);
            dgvDersler.DataSource = Dersler.ToList();
            dgvDersler.Refresh();
            txtDersAd.Clear();
            txtKredi.Clear();
            txtKod.Clear();
        }
        private void dgvDersler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Ders ders = (Ders)dgvDersler.SelectedRows[0].DataBoundItem;
            txtKod.Text = ders.DersKod;
            txtDersAd.Text = ders.DersAd;
            txtKredi.Text = ders.DersKredi.ToString();
            btnDersGuncelle.Enabled = true;
            btnDersSil.Enabled = true;
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            Ders ders = (Ders)dgvDersler.SelectedRows[0].DataBoundItem;
            Ders secilenDers = Dersler.Find(d => d.DersKod == ders.DersKod)!;
            if (Dersler.Any(d => d.DersKod == txtKod.Text.Trim().ToUpper()) && txtKod.Text.Trim().ToUpper() != ders.DersKod)
            {
                MessageBox.Show("Aynı kodda ders mevcut!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (secilenDers != null)
            {
                secilenDers.DersKod = txtKod.Text.Trim().ToUpper();
                secilenDers.DersAd = txtDersAd.Text.Trim();
                secilenDers.DersKredi = Convert.ToInt32(txtKredi.Text.Trim());
            }
            else
            {
                MessageBox.Show("HATA");
                return;
            }
            dgvDersler.Refresh();
            txtDersAd.Clear();
            txtKredi.Clear();
            txtKod.Clear();
            btnDersGuncelle.Enabled = false;
            btnDersSil.Enabled = false;
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            Ders ders = (Ders)dgvDersler.SelectedRows[0].DataBoundItem;
            Dersler.Remove(ders);
            dgvDersler.DataSource = Dersler.ToList();
            dgvDersler.Refresh();
            btnDersGuncelle.Enabled = false;
            btnDersSil.Enabled = false;
        }
    }
}
