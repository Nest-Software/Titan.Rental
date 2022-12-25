using Application.Interfaces.Repositories;
using Arch.EntityFrameworkCore.UnitOfWork;
using Data.Context;
using Data.Entities;

namespace Application.Services.Repositories;

public class PropertySaleRepositoryAsync : GenericRepositoryAsync<PropertySale>, IPropertySaleRepositoryAsync
{
    public PropertySaleRepositoryAsync(RentalContext dbContext, IRepository<PropertySale> repository) : base(dbContext, repository)
    {
    }
}