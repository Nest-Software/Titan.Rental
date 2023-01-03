using Data.Models;

namespace Data.Entities;

public class PropertyLocation : BaseEntity
{
    public int PropertyLocationId { get; set; }
    public string Address { get; set; }
    public string PostalCode { get; set; }
    public string Town { get; set; }
    public string Region { get; set; }
    public string Country { get; set; }
    public string Coordinates { get; set; }
    public Property Property { get; set; }
}