namespace HealthInsuranceManagement.Models
{
    public class Provider
    {
        public int ProviderID { get; set; }
        public string ProviderName { get; set; }
        public string Specialty { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public ICollection<Claim> Claims { get; set; }
    }
}
