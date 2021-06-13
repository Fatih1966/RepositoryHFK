using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okul.BL.Abstract
{
    public interface IOgretmenService
    {
        //Select işlemleri
        List<Ogretmen> GetAll(Expression<Func<Ogretmen, bool>> filter = null);
        Ogretmen Find(int id);

        List<Ogretmen> GetOgretmenByBrans();
        //Crud işlemleri
        void Add(Ogretmen model);

        void Delete(Ogretmen model);

        void Update(Ogretmen model);
    }
}
