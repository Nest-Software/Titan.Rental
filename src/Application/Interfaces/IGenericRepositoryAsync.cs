using System.Linq.Expressions;
using Arch.EntityFrameworkCore.UnitOfWork.Collections;

namespace Application.Interfaces;

public interface IGenericRepositoryAsync<T> where T : class
{
    Task<T?> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<IPagedList<T>> GetPagedResponseAsync(int pageNumber, int pageSize, Expression<Func<T, bool>>? predicate );
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity); 
    Task SaveChangesAsync( );
    Task DeleteAsync(T entity);
}