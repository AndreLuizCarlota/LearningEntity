using ControlEntityFrameowrk.Servicos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlEntityFramework.Servicos.Data
{
  public class Repository : DbContext
  {

    DbContext session;
    Contexto con;

    public Repository() : base("Contexto") {  }

    
    public virtual DbContext Context
    {
      get
      {
        return session;
      }
    }
    
    public IList<TEntity> GetAll<TEntity>() where TEntity : class
    {
      return session.Set<TEntity>().ToList();
    }

    public IList<TEntity> GetAll<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
    {
      return session.Set<TEntity>().Where(predicate).ToList();
    }

    public bool Add<TEntity>(TEntity entity) where TEntity : class
    {
      if (!IsValid(entity))
        return false;
      try
      {
        session.Set(typeof(TEntity)).Add(entity);
        return session.Entry(entity).GetValidationResult().IsValid;
      }
      catch (Exception ex)
      {
        if (ex.InnerException != null)
          throw new Exception(ex.InnerException.Message, ex);
        throw new Exception(ex.Message, ex);
      }
    }

    public bool Delete<TEntity>(TEntity entity) where TEntity : class
    {
      if (!IsValid(entity))
        return false;
      try
      {
        session.Set(typeof(TEntity)).Remove(entity);
        return session.Entry(entity).GetValidationResult().IsValid;
      }
      catch (Exception ex)
      {
        if (ex.InnerException != null)
          throw new Exception(ex.InnerException.Message, ex);
        throw new Exception(ex.Message, ex);
      }
    }

    public bool Update<TEntity>(TEntity entity) where TEntity : class
    {
      if (!IsValid(entity))
        return false;
      try
      {
        session.Set(typeof(TEntity)).Attach(entity);
        session.Entry(entity).State = EntityState.Modified;
        return session.Entry(entity).GetValidationResult().IsValid;
      }
      catch (Exception ex)
      {
        if (ex.InnerException != null)
          throw new Exception(ex.InnerException.Message, ex);
        throw new Exception(ex.Message, ex);
      }
    }

    public virtual bool IsValid<TEntity>(TEntity value) where TEntity : class
    {
      if (value == null)
        throw new ArgumentNullException("A entidade não pode ser nula.");
      return true;
    }
    
    protected internal void SetDbContext(DbContext session)
    {
      if (session == null)
        throw new ArgumentNullException("DbContext: instance");
      this.session = session;
    }
  }
}
