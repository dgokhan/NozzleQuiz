using Microsoft.EntityFrameworkCore;
using NozzleQuiz.Application.Interfaces.Repository;
using NozzleQuiz.Domain.Common;
using NozzleQuiz.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NozzleQuiz.Persistence.Repository
{
    public class GenericRepository<T> : IGenericAsyncRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext dbContext;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            await dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid Id)
        {
            return await dbContext.Set<T>().FindAsync(Id);
        }
    }
}
