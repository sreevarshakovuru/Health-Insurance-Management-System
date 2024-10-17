namespace HealthInsuranceManagement.Models
{
    public class InsurancePlan
    {
        public int PlanID { get; set; }
        public string PlanName { get; set; }
        public string CoverageType { get; set; }
        public decimal PremiumAmount { get; set; }
        public decimal CoverageAmount { get; set; }

        public ICollection<Claim> Claims { get; set; }
    }
}
