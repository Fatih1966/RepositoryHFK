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
    public class SinifService : ISinifService
    {
        private readonly ISinifRepository repository;
        public SinifService(ISinifRepository _repository)
        {
            repository = _repository;
        }
        public void Add(Sinif model)
        {
            repository.Add(model);
        }

        public void Delete(Sinif model)
        {
            repository.Delete(model);
        }

        public Sinif Find(int id)
        {
            return repository.Find(id);
        }

        public List<Sinif> GetAll(Expression<Func<Sinif, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public List<Ogrenci> SinifListesiGetir(int id)
        {
            return repository.SinifListesiGetir(id);
        }

        public void Update(Sinif model)
        {
            repository.Update(model);
        }
    }
}
