using ChallangeManager.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallangeManager.Controllers
{
    [Route("challange")]
    [ApiController]
    public class ChallangeController : ControllerBase
    {
        [HttpGet]
        [Route("getAll")]
        public IEnumerable<Challange> GetChallanges()
        {
            return Enumerable.Empty<Challange>();
        }
    }
}
