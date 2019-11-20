using Microsoft.EntityFrameworkCore;
using RP.Data.DataContext;
using RP.Domain.Core.Entities;
using RP.Domain.Core.Interfaces;
using RP.Domain.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.Data.Repositories
{
    public class Repository<T> : IRepository<T>,IAsyncRepository<T> where T : BaseEntity
    {
        protected SampleDataContext _dbContext { get; set; }

        public Repository(SampleDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().SingleOrDefault(m => m.Id == id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().SingleOrDefaultAsync(m => m.Id == id);
        }

        public T GetSingleBySpec(ISpecification<T> spec)
        {
            return GetQueryableBySpec(spec).SingleOrDefault();
        }

        public async Task<T> GetSingleBySpecAsync(ISpecification<T> spec)
        {
            return await GetQueryableBySpec(spec).SingleOrDefaultAsync();
        }

        public T GetFirstBySpec(ISpecification<T> spec)
        {
            return GetQueryableBySpec(spec).FirstOrDefault();
        }

        public async Task<T> GetFirstBySpecAsync(ISpecification<T> spec)
        {
            return await GetQueryableBySpec(spec).FirstOrDefaultAsync();
        }

        public T GetFirstBySpecAsNoTracking(ISpecification<T> spec)
        {
            return GetQueryableBySpec(spec).AsNoTracking().FirstOrDefault();
        }

        public async Task<T> GetFirstBySpecAsyncAsNoTracking(ISpecification<T> spec)
        {
            return await GetQueryableBySpec(spec).AsNoTracking().FirstOrDefaultAsync();
        }

        public List<T> GetList(ISpecification<T> spec)
        {
            var queryableResult = GetQueryableBySpec(spec);

            // return the result of the query using the specification's criteria expression
            return queryableResult.ToList();
        }

        public async Task<List<T>> GetListAsync(ISpecification<T> spec)
        {
            var queryableResult = GetQueryableBySpec(spec);

            // return the result of the query using the specification's criteria expression
            return await queryableResult.ToListAsync();
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public int CountBySpec(ISpecification<T> spec)
        {
            return _dbContext.Set<T>().AsQueryable().Where(spec.Criteria).Count();
        }

        public async Task<int> CountBySpecAsync(ISpecification<T> spec)
        {
            return await _dbContext.Set<T>().AsQueryable().Where(spec.Criteria).CountAsync();
        }

        public IQueryable<T> GetQueryableBySpec(ISpecification<T> spec)
        {
            var queryableResult = spec.Includes.Aggregate(_dbContext.Set<T>().AsQueryable(),
                (current, include) => current.Include(include));

            queryableResult = spec.IncludeStrings.Aggregate(queryableResult, (current, include) => current.Include(include));

            queryableResult = queryableResult.Where(spec.Criteria);
            return queryableResult;
        } 

        public void AddNotSaveChanges(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public async Task AddNotSaveChangesAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }

        public void UpdateNotSaveChanges(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }

        public void RemoveNotSaveChanges(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public T Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                _dbContext.Set<T>().Update(entity);
                await _dbContext.SaveChangesAsync();

            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        public void AddOrUpdate(T entity)
        {
            if (entity.isTransient())
                Add(entity);
            else
                Update(entity);
        }

        public async Task AddOrUpdateAsync(T entity)
        {
            if (entity.isTransient())
                await AddAsync(entity);
            else
                await UpdateAsync(entity);
        }

        public void Remove(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public async Task RemoveAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void SaveContext() => _dbContext.SaveChanges();
        public async Task SaveContextAsync() => await _dbContext.SaveChangesAsync();


    }

}
