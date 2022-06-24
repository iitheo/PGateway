using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CKOPaymentGateway.Models
{
    public class CardDetails
    {
        // [Key]
        // [Required]
        // public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(16)]
        public string CardNumber { get; set; }
        
        [Required]
        [MaxLength(3)]
        public string Cvv { get; set; }
        
        [Required]
        [MaxLength(4)]
        public string CardExpiry { get; set; }

        // public List<TransactionDetails> TransactionDetails { get; set; }
    }
}