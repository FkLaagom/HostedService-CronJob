using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HostedService_CronJob.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get() => DataBase.DB;
    }
}
