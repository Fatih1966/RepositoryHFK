using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity.Models
{
    public class Ogrenci:Kisi
    {
        public string OgrenciNo { get; set; }
        public int SinifId { get; set; }

        //Navigation Property
        public Sinif Sinif { get; set; }
    }
}
