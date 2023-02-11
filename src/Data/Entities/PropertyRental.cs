using Data.Models;

namespace Data.Entities;

public class PropertyRental : BaseEntity
{
    public int PropertyRentalId { get; set; }
    public decimal Deposit { get; set; }
    public int MinimumTenancy { get; set; }
    public DateTime? AvailableDate { get; set; }
    public decimal Amount { get; set; }
    public int PropertyLetTypeId { get; set; }
    public PropertyLetType PropertyLetType { get; set; }
    public Property Property { get; set; }
    public int PropertyId { get; set; }
}