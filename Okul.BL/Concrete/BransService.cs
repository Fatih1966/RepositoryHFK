using Okul.BL.Abstract;
using Okul.DAL.Abstract;
using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okul.BL.Concrete
{
    public class BransService : IBransService
    {
        private readonly IBransRepository repository;
        public BransService(IBransRepository _repository)
        {
            repository = _repository;
        }
        public void Add(Brans model)
        {
            repository.Add(model);
        }

        public void Delete(Brans model)
        {
            repository.Delete(model);
        }

        public Brans Find(int id)
        {
            return repository.Find(id);
        }

        public List<Brans> GetAll(Expression<Func<Brans, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public List<Ogretmen> OgretmenListesiGetir(int id)
        {
            return repository.OgretmenListesiGetir(id);
        }

        public void Update(Brans model)
        {
            repository.Update(model);
        }
    }
}
