using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.Net.Http;
using TestMetaSoftplan.Domain;

namespace TestMetaSoftplan.API02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        [HttpGet("{initialvalue}/{months}")]
        public string Get(int initialValue, int months)
        {
            var fees = 0m;

            var httpreq = new HttpClient();
            var res = httpreq.GetAsync("https://localhost:44396/taxajuros");
            var response = res.Result;

            if (response.IsSuccessStatusCode)
                fees = Convert.ToDecimal(string.IsNullOrWhiteSpace(response.Content.ReadAsStringAsync().Result) ? "0" : response.Content.ReadAsStringAsync().Result, CultureInfo.GetCultureInfo("en-US"));

            return "Resultado: " + new Fees().ReturnCalcFees(initialValue, fees, months).ToString("N2");
        }
    }
}
