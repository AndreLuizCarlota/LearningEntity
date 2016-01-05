using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEntityFrameowrk.Servicos.Classes
{
  public class Conexao
  {

    protected DbContext session;

      public void Conectar()
      {
        session.Database.Connection.ConnectionString = "Data Source=ASSUNCAOD2\\SQLEXPRESS;Initial Catalog=CONTROLJOHANA;User Id=Assuncao;Password=246138Cal.;";
      }
  }
}
