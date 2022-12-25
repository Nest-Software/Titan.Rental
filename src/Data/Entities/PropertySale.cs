using System.ComponentModel.DataAnnotations;
using Data.Models;

namespace Data.Entities;

public class PropertySale : BaseEntity
{
    public int PropertySaleId { get; set; }
    public decimal Amount { get; set; }
    public int PropertyId { get; set; }
    
}