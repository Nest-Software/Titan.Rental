using Application.Interfaces;
using Core.Models;
using Core.Property;

namespace Application.Services
{
    public class PropertySaleService : IPropertySaleService
    {
        public PropertySaleService() { }

        public async Task AddPropertySaleAsync(long reference, AddOrUpdatePropertySaleModel model)
        {
        }

        public async Task UpdatePropertySaleAsync(int saleId, AddOrUpdatePropertySaleModel model)
        {
        }

        public async Task RemovePropertySaleAsync(int saleId)
        {
        }

        public async Task<PropertySaleModel> GetPropertySaleAsync(long saleId)
        {
            return null;
        }

        public async Task<IEnumerable<PropertyTenureTypeModel>> GetPropertyTenuresAsync()
        {
            return null;
        }
    }
}
