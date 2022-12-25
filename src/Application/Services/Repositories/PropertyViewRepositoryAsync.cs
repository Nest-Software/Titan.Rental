using Application.Interfaces.Repositories;
using Arch.EntityFrameworkCore.UnitOfWork;
using Data.Context;
using Data.Entities;

namespace Application.Services.Repositories;

public class PropertyViewRepositoryAsync : GenericRepositoryAsync<PropertyView>, IPropertyViewRepositoryAsync
{
    public PropertyViewRepositoryAsync(RentalContext dbContext, IRepository<PropertyView> repository) : base(dbContext, repository)
    {
    }
}