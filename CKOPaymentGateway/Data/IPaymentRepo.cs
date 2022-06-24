using System.Collections.Generic;
using CKOPaymentGateway.Models;

namespace CKOPaymentGateway.Data
{
    public interface IPaymentRepo
    {
        bool SaveChanges();
        void CreateTransactionDetails(TransactionDetails transactionDetails);
        TransactionDetails GetTransactionDetailByReference(string transactionReference);
        IEnumerable<TransactionDetails> GetAllTransactionDetails();
        

    }
}