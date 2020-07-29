using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface IRepositoryBase<T> where T : class // make it generic to all model classes
    {
        ICollection<T> FindAll();

        T FindById(int id);

        bool Create(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        bool Save();


    }
}
