using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEntityFramework.Servicos.Data
{
  public class Contexto 
  {
    public DbSet<Clientes> Clientes { get; set; }
  }
}
