using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentMs.Models;

namespace PaymentMs.Services
{
    public interface IPaymentServ
    {
      public ProcessResponse PaymentStat();

      public string PaymentBalance();



    }
}
