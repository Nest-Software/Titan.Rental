using Application.Interfaces;
using Core.DTOs.Property;
using Core.Models;
using Core.ResponseExtensions;
using Data.Entities;
using Mapster;

namespace Application.Services;

public class PropertyService
{
    private readonly IGenericRepositoryAsync<Property> _genericRepositoryAsync;
    
    public PropertyService(IGenericRepositoryAsync<Property> genericRepositoryAsync)
    {
        _genericRepositoryAsync = genericRepositoryAsync;
    }

    public async Task<ApiResponse<PropertyResponse>> GetPropertyByIdAsync(int id)
    {
        var result = await _genericRepositoryAsync.GetByIdAsync(id);

        if (result == null)
        {
            return CommonResponses.ErrorResponse.NotFoundResponse<PropertyResponse>();
        }

        return CommonResponses.SuccessResponse.OkResponse<PropertyResponse>(result.Adapt<PropertyResponse>());
    }
    
  
}