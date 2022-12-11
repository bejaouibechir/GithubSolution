using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Some staff here";
        }

        [HttpPost]
        public string Get(Personne p)
        {
            return "Some staff here";
        }
    }
}
