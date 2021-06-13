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
    public class OgrenciRepository : BaseRepository<Ogrenci>, IOgrenciRepository
    {
        public List<Ogrenci> GetOgrenciBySinif()
        {
            var result = (from ogr in base.db.Ogrenciler
                          join sinif in base.db.Siniflar
                          on ogr.SinifId equals sinif.Id
                          select new Ogrenci
                          {
                              Ad = ogr.Ad,
                              CepTelefonu = ogr.CepTelefonu,
                              Email = ogr.Email,
                              Id = ogr.Id,
                              OgrenciNo = ogr.OgrenciNo,
                              Soyad = ogr.Soyad,
                              Sinif=sinif,
                              TCKimlik = ogr.TCKimlik,
                              CreateDate = ogr.CreateDate
                          }).ToList();
            return result;
        }
    }
}
