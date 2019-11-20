using Microsoft.EntityFrameworkCore;
using RP.Domain.Core.Entities;
using RP.Domain.Core.Interfaces;
using RP.Domain.Entities.UserAgg;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace RP.Data.DataContext
{
    public class SampleDataContext : DbContext, ISampleDataContext
    {
        private readonly IServiceProvider _services;

        public SampleDataContext(DbContextOptions<SampleDataContext> options, IServiceProvider services)
            : base(options)
        {
            _services = services;
        }


        DbConnection ISampleDataContext.GetDbConnection() => Database.GetDbConnection();
        void ISampleDataContext.OpenConnection() => Database.OpenConnection();
        void ISampleDataContext.CloseConnection() => Database.CloseConnection();

        #region [DbSets]
        public DbSet<User> Users { get; set; }
        #endregion

        #region [ Repository Getter ]

        public IAsyncRepository<TEntity> GetAsyncRepositoryByEntity<TEntity>() where TEntity : BaseEntity
        {
            var entityTypeName = $"I{typeof(TEntity).Name}Repository";
            var namespaceName = typeof(TEntity).Namespace.Split(".Entities")[0];
            var repositoryTypeName = $"{typeof(TEntity).Namespace}.Interfaces.{entityTypeName}, {namespaceName}";

            Type repositoryType = Type.GetType(typeName: repositoryTypeName, ignoreCase: true, throwOnError: false);
            if (repositoryType == null)
                repositoryType = typeof(IAsyncRepository<TEntity>);

            return _services.GetService(repositoryType) as IAsyncRepository<TEntity>;
        }

        public IRepository<TEntity> GetRepositoryByEntity<TEntity>() where TEntity : BaseEntity
        {
            var entityTypeName = $"I{typeof(TEntity).Name}Repository";
            var namespaceName = typeof(TEntity).Namespace.Split(".Entities")[0];
            var repositoryTypeName = $"{typeof(TEntity).Namespace}.Interfaces.{entityTypeName}, {namespaceName}";

            Type repositoryType = Type.GetType(typeName: repositoryTypeName, ignoreCase: true, throwOnError: false);
            if (repositoryType == null)
                repositoryType = typeof(IRepository<TEntity>);

            return _services.GetService(repositoryType) as IRepository<TEntity>;
        }
        #endregion
    }
}
