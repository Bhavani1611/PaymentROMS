using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PaymentMs.Models;

namespace PaymentMs.Repositorys
{
    public class PaymentRepo : IPaymentRepo
    {

        public ProcessResponse PaymentStat()
        { 
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44384");
                //var stringData = JsonConvert.SerializeObject(req);
                //var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.GetAsync("/api/ComponentProcessing/PaymentsData").Result;
                var responseData = response.Content.ReadAsStringAsync().Result;
                ProcessResponse process = JsonConvert.DeserializeObject<ProcessResponse>(responseData);
                //ViewRequest ress = new ViewRequest(req,process);
                PaymentsDataHelper.responseObj = process;
                return(process);
            }

        }

        public string PaymentBalance()
        {

            double TotalCharge = PaymentsDataHelper.responseObj.TotalCharge;

            double Creditlimit = double.Parse(PaymentsDataHelper.responseObj.CreditLimits);

            double Rembal = Creditlimit - TotalCharge;

            return ("Remaining Balance = " + Rembal);
        }

    }
}
