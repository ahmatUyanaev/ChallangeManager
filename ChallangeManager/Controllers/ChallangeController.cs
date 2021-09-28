using ChallangeManager.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallangeManager.Controllers
{
    [Route("challenge")]
    [ApiController]
    public class ChallengeController : ControllerBase
    {
        [HttpGet]
        [Route("getAll")]
        public IEnumerable<Challenge> GetChallanges()
        {
            return Enumerable.Empty<Challenge>();
        }


    }
}
