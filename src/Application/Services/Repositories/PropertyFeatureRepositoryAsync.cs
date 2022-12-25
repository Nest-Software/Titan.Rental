using Application.Interfaces.Repositories;
using Arch.EntityFrameworkCore.UnitOfWork;
using Data.Context;
using Data.Entities;

namespace Application.Services.Repositories;

public class PropertyFeatureRepositoryAsync : GenericRepositoryAsync<PropertyFeature>, IPropertyFeatureRepositoryAsync
{
    public PropertyFeatureRepositoryAsync(RentalContext dbContext, IRepository<PropertyFeature> repository) : base(dbContext, repository)
    {
    }
}