namespace HealthInsuranceManagement.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public int ClientID { get; set; }
        public int ProviderID { get; set; }
        public int PlanID { get; set; }
        public DateTime ClaimDate { get; set; }
        public decimal AmountClaimed { get; set; }
        public string Status { get; set; }

        public Client Client { get; set; }
        public Provider Provider { get; set; }
        public InsurancePlan InsurancePlan { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
