using Core.Models;

namespace Core.Property
{
    public class CreatePropertyModel
    {
        public string Description { get; set; }
        public List<PropertyFeatureModel> PropertyFeatures { get; set; } = new List<PropertyFeatureModel>();
    }
}
