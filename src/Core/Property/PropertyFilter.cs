using Core.Pagination;

namespace Core.Property;

public class PropertyFilter : PageRequest
{
    public long query { get; set; }
}