using Microsoft.AspNetCore.Mvc;
using TestMetaSoftplan.Domain;

namespace TestMetaSoftplan.API01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        [HttpGet]
        public decimal Get()
        {
            return new Fees().ReturnFees();
        }
    }
}
