using CKOPaymentGateway.Models;
using Microsoft.EntityFrameworkCore;

namespace CKOPaymentGateway.Data
{
    public class PaymentContext : DbContext
    {
        public PaymentContext(DbContextOptions<PaymentContext> options) : base(options)
        {
            
        }
        
        // public DbSet<CardDetails> CardDetails { get; set; }
        public DbSet<TransactionDetails> TransactionDetails { get; set; }
        
    }
}