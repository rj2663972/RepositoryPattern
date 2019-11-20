using RP.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace RP.Domain.Core.Interfaces
{
    public interface ISampleDataContext
    {
        IAsyncRepository<TEntity> GetAsyncRepositoryByEntity<TEntity>() where TEntity : BaseEntity;
        IRepository<TEntity> GetRepositoryByEntity<TEntity>() where TEntity : BaseEntity;
        DbConnection GetDbConnection();
        void OpenConnection();
        void CloseConnection();
    }
}
