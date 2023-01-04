using Application.Interfaces;
using Core.Models;
using Core.Pagination;
using Core.Property;

namespace Application.Services
{
    public class PropertyMediaService : IPropertyMediaService
    {
        public PropertyMediaService() { }

        public async Task CreatePropetyMediaAsync(CreatePropertyMediaModel createPropertyModel)
        {
        }        

        public async Task<PageResult<IEnumerable<PropertyMediaModel>>> GetPagePropertyMedia(
            int pageNumber, int pageSize)
        {
            return null;
        }

        public async Task RemovePropertMediaAsync(int mediaId)
        {
        }

        public async Task<IEnumerable<MediaTypeModel>> GetMediaTypesAsync()
        {
            return null;
        }
    }
}
