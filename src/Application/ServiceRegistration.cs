using Application.Interfaces;
using Application.Interfaces.Repositories;
using Application.Services;
using Application.Services.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public class ServiceRegistration
{
    public static void DependencyInjects(IServiceCollection services)
    {
        #region Respositories
        services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
        services.AddTransient<IFeatureTypeRepositoryAsync, FeatureTypeRepositoryAsync>();
        services.AddTransient<IMediaTypeRepositoryAsync, MediaTypeRepositoryAsync>();
        services.AddTransient<IPropertyFeatureRepositoryAsync, PropertyFeatureRepositoryAsync>();
        services.AddTransient<IPropertyLocationRepositoryAsync, PropertyLocationRepositoryAsync>();
        services.AddTransient<IPropertyMediaRepositoryAsync, PropertyMediaRepositoryAsync>();
        services.AddTransient<IPropertyRentalRepositoryAsync, PropertyRentalRepositoryAsync>();
        services.AddTransient<IPropertyRepositoryAsync, PropertyRepositoryAsync>();
        services.AddTransient<IPropertySaleRepositoryAsync, PropertySaleRepositoryAsync>();
        services.AddTransient<IPropertyViewRepositoryAsync, PropertyViewRepositoryAsync>();
        #endregion
    }
}