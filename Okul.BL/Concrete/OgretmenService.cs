using Okul.BL.Abstract;
using Okul.DAL.Abstract;
using Okul.DAL.Concrete;
using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okul.BL.Concrete
{
    public class OgretmenService : IOgretmenService
    {

        private readonly IOgretmenRepository db;
        public OgretmenService(IOgretmenRepository service)
        {
            db = service;
        }
        public void Add(Ogretmen model)
        {
            db.Add(model);
        }

        public void Delete(Ogretmen model)
        {
            db.Delete(model);
        }

        public Ogretmen Find(int id)
        {
            return db.Find(id);
        }

        public List<Ogretmen> GetAll(Expression<Func<Ogretmen, bool>> filter = null)
        {
            return db.GetAll(filter);
        }

        public List<Ogretmen> GetOgretmenByBrans()
        {
            return db.GetOgretmenByBrans();
        }

        public void Update(Ogretmen model)
        {
            db.Update(model);
        }
    }
}
