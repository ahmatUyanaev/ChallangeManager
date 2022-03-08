using ChallengeManager.BizRules.Contracts;
using ChallengeManager.Data.BaseModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallangeManager.Controllers
{
    [Route("objective")]
    [ApiController]
    public class ObjectiveController : ControllerBase
    {
        private readonly IObjectiveBizRules _objectiveBizRules;

        public ObjectiveController(IObjectiveBizRules objectiveBizRules)
        {
            _objectiveBizRules = objectiveBizRules;
        }

        [HttpGet]
        [Route("getAll")]
        public async  Task<IEnumerable<Objective>> GetChallanges()
        {
            return await _objectiveBizRules.GetAllObjectivesAsync();
        }

        [HttpPost]
        [Route("addObjective")]
        public async Task<int> AddChallange(Objective objective)
        {
            return await _objectiveBizRules.AddObjectiveAsync(objective);
        }
    }
}
