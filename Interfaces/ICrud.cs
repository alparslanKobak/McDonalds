using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McDonalds.Entity.Models;
namespace McDonalds.Entity.Interfaces
{
    public interface ICrud<T>
    {
        bool Add(T entity);
        bool Update(T entity, int id);
        bool Delete(int id);

        T GetById(int id);
        List<T> GetAll();

    }
}
