namespace Core.Models
{
    public class PropertyRentModel
    {
        public decimal Deposit { get; set; }
        public string LetType { get; set; }
        public int MinimumTenancy { get; set; }
        public DateTime AvailableDate { get; set; }
        public decimal Rent { get; set; }
    }
}
