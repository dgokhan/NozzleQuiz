using NozzleQuiz.Domain.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NozzleQuiz.Application.Interfaces.Repository
{
    public interface IGenericAsyncRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid Id);
        Task<T> AddAsync(T entity);
    }
}
