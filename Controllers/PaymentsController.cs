using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentMs.Repositorys;
using PaymentMs.Services;
using PaymentMs.Models;
using PaymentMs;

namespace PaymentMs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentServ _paymentserv;

        public PaymentsController(IPaymentServ paymentserv)
        {
            _paymentserv = paymentserv;
        }
       
        [HttpGet]
        public IActionResult PaymentStatus()
        {
            return Ok(_paymentserv.PaymentStat());
        }

        [Route("PaymentBalance")]
        [HttpGet]
        public IActionResult PaymentBalance()
        {
            return Ok(_paymentserv.PaymentBalance());
        }


    }

    
}
