using System;
using System.Collections.Generic;
using CKOPaymentGateway.Models;
using Microsoft.EntityFrameworkCore;

namespace CKOPaymentGateway.Data
{
    public class MockPaymentRepo : IPaymentRepo
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
            return new TransactionDetails()
            {
                Id = 1,
                TransactionReference = "003da7fb-aced-4782-a1ff-d72a760422e1",
                Status = "00",
                CardDetails = new CardDetails()
                {
                    Cvv = "299",
                    Name = "Ben Stone",
                    CardExpiry = "08/22",
                    CardNumber = "5399832567320987"
                }
            };
        }

        public IEnumerable<TransactionDetails> GetAllTransactionDetails()
        {
            var transactionDetails = new List<TransactionDetails>()
            {
                new TransactionDetails()
                {
                    Id = 1,
                    TransactionReference = "003da7fb-aced-4782-a1ff-d72a760422e1",
                    Status = "00",
                    CardDetails = new CardDetails()
                    {
                        Cvv = "299",
                        Name = "Ben Stone",
                        CardExpiry = "08/22",
                        CardNumber = "5399832567320987"
                    }
                },
                new TransactionDetails()
                {
                    Id = 2,
                    TransactionReference = "0004b4ce-ff61-413e-904c-3e00d2751e94",
                    Status = "00",
                    CardDetails = new CardDetails()
                    {
                        Cvv = "342",
                        Name = "Nancy Drew",
                        CardExpiry = "12/22",
                        CardNumber = "5399831578650990"
                    }
                },
                new TransactionDetails()
                {
                    Id = 3,
                    TransactionReference = "00105d42-2eb0-48e4-808d-9ff9db0e0644",
                    Status = "00",
                    CardDetails = new CardDetails()
                    {
                        Cvv = "765",
                        Name = "Pamela White",
                        CardExpiry = "03/25",
                        CardNumber = "5399830943430911"
                    }
                },
            };
            return transactionDetails;
        }

        
    }
}