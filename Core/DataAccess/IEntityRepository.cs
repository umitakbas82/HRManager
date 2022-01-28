using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<E>where  E:class, IEntity,new()
    {
        List<E> GetAll(Expression<Func<E, bool>> filter = null);
        E Get(Expression<Func<E, bool>> filter);

        void Add();
        void Update();
        void Delete();


    }
}
