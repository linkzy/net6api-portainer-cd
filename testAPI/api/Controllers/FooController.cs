using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooController : ControllerBase
    {
        // GET: api/<FooController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "bar" };
        }
    }
}
