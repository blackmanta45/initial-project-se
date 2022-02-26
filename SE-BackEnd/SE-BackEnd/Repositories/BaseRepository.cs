using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SE_BackEnd.Context;

namespace SE_BackEnd.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : class, new()
    {
        protected readonly FamilyContext DbContext;

        public Repository(FamilyContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public IQueryable<T> GetQuery(Expression<Func<T, bool>> expression) => this.DbContext.Set<T>().Where(expression);

        public T Add(T itemToAdd)
        {
            var entity = this.DbContext.Add(itemToAdd);
            this.DbContext.SaveChanges();
            return entity.Entity;
        }

        public async Task<T> AddAsync(T itemToAdd)
        {
            var entity = await this.DbContext.AddAsync(itemToAdd);
            await this.DbContext.SaveChangesAsync();
            return entity.Entity;
        }

        public T GetById(Guid id) =>
            this.DbContext.Set<T>()
                .Find(id);

        public async Task<T> GetByIdAsync(Guid id) =>
            await this.DbContext.Set<T>()
                .FindAsync(id);

        public T GetById(int id) =>
            this.DbContext.Set<T>()
                .Find(id);

        public async Task<T> GetByIdAsync(int id) =>
            await this.DbContext.Set<T>()
                .FindAsync(id);

        public T GetById(string id) =>
            this.DbContext.Set<T>()
                .Find(id);

        public async Task<T> GetByIdAsync(string id) =>
            await this.DbContext.Set<T>()
                .FindAsync(id);

        public bool Delete(T itemToDelete)
        {
            this.DbContext.Remove(itemToDelete);
            this.DbContext.SaveChanges();
            return true;
        }

        public async Task<bool> DeleteAsync(T itemToDelete)
        {
            this.DbContext.Remove(itemToDelete);
            await this.DbContext.SaveChangesAsync();
            return true;
        }

        public IEnumerable<T> GetAll() =>
            this.DbContext.Set<T>()
                .AsEnumerable();

        public int GetCount() => this.DbContext.Set<T>().Count();

        public T Update(T itemToUpdate)
        {
            var entity = this.DbContext.Update(itemToUpdate);
            this.DbContext.SaveChangesAsync();
            return entity.Entity;
        }

        public async Task<T> UpdateAsync(T itemToUpdate)
        {
            var entity = this.DbContext.Set<T>().Update(itemToUpdate);
            await this.SaveAsync();
            return entity.Entity;
        }

        public void Save() => this.DbContext.SaveChanges();

        public async Task SaveAsync() => await this.DbContext.SaveChangesAsync();

        public async Task<List<T>> GetAllAsync() =>
            await this.DbContext.Set<T>()
                .ToListAsync();

        public IQueryable<T> GetTable() => this.DbContext.Set<T>();
    }
}