using Microsoft.AspNetCore.Mvc;
using TestMetaSoftplan.Domain;

namespace TestMetaSoftplan.API02.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return new GitHub().ReturnGitHubRepository();
        }
    }
}
