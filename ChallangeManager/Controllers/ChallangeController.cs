using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

using ChallangeManager.BizRules;
using ChallangeManager.Model;

namespace ChallangeManager.Controllers
{
    [Route("challenge")]
    [ApiController]
    public class ChallengeController : ControllerBase
    {
        private IChallengeBizRules challengeBizRules;

        public ChallengeController(IChallengeBizRules challengeBizRules)
        {
            this.challengeBizRules = challengeBizRules;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IEnumerable<Challenge>> GetChallanges()
        {
            return await challengeBizRules.GetAllChallenges();
        }

        [HttpPost]
        [Route("addChalenge")]
        public async void AddChallange(Challenge challenge)
        {
            await challengeBizRules.AddChallengeAsync(challenge);
        }
    }
}
