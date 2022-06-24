using System.ComponentModel.DataAnnotations;
using CKOPaymentGateway.Models;

namespace CKOPaymentGateway.Dtos
{
    public class TransactionDetailsCreateDto
    {
        [Required]
        public string TransactionReference { get; set; }

        public string Status { get; set; }

        public CardDetails CardDetails { get; set; }
    }
}