namespace RestAPIDDDModel.Application.DTOs
{
    public class DTOProduct
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Value { get; set; } = decimal.Zero;
    }
}