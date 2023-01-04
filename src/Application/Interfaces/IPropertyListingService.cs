using Core.Models;
using Core.Pagination;
using Core.Property;

namespace Application.Interfaces
{
    public interface IPropertyListingService
    {
        Task<long> CreatePropetyAsync(CreatePropertyModel createPropertyModel);
        Task<PageResult<IEnumerable<PropertyModel>>> GetPagedProperty(long query, int pageNumber, int pageSize);
        Task<PropertyModel> GetPropertyAsync(long reference);
        Task ListPropertyAsync(long reference);
        Task RemovePropertyAsync(long reference);
        Task UpdatePropertyModelAsync(long reference, UpdatePropertyModel updatePropertyModel);
    }
}
