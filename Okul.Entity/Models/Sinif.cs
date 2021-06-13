using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity.Models
{
    public class Sinif : IEntity
    {
        public int Id { get ; set ; }
        public DateTime CreateDate { get ; set ; }
        public string SinifAdi { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
