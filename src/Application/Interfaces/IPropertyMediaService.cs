using Core.Models;
using Core.Pagination;
using Core.Property;

namespace Application.Interfaces
{
    public interface IPropertyMediaService
    {
        Task CreatePropetyMediaAsync(CreatePropertyMediaModel createPropertyModel);
        Task<PageResult<IEnumerable<PropertyMediaModel>>> GetPagePropertyMedia(int pageNumber, int pageSize);
        Task RemovePropertMediaAsync(int mediaId);
    }
}
