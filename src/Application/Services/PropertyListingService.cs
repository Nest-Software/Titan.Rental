using Application.Interfaces;
using Core.Models;
using Core.Pagination;
using Core.Property;

namespace Application.Services
{
    public class PropertyListingService : IPropertyListingService
    {
        public PropertyListingService() { }

        public async Task<long> CreatePropetyAsync(CreatePropertyModel model)
        {
            return await Task.FromResult(0);
        }

        public async Task UpdatePropertyModelAsync(long reference, UpdatePropertyModel model)
        {
        }

        public async Task ListPropertyAsync(long reference)
        {
        }

        public async Task RemovePropertyAsync(long reference)
        {
        }

        public async Task<PropertyModel> GetPropertyAsync(long reference)
        {
            return null;
        }

        public async Task<PageResult<IEnumerable<PropertyModel>>> GetPagedProperty(
            long query, int pageNumber, int pageSize)
        {
            return null;
        }        
    }
}
