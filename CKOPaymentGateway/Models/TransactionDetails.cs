using System.ComponentModel.DataAnnotations;

namespace CKOPaymentGateway.Models
{
    public class TransactionDetails
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string TransactionReference { get; set; }

        public string Status { get; set; }

        // public int CardDetailsId { get; set; }
        public CardDetails CardDetails { get; set; }
    }
}