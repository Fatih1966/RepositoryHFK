using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Entity.Models
{
    public class Kisi : IEntity
    {
        public int Id { get ; set ; }
        public DateTime CreateDate { get ; set ; }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string CepTelefonu { get; set; }
        public string TCKimlik { get; set; }
    }
}
