using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okul.BL.Abstract
{
    public interface ISinifService
    {
        //Select işlemleri
        List<Sinif> GetAll(Expression<Func<Sinif, bool>> filter = null);
        Sinif Find(int id);


        //Crud işlemleri
        void Add(Sinif model);

        void Delete(Sinif model);

        void Update(Sinif model);
        
        List<Ogrenci> SinifListesiGetir(int id);
    }
}
