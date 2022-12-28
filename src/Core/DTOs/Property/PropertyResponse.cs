namespace Core.DTOs.Property;

public class PropertyResponse
{
    public int PropertyId { get; set; }
    public string? Name { get; set; }
    public long Reference { get; set; }
    public DateTime AddedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool Listed { get; set; }
    public int Size { get; set; }
    public string Description { get; set; }
    public int? PropertyRentalId { get; set; }
    public int? PropertySaleId { get; set; }
    public int PropertyLocationId { get; set; }
    public int BusinessId { get; set; }
  

  
}