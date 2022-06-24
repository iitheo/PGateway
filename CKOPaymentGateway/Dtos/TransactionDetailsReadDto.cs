using CKOPaymentGateway.Models;

namespace CKOPaymentGateway.Dtos
{
    public class TransactionDetailsReadDto
    {
        public int Id { get; set; }
        public string TransactionReference { get; set; }
        public string Status { get; set; }
        public CardDetails CardDetails { get; set; }
    }
}