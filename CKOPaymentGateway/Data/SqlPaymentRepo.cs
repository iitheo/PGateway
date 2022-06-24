using System.Collections.Generic;
using CKOPaymentGateway.Models;

namespace CKOPaymentGateway.Data
{
    public class SqlPaymentRepo : IPaymentRepo
    {
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void CreateTransactionDetails(TransactionDetails transactionDetails)
        {
            throw new System.NotImplementedException();
        }

        public TransactionDetails GetTransactionDetailByReference(string transactionReference)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TransactionDetails> GetAllTransactionDetails()
        {
            throw new System.NotImplementedException();
        }
    }
}