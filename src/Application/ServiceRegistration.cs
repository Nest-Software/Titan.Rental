using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public class ServiceRegistration
{
    public static void DependencyInjects(IServiceCollection services)
    {
        #region Respositories
        services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
        
        #endregion
    }
}