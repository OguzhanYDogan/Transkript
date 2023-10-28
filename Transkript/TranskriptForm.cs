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
    public partial class TranskriptForm : Form
    {
        public TranskriptForm()
        {
            InitializeComponent();
            foreach (Ogrenci o in OgrenciDersEkleForm.DersiEklenenOgrenciler)
            {
                cboDersiEklenenOgrenciler.Items.Add(o);
            }

        }

        private void btnGor_Click(object sender, EventArgs e)
        {
            int kredi = 0;
            decimal donemOrt = 0;
            List<Ders> donemdekiDersler = new List<Ders>();
            Ogrenci secilenOgrenci = (Ogrenci)cboDersiEklenenOgrenciler.SelectedItem;
            lblDonemAdi.Text = ((Donem)cboDonemler.SelectedItem).DonemAd;
            foreach (Ders ders in secilenOgrenci.OgrenciAlinanDersler)
            {
                if (ders.Donem == (Donem)cboDonemler.SelectedItem)
                {
                    donemdekiDersler.Add(ders);
                    kredi += ders.DersKredi;
                    donemOrt += (decimal)ders.DersHarfNotu / 10 * ders.DersKredi;
                }
            }
            dgvTranskript.DataSource = donemdekiDersler.ToList();
            dgvTranskript.Refresh();
            dgvTranskript.Columns[4].Visible = false;
            donemOrt = donemOrt / kredi;
            lblDonemKredi.Text = kredi.ToString();
            lblDonemOrt.Text = donemOrt.ToString("0.00");

        }

        private void cboDersiEklenenOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDersiEklenenOgrenciler.SelectedIndex != -1)
            {
                Ogrenci secilenOgrenci = (Ogrenci)cboDersiEklenenOgrenciler.SelectedItem;
                foreach (Donem donem in secilenOgrenci.OgrenciAlinanDonemler)
                {
                    cboDonemler.Items.Add(donem);
                }
            }
            GenelOrtalamaHesapla();
        }

        private void GenelOrtalamaHesapla()
        {
            int toplamKredi = 0;
            decimal genelOrt = 0;
            Ogrenci secilenOgrenci = (Ogrenci)cboDersiEklenenOgrenciler.SelectedItem;
            toplamKredi = secilenOgrenci.OgrenciAlinanDersler.Sum(d => d.DersKredi);
            genelOrt = secilenOgrenci.OgrenciAlinanDersler.Sum(d => ((int)d.DersHarfNotu / 10m) * d.DersKredi);
            genelOrt /= toplamKredi;
            lblGenelOrt.Text = genelOrt.ToString("0.00");
            lblGenelKredi.Text = toplamKredi.ToString();
        }
    }
}
