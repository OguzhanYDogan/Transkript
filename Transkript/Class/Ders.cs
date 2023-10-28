using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transkript.Enum;

namespace Transkript.Class
{
    public class Ders
    {
        public string DersKod { get; set; }
        public string DersAd { get; set; }
        public int DersKredi { get; set; }
        public HarfNotu DersHarfNotu { get; set; } = HarfNotu.Girilmedi;
        public Donem Donem { get; set; } = new();

        public override string ToString()
        {
            return $"{DersKod} - {DersAd} - Kredi: {DersKredi}";
        }
    }
}
