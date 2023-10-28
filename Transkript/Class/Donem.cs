using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transkript.Class
{
    public class Donem
    {
        public int DonemNo { get; set; }
        public string DonemAd { get; set; }
        public override string ToString()
        {
            return $"{DonemNo} - {DonemAd}";
        }
    }
}
