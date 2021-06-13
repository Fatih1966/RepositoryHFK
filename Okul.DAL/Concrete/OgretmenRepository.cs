using Okul.DAL.Abstract;
using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okul.DAL.Concrete
{
    public class OgretmenRepository : BaseRepository<Ogretmen>, IOgretmenRepository

    {
        public List<Ogretmen> GetOgretmenByBrans()
        {
            var result = (from ogrtmn in base.db.Ogretmenler
                          join brans in base.db.Branslar
                          on ogrtmn.BransId equals brans.Id
                          select new Ogretmen
                          {
                              Id=ogrtmn.Id,
                              Ad = ogrtmn.Ad,
                              Soyad = ogrtmn.Soyad,
                              CepTelefonu = ogrtmn.CepTelefonu,
                              Email = ogrtmn.Email,
                              Brans = brans,
                              BransId = ogrtmn.BransId,
                              TCKimlik=ogrtmn.TCKimlik,
                              CreateDate=ogrtmn.CreateDate,
                              Maas=ogrtmn.Maas
                              
                          }).ToList();
            return result;
        }
    }
}
