using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okul.BL.Abstract
{
    public interface IOgrenciService
    {
        //Select işlemleri
        List<Ogrenci> GetAll(Expression<Func<Ogrenci, bool>> filter = null);
        Ogrenci Find(int id);
        List<Ogrenci> GetOgrenciBySinif();


        //Crud işlemleri
        void Add(Ogrenci model);

        void Delete(Ogrenci model);

        void Update(Ogrenci model);

    }
}
