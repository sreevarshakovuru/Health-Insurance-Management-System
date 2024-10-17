namespace HealthInsuranceManagement.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int ClaimID { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; }

        public Claim Claim { get; set; }
    }
}
