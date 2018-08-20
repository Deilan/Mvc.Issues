using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Mvc.Issues.N8292.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(GetQuery query)
        {
            return new[] { "value1", "value2" };
        }
    }

    public class GetQuery
    {
        [FromQuery]
        public string Filter { get; set; }
        [FromQuery]
        public string Sort { get; set; }
        [FromQuery]
        public string Page { get; set; }
        [FromQuery]
        public string PageSize { get; set; }
    }
}
