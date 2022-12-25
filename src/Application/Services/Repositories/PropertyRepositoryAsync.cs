using Application.Interfaces.Repositories;
using Arch.EntityFrameworkCore.UnitOfWork;
using Data.Context;
using Data.Entities;

namespace Application.Services.Repositories;

public class PropertyRepositoryAsync : GenericRepositoryAsync<Property>, IPropertyRepositoryAsync
{
    public PropertyRepositoryAsync(RentalContext dbContext, IRepository<Property> repository) : base(dbContext, repository)
    {
    }
}