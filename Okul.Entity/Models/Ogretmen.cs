using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity.Models
{
    public class Ogretmen:Kisi
    {
        public int Maas { get; set; }
        public int BransId { get; set; }
        public Brans Brans { get; set; }

    }
}
