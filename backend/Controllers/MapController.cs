using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MapController : ControllerBase
    {
        private const string url = "http://localhost:8080/devices";

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            using var client = new HttpClient();
            var result = await client.GetAsync(url);
            var content = result.Content.ReadAsStringAsync();
            return Ok(content);
        }
    }
}
