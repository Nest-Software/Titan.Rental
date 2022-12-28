namespace Core.DTOs.Business;

public class CreateBusinessRequest
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Location { get; set; }
    public string PhoneNumber { get; set; }
    public string? TIN { get; set; }
    public string? Email { get; set; }
    public string? Website { get; set; }
    public string? PostCode { get; set; }
    public bool Active { get; set; } 
}