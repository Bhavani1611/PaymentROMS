using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentMs.Models;

namespace PaymentMs.Repositorys
{
    public interface IPaymentRepo
    {
        public ProcessResponse PaymentStat();

        public string PaymentBalance();


    }
}
