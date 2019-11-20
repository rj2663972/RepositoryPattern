using RP.Domain.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.Domain.Core.Interfaces
{
    public interface IAsyncRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<T> GetSingleBySpecAsync(ISpecification<T> spec);
        Task<T> GetFirstBySpecAsync(ISpecification<T> spec);
        Task<T> GetFirstBySpecAsyncAsNoTracking(ISpecification<T> spec);
        Task<List<T>> GetListAsync(ISpecification<T> spec);
        Task<int> CountBySpecAsync(ISpecification<T> spec);
        IQueryable<T> GetQueryableBySpec(ISpecification<T> spec);
        Task<List<T>> GetAllAsync();

        /// <summary>
        /// Add entity in context, you MUST CALL SaveContextAsync after this, in order to persist entity in the database
        /// </summary>
        Task AddNotSaveChangesAsync(T entity);

        /// <summary>
        /// Update entity in context, you MUST CALL SaveContextAsync after this, in order to persist entity in the database
        /// </summary>
        void UpdateNotSaveChanges(T entity);

        /// <summary>
        /// Remove entity in context, you MUST CALL SaveContextAsync after this, in order to persist entity in the database
        /// </summary>
        void RemoveNotSaveChanges(T entity);

        /// <summary>
        /// Add entity in context and SAVE ALL CHANGES CONTEXT
        /// </summary>
        Task<T> AddAsync(T entity);

        /// <summary>
        /// Update entity in context and SAVE ALL CHANGES CONTEXT
        /// </summary>
        Task UpdateAsync(T entity);
                                                
        /// <summary>
        /// Add or Update entity in context and SAVE ALL CHANGES CONTEXT
        /// </summary>
        Task AddOrUpdateAsync(T entity);

        /// <summary>
        /// Remove entity in context and SAVE ALL CHANGES CONTEXT
        /// </summary>
        Task RemoveAsync(T entity);
                            
        /// <summary>
        /// Save all changes context, it's NOT NECESSARY to call this method, if you call AddAsync, AddRangeAsync, UpdateAsync, UpdateangeAsync, RemoveAsync or RemoveRangeAsync 
        /// </summary>
        Task SaveContextAsync();
    }
}
