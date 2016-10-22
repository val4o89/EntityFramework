using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORMProject.Interfaces
{
    public interface IDbContext
    {
        bool Persist(object entity);

        //T FindById(int id);

        //IEnumerable<T> FindAll();

        //IEnumerable<T> FindAll(string where);

        //T FindFirst();

        //T FindFirst(string where);
    }
}
