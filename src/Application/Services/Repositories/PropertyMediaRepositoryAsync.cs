using Application.Interfaces.Repositories;
using Arch.EntityFrameworkCore.UnitOfWork;
using Data.Context;
using Data.Entities;

namespace Application.Services.Repositories;

public class PropertyMediaRepositoryAsync : GenericRepositoryAsync<PropertyMedia>, IPropertyMediaRepositoryAsync
{
    public PropertyMediaRepositoryAsync(RentalContext dbContext, IRepository<PropertyMedia> repository) : base(dbContext, repository)
    {
    }
}