using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StaterKit.Controllers
{
    [Route("api/sample")]
    public class SampleController : Controller
    {
        [HttpGet()]
        public IActionResult GetSample()
        {
            var result = Json(SampleDataStore.Sample.Name);
            result.StatusCode = 200;
            return Ok(result);
        }
    }
}