using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okul.BL.Abstract
{
    public interface IBransService
    {
        //Select işlemleri
        List<Brans> GetAll(Expression<Func<Brans, bool>> filter = null);
        Brans Find(int id);


        //Crud işlemleri
        void Add(Brans model);

        void Delete(Brans model);

        void Update(Brans model);
        List<Ogretmen> OgretmenListesiGetir(int Id);

    }
}
