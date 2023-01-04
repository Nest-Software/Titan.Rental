using Application.Interfaces;
using Core.Models;
using Core.Property;

namespace Application.Services
{
    public class PropertyRentalService : IPropertyRentalService
    {
        public PropertyRentalService() { }

        public async Task AddPropertyRentalAsync(long reference, AddOrUpdatePropertyRentalModel model)
        {
        }

        public async Task UpdatePropertyRentalAsync(long rentalId, AddOrUpdatePropertyRentalModel model)
        {
        }

        public async Task RemovePropertyRentalAsync(int rentalId)
        {
        }

        public async Task<PropertyRentModel> GetPropertyRentalAsync(long rentalId)
        {
            return null;
        }

        public async Task<IEnumerable<PropertyLetTypeModel>> GetPropertyLetTypesAsync()
        {
            return null;
        }
    }
}
