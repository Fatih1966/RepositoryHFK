using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okul.DAL.Abstract
{
    public interface IBaseRepository<Type>  where Type:class,new()
    {

        //Select işlemleri
        List<Type> GetAll(Expression<Func<Type, bool>> filter = null);
        Type Find(int id);


        //Crud işlemleri
        void Add(Type model);

        void Delete(Type model);

        void Update(Type model);

     
    }
}
