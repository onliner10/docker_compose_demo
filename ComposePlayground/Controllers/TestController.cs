using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nest;

namespace ComposePlayground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/Test
        [HttpGet]
        public async Task<object> Get()
        {
            var client = new ElasticClient(new Uri("http://elasticsearch:9200"));
            var pingResponse = await client.PingAsync();
            
            return new
            {
                pingResponse.IsValid,
                pingResponse.DebugInformation,
            };
        }
    }
}
