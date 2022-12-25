using Data.Models;

namespace Data.Entities;

public class PropertyRental : BaseEntity
{
    public int PropertyRentalId { get; set; }
    public decimal Deposit { get; set; }
    public string LetType { get; set; }
    public int MinimumTenancy { get; set; }
    public DateTime AvailableDate { get; set; }
    public decimal Rent { get; set; }
    public int PropertyId { get; set; }
   
}