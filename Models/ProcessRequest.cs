using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentMs.Models
{
    public class ProcessRequest
    { 
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string CreditCardNumber { get; set; }

        public string CreditLimit { get; set; }
        public string ComponentType { get; set; }
        public string ComponentName { get; set; }
        public int Quantity { get; set; }
        public bool IsPriorityRequest { get; set; }
    }
}
