using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlEntityFrameowrk.Servicos.Classes
{
  public interface IRepository<T> : IDisposable where T : class
  {
    IUnitOfWork Session { get; }
    IList<T> GetAll();
    IList<T> GetByEspecification(Expression<Func<T, bool>> predicate);
    bool Add(T entity);
    bool Delete(T entity);
    bool Update(T entity);
    bool IsValid(T entity);
  }
}
