namespace Entities.Types
{
    public class Payment
    {
        public int PaymentType { get; set; }
        public string Code { get; set; }
        public string CreditCardTypeCode { get; set; }
        public int InstallmentCount { get; set; }
        public decimal Amount { get; set; }

    }
}