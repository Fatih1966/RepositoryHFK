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
    public class OgrenciService : IOgrenciService
    {

        private readonly IOgrenciRepository db;
        public OgrenciService(IOgrenciRepository service)
        {
            db = service;
        }
        public void Add(Ogrenci model)
        {
            db.Add(model);
        }

        public void Delete(Ogrenci model)
        {
            db.Delete(model);
        }

        public Ogrenci Find(int id)
        {
            return db.Find(id);
        }

        public List<Ogrenci> GetAll(Expression<Func<Ogrenci, bool>> filter = null)
        {
            return db.GetAll(filter);
        }

        public List<Ogrenci> GetOgrenciBySinif()
        {
            return db.GetOgrenciBySinif();
        }

        public void Update(Ogrenci model)
        {
            db.Update(model);
        }
    }
}
