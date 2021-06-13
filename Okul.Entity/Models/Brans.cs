using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity.Models
{
    public class Brans : IEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get ; set; }
        public string BransAdi { get; set; }
        public ICollection<Ogretmen> Ogretmenler { get; set; }
    }
}
