using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentMs.Repositorys;
using PaymentMs.Models;

namespace PaymentMs.Services
{
    public class PaymentServ : IPaymentServ
    {
        private readonly IPaymentRepo _paymentrepo;

        public PaymentServ(IPaymentRepo paymentrepo)
        {
            _paymentrepo = paymentrepo;
        }

        public ProcessResponse PaymentStat()
        {
            return _paymentrepo.PaymentStat();
        }
        public string PaymentBalance()
        {
            return(_paymentrepo.PaymentBalance());
        }


    }
}
