using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ControlEntityFrameowrk.Servicos.Classes
{
  public interface IUnitOfWork : IDisposable
  {
    void BeginTransaction();

    void Commit(SaveOptions saveOptions);
  }
}
