using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlEntityFrameowrk.Servicos.Classes;
using ControlEntityFramework.Data.IRepository;
using ControlEntityFramework.Data.Data;

namespace ControlEntityFramework.Data.Controller
{
  public class IRepositoryClientes : IRepository<Clientes>
  {
    Contexto context = new Contexto();

    public IUnitOfWork Session
    {
      get { throw new NotImplementedException(); }
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
