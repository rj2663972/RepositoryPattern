using RP.Domain.Core.Entities;
using RP.Domain.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RP.Domain.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        T GetSingleBySpec(ISpecification<T> spec);
        T GetFirstBySpec(ISpecification<T> spec);
        T GetFirstBySpecAsNoTracking(ISpecification<T> spec);

        List<T> GetList(ISpecification<T> spec);
        List<T> GetAll();
        int CountBySpec(ISpecification<T> spec);

        IQueryable<T> GetQueryableBySpec(ISpecification<T> spec);

        /// <summary>
        /// Add entity in context, you MUST CALL SaveContext after this, in order to persist entity in the database
        /// </summary>
        void AddNotSaveChanges(T entity);

        /// <summary>
        /// Update entity in context, you MUST CALL SaveContext after this, in order to persist entity in the database
        /// </summary>
        void UpdateNotSaveChanges(T entity);

        /// <summary>
        /// Remove entity in context, you MUST CALL SaveContext after this, in order to persist entity in the database
        /// </summary>
        void RemoveNotSaveChanges(T entity);

        /// <summary>
        /// Add entity in context and SAVE ALL CHANGES CONTEXT
        /// </summary>
        T Add(T entity);

        /// <summary>
        /// Update entity in context and SAVE ALL CHANGES CONTEXT
        /// </summary>
        void Update(T entity);

        /// <summary>
        /// Add or Update entity in context and SAVE ALL CHANGES CONTEXT
        /// </summary>
        void AddOrUpdate(T entity);

        /// <summary>
        /// Remove entity in context and SAVE ALL CHANGES CONTEXT
        /// </summary>
        void Remove(T entity);  

        /// <summary>
        /// Save all changes context, it's NOT NECESSARY to call this method, if you call Add, AddRange, Update, Updateange, Remove or RemoveRange
        /// </summary>
        void SaveContext();

    }
}
