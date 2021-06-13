using Okul.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Okul.DAL.Abstract
{
    public interface IOgretmenRepository:IBaseRepository<Ogretmen>
    {
        List<Ogretmen> GetOgretmenByBrans();
        
    }
}
