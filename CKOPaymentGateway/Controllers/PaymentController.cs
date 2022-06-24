using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using CKOPaymentGateway.Data;
using CKOPaymentGateway.Dtos;
using CKOPaymentGateway.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CKOPaymentGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepo _repository;
        private readonly IMapper _mapper;

        public PaymentController(IPaymentRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TransactionDetailsReadDto>> GetAllTransactions()
        {
            var transactionReferences = _repository.GetAllTransactionDetails();
            if (transactionReferences == null)
            {
                return NotFound();
            }

            return Ok(transactionReferences.ToList());
        }
        
        [HttpGet("{transactionReference}", Name = "GetTransactionDetailsByReference")]
        public ActionResult<TransactionDetailsReadDto> GetTransactionDetailsByReference(string transactionReference)
        {
            var transactionDetail = _repository.GetTransactionDetailByReference(transactionReference);
            if (transactionDetail == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<TransactionDetailsReadDto>(transactionDetail));
        }
        
        [HttpPost]
        public ActionResult<TransactionDetailsReadDto> CreateTransactionDetails(TransactionDetailsCreateDto transactionDetailsCreateDto)
        {
            var transactionDetailsModel = _mapper.Map<TransactionDetails>(transactionDetailsCreateDto);
            _repository.CreateTransactionDetails(transactionDetailsModel);
            _repository.SaveChanges();

            var transactionDetailsReadDto = _mapper.Map<TransactionDetailsReadDto>(transactionDetailsModel);

            return CreatedAtRoute(nameof(GetTransactionDetailsByReference),
                new {TransactionReference = transactionDetailsReadDto.TransactionReference}, transactionDetailsReadDto);
        }
        
    }
}