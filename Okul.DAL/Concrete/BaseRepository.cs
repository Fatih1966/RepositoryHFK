using Microsoft.EntityFrameworkCore;
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
    public class BaseRepository<Type> : IBaseRepository<Type> 
        where Type:class,new()
        
    {

        protected OkulDbContext db;

        public BaseRepository()
        {
            db = new OkulDbContext();
        }
        public void Add(Type model)
        {
            db.Set<Type>().Add(model);
            db.SaveChanges();
        }

        public void Delete(Type model)
        {
            db.Set<Type>().Remove(model);
            db.SaveChanges();
        }

        public Type Find(int id)
        {
            return db.Set<Type>().Find(id);
            
        }

        public List<Type> GetAll(Expression<Func<Type, bool>> filter = null)
        {
            if(filter==null)
                return db.Set<Type>().ToList();
            else
                return db.Set<Type>().Where(filter).ToList();
        }

        

        public void Update(Type model)
        {
            var result = db.Entry<Type>(model);
            result.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
