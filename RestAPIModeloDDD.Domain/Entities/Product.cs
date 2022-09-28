namespace RestAPIModeloDDD.Domain.Entities
{
    public class Product : Base
    {
        public string Name { get; set; } = string.Empty;
        public decimal Value { get; set; } = decimal.Zero;
        public bool IsAvailable { get; set; } = true;
    }
}