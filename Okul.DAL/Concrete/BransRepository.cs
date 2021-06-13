using Okul.DAL.Abstract;
using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.DAL.Concrete
{
    public class BransRepository:BaseRepository<Brans>,IBransRepository
    {

        public List<Ogretmen> OgretmenListesiGetir(int Id)
        {
            var result = base.db.Ogretmenler.Where(p => p.BransId == Id);
            return result.ToList();
        }
    }
}
