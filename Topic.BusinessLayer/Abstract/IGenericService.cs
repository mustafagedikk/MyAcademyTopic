using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Topic.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetlist();

        List<T> TGetFilterList(Expression<Func<T, bool>> filter);
        T TGetById(int id);

        T TGetByFilter(Expression<Func<T, bool>> filter);

        void TDelete(int id);
        void TCreate(T entity);
        void TUpdate(T entity);
    }
}
