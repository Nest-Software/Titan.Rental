namespace Core.DTOs.Property;

public class PropertyResponse
{
    public int Id { get; set; }
    public long Reference { get; set; }
    public DateTime AddedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool Listed { get; set; }
    public int Size { get; set; }
    public string? Description { get; set; }
    public int ProperRentalId { get; set; }
    public int PropertySaleId { get; set; }
}