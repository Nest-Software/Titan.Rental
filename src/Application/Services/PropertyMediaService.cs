using Application.Interfaces;
using Core.Models;
using Core.Pagination;
using Core.Property;
using Data.Context;
using Data.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class PropertyMediaService : IPropertyMediaService
    {
        private readonly RentalContext _rentalContext;
        public PropertyMediaService(RentalContext rentalContext)
        {
            _rentalContext = rentalContext;
        }

        public async Task CreatePropetyMediaAsync(CreatePropertyMediaModel createPropertyModel)
        {

            var property =
                await _rentalContext.Properties.FirstOrDefaultAsync(c =>
                    c.PropertyId.Equals(createPropertyModel.PropertyId));
            var mediaType =
                await _rentalContext.MediaTypes.FirstOrDefaultAsync(i =>
                    i.MediaTypeId.Equals(createPropertyModel.MediaTypeId));
            if (property == null || mediaType == null)
            {
                throw new FileNotFoundException($"Property not found ");
            }

            var media = createPropertyModel.Adapt<PropertyMedia>();

            await _rentalContext.PropertyMedias.AddAsync(media);
            await _rentalContext.SaveChangesAsync();
        }        

        public async Task<PageResult<IEnumerable<PropertyMediaModel>>> GetPagePropertyMedia(
            int pageNumber, int pageSize)
        {
            return null;
        }

        public async Task RemovePropertMediaAsync(int mediaId)
        {
            var media = await _rentalContext.PropertyMedias.FirstOrDefaultAsync(v => v.PropertyMediaId.Equals(mediaId));
            if (media == null)
            {
                throw new FileNotFoundException($"Property not found ");
            }

            _rentalContext.PropertyMedias.Remove(media);
            await _rentalContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<MediaTypeModel>> GetMediaTypesAsync()
        {
            var mediaType = await _rentalContext.MediaTypes.AsQueryable().Select(
                m => m.Adapt<MediaTypeModel>()
            ).ToListAsync();

            return mediaType;
        }
    }
}
