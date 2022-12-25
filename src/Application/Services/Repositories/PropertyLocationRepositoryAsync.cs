using Application.Interfaces.Repositories;
using Arch.EntityFrameworkCore.UnitOfWork;
using Data.Context;
using Data.Entities;

namespace Application.Services.Repositories;

public class PropertyLocationRepositoryAsync : GenericRepositoryAsync<PropertyLocation>, IPropertyLocationRepositoryAsync
{
    public PropertyLocationRepositoryAsync(RentalContext dbContext, IRepository<PropertyLocation> repository) : base(dbContext, repository)
    {
    }
}