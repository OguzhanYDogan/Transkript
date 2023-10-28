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
using Transkript.Enum;

namespace Transkript
{
    public partial class OgrenciDersEkleForm : Form
    {
        public static List<HarfNotu> HarfNotlari = new List<HarfNotu>()
        {
            HarfNotu.FF, HarfNotu.FD, HarfNotu.DD, HarfNotu.DC, HarfNotu.CC, HarfNotu.CB, HarfNotu.BB, HarfNotu.BA, HarfNotu.AA
        };
        public static List<Ogrenci> DersiEklenenOgrenciler = new List<Ogrenci>();
        public OgrenciDersEkleForm()
        {
            InitializeComponent();
            foreach (Ogrenci ogrenci in OgrenciEkleForm.Ogrenciler)
            {
                cboOgrenci.Items.Add(ogrenci);
            }
            foreach (Donem donem in DonemEkleForm.Donemler)
            {
                cboDonem.Items.Add(donem);
            }
            foreach (Ders ders in DersEkleForm.Dersler)
            {
                cboDers.Items.Add(ders);
            }
            foreach (HarfNotu h in HarfNotlari)
            {
                cboHarfNotu.Items.Add(h);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = OgrenciEkleForm.Ogrenciler[cboOgrenci.SelectedIndex];
            Ogrenci dersiEklenenOgrenci = ogrenci;

            if (!dersiEklenenOgrenci.OgrenciAlinanDonemler.Contains((Donem)cboDonem.SelectedItem))
                dersiEklenenOgrenci.OgrenciAlinanDonemler.Add((Donem)cboDonem.SelectedItem);
            Ders eklenecekDers = new Ders();
            eklenecekDers.DersAd = ((Ders)cboDers.SelectedItem).DersAd;
            eklenecekDers.DersKod = ((Ders)cboDers.SelectedItem).DersKod;
            eklenecekDers.DersKredi = ((Ders)cboDers.SelectedItem).DersKredi;
            eklenecekDers.Donem = (Donem)cboDonem.SelectedItem;
            eklenecekDers.DersHarfNotu = (HarfNotu)cboHarfNotu.SelectedItem;

            if (dersiEklenenOgrenci.OgrenciAlinanDersler.Any(d => d.DersKod == eklenecekDers.DersKod && d.Donem.DonemNo == eklenecekDers.Donem.DonemNo))
            {
                MessageBox.Show("Öğrenci dersi zaten almış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dersiEklenenOgrenci.OgrenciAlinanDersler.Add(eklenecekDers);
            if (!DersiEklenenOgrenciler.Contains(dersiEklenenOgrenci))
            {
                DersiEklenenOgrenciler.Add(dersiEklenenOgrenci);
            }
            MessageBox.Show("Ders Notu Girişi Başarılı");
        }
    }
}
