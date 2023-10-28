using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transkript.Class
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
        public List<Donem> OgrenciAlinanDonemler { get; set; }= new();
        public List<Ders> OgrenciAlinanDersler { get; set; }= new();
        public override string ToString()
        {
            return $"{Numara} - {Ad} {Soyad}";
        }
    }
}
