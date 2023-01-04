using Core.Models;
using Core.Property;

namespace Application.Interfaces
{
    public interface IPropertyRentalService
    {
        Task AddPropertyRentalAsync(long reference, AddOrUpdatePropertyRentalModel model);
        Task<PropertyRentModel> GetPropertyRentalAsync(long rentalId);
        Task RemovePropertyRentalAsync(int rentalId);
        Task UpdatePropertyRentalAsync(long rentalId, AddOrUpdatePropertyRentalModel model);
    }
}
