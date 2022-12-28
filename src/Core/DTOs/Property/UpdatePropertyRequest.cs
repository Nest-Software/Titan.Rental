namespace Core.DTOs.Property;

public class UpdatePropertyRequest
{
    public string? Name { get; set; }
    public bool Listed { get; set; }
    public int Size { get; set; }
    public string Description { get; set; }
    public int? PropertyRentalId { get; set; }
    public int? PropertySaleId { get; set; }
    public int? PropertyLocationId { get; set; }
    public int? BusinessId { get; set; }
}