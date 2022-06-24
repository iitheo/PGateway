using AutoMapper;
using CKOPaymentGateway.Dtos;
using CKOPaymentGateway.Models;

namespace CKOPaymentGateway.Profiles
{
    public class TransactionDetailsProfile : Profile
    {
        public TransactionDetailsProfile()
        {
            CreateMap<TransactionDetails,TransactionDetailsReadDto>();
            CreateMap<TransactionDetailsCreateDto, TransactionDetails>();
        }
    }
}