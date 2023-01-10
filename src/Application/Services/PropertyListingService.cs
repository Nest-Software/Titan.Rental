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
    public class PropertyListingService : IPropertyListingService
    {
        private readonly RentalContext _rentalContext;
        public PropertyListingService(RentalContext rentalContext)
        {
            _rentalContext = rentalContext;
        }
        

        public async Task<long> CreatePropertyAsync(AddOrUpdatePropertyModel model)
        {

            var property = model.Adapt<Property>();
            var propertyLocation = model.PropertyLocation.Adapt<PropertyLocation>();
            var propertyFeatures = model.PropertyFeatures.Select(i => i.Adapt<PropertyFeature>()).ToList();

            await _rentalContext.Properties.AddAsync(property);
            propertyLocation.PropertyId = property.PropertyId;
            foreach (var pf in propertyFeatures)
            {
                pf.PropertyId = property.PropertyId;
            }
            await _rentalContext.PropertyFeatures.AddRangeAsync(propertyFeatures);
            await _rentalContext.PropertyLocations.AddAsync(propertyLocation);
           var result = await _rentalContext.SaveChangesAsync();

           return result;
        }

        public async Task UpdatePropertyModelAsync(long reference, AddOrUpdatePropertyModel model)
        {
            var proprty = await _rentalContext.Properties
                .Include( pl => pl.PropertyLocation)
                .Include(pf => pf.PropertyFeatures)
                .FirstOrDefaultAsync(p => p.Reference.Equals(reference));
            if (proprty == null)
            {
                throw new FileNotFoundException($"Property not found ");
            }
            
            //To Do work on Property Feature
            var updatedProperty = model.Adapt<AddOrUpdatePropertyModel, Property>(proprty);
            var updatedPropertyLocation = model.PropertyLocation.Adapt<PropertyLocationModel, PropertyLocation>(proprty.PropertyLocation);
            _rentalContext.Entry(updatedProperty).State = EntityState.Modified;
            _rentalContext.Entry(updatedPropertyLocation).State = EntityState.Modified;
           
            
        }

        public async Task ListPropertyAsync(long reference)
        {
        }

        public async Task RemovePropertyAsync(long reference)
        {
            var proprty = await _rentalContext.Properties
                .Include( pl => pl.PropertyLocation)
                .Include(pf => pf.PropertyFeatures)
                .Include(pr => pr.PropertyRental)
                .Include(ps => ps.PropertySale)
                .Include(ps => ps.PropertyMedias)
                .FirstOrDefaultAsync(p => p.Reference.Equals(reference));
            if (proprty == null)
            {
                throw new FileNotFoundException($"Property not found ");
            }

            _rentalContext.Properties.Remove(proprty);
            await _rentalContext.SaveChangesAsync();
        }

        public async Task<PropertyModel> GetPropertyAsync(long reference)
        {
            
            var proprty = await _rentalContext.Properties
                .Include( pl => pl.PropertyLocation)
                .Include(pf => pf.PropertyFeatures)
                .Include(pr => pr.PropertyRental)
                .Include(ps => ps.PropertySale)
                .Include(b => b.Business)
                .Include(ps => ps.PropertyMedias)
                .FirstOrDefaultAsync(p => p.Reference.Equals(reference));
           
            if (proprty == null)
            {
                return null;
            }

            var result = new PropertyModel
            {
                Id = proprty.Reference,
                ShortDescription = proprty.ShortDescription,
                Description = proprty.Description,
                PropertyRent = proprty.PropertyRental.Adapt<PropertyRentModel>(),
                PropertySale = proprty.PropertySale.Adapt<PropertySaleModel>(),
                Location = proprty.PropertyLocation.Adapt<PropertyLocationModel>(),
                Business = proprty.Business.Adapt<BusinessModel>(),
                PropertyFeatures = proprty.PropertyFeatures.Select( i => i.Adapt<PropertyFeatureModel>()).ToList(),
                PropertyMedias =  proprty.PropertyMedias.Select(i => i.Adapt<PropertyMediaModel>()).ToList()
            };
            return result;
        }

        public async Task<PageResult<IEnumerable<PropertyModel>>> GetPagedProperty(
            PropertyFilter query)
        {
           var properties =  _rentalContext.Properties.AsQueryable();
           var  data = await properties.Skip(query.PageNumber - 1)
               .Take(query.PageSize)
               .Select(x => new PropertyModel
               {
                   Id = x.Reference,
                   ShortDescription = x.ShortDescription,
                   Description = x.Description,
                   PropertyRent = x.PropertyRental.Adapt<PropertyRentModel>(),
                   PropertySale = x.PropertySale.Adapt<PropertySaleModel>(),
                   Location = x.PropertyLocation.Adapt<PropertyLocationModel>(),
                   Business = x.Business.Adapt<BusinessModel>(),
                   PropertyFeatures = x.PropertyFeatures.Select( i => i.Adapt<PropertyFeatureModel>()).ToList(),
                   PropertyMedias =  x.PropertyMedias.Select(i => i.Adapt<PropertyMediaModel>()).ToList()
               }).ToListAsync();

           var count = await properties.CountAsync();

           return new PageResult<IEnumerable<PropertyModel>>(data, query.PageNumber, query.PageSize,count);
        }
        
        public async Task<IEnumerable<FeatureTypeModel>> GetFeatureTypesAsync()
        {
            var featureType = await _rentalContext.FeatureTypes.ToListAsync();

            return featureType.Select(i => i.Adapt<FeatureTypeModel>());
        }
    }
}
