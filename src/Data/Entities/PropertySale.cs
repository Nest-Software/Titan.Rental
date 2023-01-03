using System.ComponentModel.DataAnnotations;
using Data.Models;

namespace Data.Entities;

public class PropertySale : BaseEntity
{
    public int PropertySaleId { get; set; }
    public decimal Amount { get; set; }    
    public int PropertyId { get; set; }
    public Property Property { get; set; }
    public int PropertyTenureTypeId { get; set; }
    public PropertyTenureType PropertyTenureType { get; set; }
}