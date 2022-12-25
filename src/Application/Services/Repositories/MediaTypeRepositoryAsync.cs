using Application.Interfaces.Repositories;
using Arch.EntityFrameworkCore.UnitOfWork;
using Data.Context;
using Data.Entities;

namespace Application.Services.Repositories;

public class MediaTypeRepositoryAsync : GenericRepositoryAsync<MediaType>, IMediaTypeRepositoryAsync
{
    public MediaTypeRepositoryAsync(RentalContext dbContext, IRepository<MediaType> repository) : base(dbContext, repository)
    {
    }
}