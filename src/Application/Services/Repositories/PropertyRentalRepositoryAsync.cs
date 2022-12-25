using Application.Interfaces.Repositories;
using Arch.EntityFrameworkCore.UnitOfWork;
using Data.Context;
using Data.Entities;

namespace Application.Services.Repositories;

public class PropertyRentalRepositoryAsync : GenericRepositoryAsync<PropertyRental>, IPropertyRentalRepositoryAsync
{
    public PropertyRentalRepositoryAsync(RentalContext dbContext, IRepository<PropertyRental> repository) : base(dbContext, repository)
    {
    }
}