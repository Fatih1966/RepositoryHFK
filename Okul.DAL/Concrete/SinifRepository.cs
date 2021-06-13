using Microsoft.EntityFrameworkCore;
using Okul.DAL.Abstract;
using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.DAL.Concrete
{
    public class SinifRepository : BaseRepository<Sinif>, ISinifRepository
    
    {


        public SinifRepository():base()
        {
         
        }

        public List<Ogrenci> SinifListesiGetir(int id)
        {


            var result = base.db.Ogrenciler.Where(p => p.Sinif.Id == id);

            return result.ToList();

        }

        //List<Ogrenci> SinifListesi(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
