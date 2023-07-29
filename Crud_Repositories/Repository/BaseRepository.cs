﻿using Crud.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Crud_Repositories.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DataContext _dataContext;
        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Delete(int id)
        {
           var entity = await GetById(id);
            _dataContext.Set<T>().Remove(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dataContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dataContext.Set<T>().FindAsync(id);
        }

        public async Task Insert(T entity)
        {
            await _dataContext.Set<T>().AddAsync(entity);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _dataContext.Set<T>().Update(entity);
            await _dataContext.SaveChangesAsync();
        }
    }
}
