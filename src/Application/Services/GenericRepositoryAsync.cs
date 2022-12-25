using System.Linq.Expressions;
using Application.Interfaces;
using Arch.EntityFrameworkCore.UnitOfWork;
using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
{
    private readonly RentalContext _dbContext;
    private readonly IRepository<T> _repository;
    public GenericRepositoryAsync(RentalContext dbContext, IRepository<T> repository)
    {
        _dbContext = dbContext;
        _repository = repository;
    }

    public virtual async Task<T?> GetByIdAsync(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<IPagedList<T>> GetPagedResponseAsync(int pageNumber, int pageSize,  Expression<Func<T, bool>>? predicate)
    {
        return await _repository.GetPagedListAsync(pageIndex: pageNumber, pageSize: pageSize,
            predicate: predicate);
    }


    public async Task<T> AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
       
        return entity;
    }

    public Task UpdateAsync(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        return Task.CompletedTask;
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
    public Task DeleteAsync(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
        return Task.CompletedTask;
    }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await _dbContext
            .Set<T>()
            .ToListAsync();
    }
}