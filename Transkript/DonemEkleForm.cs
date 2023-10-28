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
    public partial class DonemEkleForm : Form
    {
        public static List<Donem> Donemler = new()
        {
            new Donem { DonemNo = 1, DonemAd = "2020 - 2021 Güz" },
            new Donem { DonemNo = 2, DonemAd = "2020 - 2021 Bahar" },
            new Donem { DonemNo = 3, DonemAd = "2021 - 2022 Güz" },
            new Donem { DonemNo = 4, DonemAd = "2021 - 2022 Bahar" }
        };
        public DonemEkleForm()
        {
            InitializeComponent();
            if (dgvDonemler.SelectedRows.Count == 0)
            {
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
            }
            Listele();
        }

        private void Listele()
        {
            dgvDonemler.DataSource = Donemler;
            dgvDonemler.Refresh();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonemAd.Text))
            {
                MessageBox.Show("Lütfen Ad kısmını doldurunuz");
                return;
            }
            if (Donemler.Any(d => d.DonemNo == (int)nudDonemNo.Value))
            {
                MessageBox.Show("Girdiğiniz Numarada bir dönem mevcut", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Donem donem = new Donem();
            donem.DonemAd = txtDonemAd.Text;
            donem.DonemNo = (int)nudDonemNo.Value;
            Donemler.Add(donem);
            dgvDonemler.DataSource = Donemler.ToList();
            dgvDonemler.Refresh();
            txtDonemAd.Clear();
            nudDonemNo.Value = donem.DonemNo + 1;
        }
        private void dgvDonemler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Donem donem = (Donem)dgvDonemler.SelectedRows[0].DataBoundItem;
            txtDonemAd.Text = donem.DonemAd;
            nudDonemNo.Value = (int)donem.DonemNo;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Donem donem = (Donem)dgvDonemler.SelectedRows[0].DataBoundItem;
            Donem secilenDonem = Donemler.Find(d => d.DonemNo == donem.DonemNo);
            if (Donemler.Any(d => d.DonemNo == (int)nudDonemNo.Value) && (int)nudDonemNo.Value != donem.DonemNo)
            {
                MessageBox.Show("Girdiğiniz Numarada bir dönem mevcut", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (secilenDonem != null)
            {
                secilenDonem.DonemAd = txtDonemAd.Text.Trim();
                secilenDonem.DonemNo = (int)nudDonemNo.Value;
            }
            else
            {
                MessageBox.Show("HATA");
                return;
            }
            dgvDonemler.Refresh();
            txtDonemAd.Clear();
            nudDonemNo.Value = 1;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Donem donem = (Donem)dgvDonemler.SelectedRows[0].DataBoundItem;
            Donem secilenDonem = Donemler.Find(d => d.DonemNo == donem.DonemNo);
            if (secilenDonem != null)
                Donemler.Remove(secilenDonem);
            dgvDonemler.DataSource = Donemler.ToList();
            dgvDonemler.Refresh();
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
    }
}
