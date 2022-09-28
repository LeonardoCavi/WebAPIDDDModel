namespace RestAPIModeloDDD.Domain.Entities
{
    public class Client : Base
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}