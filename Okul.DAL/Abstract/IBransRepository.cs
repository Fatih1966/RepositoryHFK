using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.DAL.Abstract
{
    public interface IBransRepository:IBaseRepository<Brans>
    {
        List<Ogretmen> OgretmenListesiGetir(int Id);
    }
}
