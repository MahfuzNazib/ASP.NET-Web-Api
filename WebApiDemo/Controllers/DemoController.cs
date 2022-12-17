using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DemoController : ControllerBase
    {

        // GET: api/Demo
        [HttpGet]
        public string GetInfo()
        {
            return "Hello Demo API";
        }

        // GET : api/Demo/5
        [HttpGet("{id}")]
        public string UserInfo()
        {
            return "User Info with Perameter";
        }
    }
}
