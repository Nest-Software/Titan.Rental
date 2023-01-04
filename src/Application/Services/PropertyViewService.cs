using Application.Interfaces;
using Core.Models;
using Core.Pagination;
using Core.Property;

namespace Application.Services
{
    public class PropertyViewService : IPropertyViewService
    {
        public PropertyViewService() { }

        public async Task AddPropertyViewAsync(long reference, CreatePropertyViewModel model)
        {
        }

        public async Task<PageResult<IEnumerable<PropertyViewModel>>> GetPagePropertyViewAsync(
            long reference, int pageNumber, int pageSize)
        {
            return null;
        }

        public async Task<PropertyViewModel> GetPropertyViewAsync(int viewId)
        {
            return null;
        }

        public async Task RemovePropertyViewAsync(int viewId)
        {
        }
    }
}
