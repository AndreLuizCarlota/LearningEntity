using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlEntityFramework.Servicos.Data;
using ControlEntityFrameowrk.Servicos.Classes;
using System.Data.Entity;

namespace ControlEntityFramework.Data.Controller
{
  public class IRepositoryClientes : IRepository<Clientes>
  {

    Contexto context;

    public IUnitOfWork Session
    {
      get
      {
        return null;
      }
    }

    public IList<Clientes> GetAll()
    {
      return context.Clientes.ToList();
    }

    public IList<Clientes> GetByEspecification(System.Linq.Expressions.Expression<Func<Clientes, bool>> predicate)
    {
      throw new NotImplementedException();
    }

    public bool Add(Clientes entity)
    {
      throw new NotImplementedException();
    }

    public bool Delete(Clientes entity)
    {
      throw new NotImplementedException();
    }

    public bool Update(Clientes entity)
    {
      throw new NotImplementedException();
    }

    public bool IsValid(Clientes entity)
    {
      throw new NotImplementedException();
    }

    public void Dispose()
    {
      throw new NotImplementedException();
    }
  }
}
