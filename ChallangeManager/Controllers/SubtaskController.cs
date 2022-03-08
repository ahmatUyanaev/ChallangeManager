using ChallengeManager.BizRules.Contracts;
using ChallengeManager.Data.BaseModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ChallangeManager.Controllers
{
    [Route("subtask")]
    [ApiController]
    public class SubtaskController : ControllerBase
    {
        private ISubtaskBizRules _subtaskBizRules;

        public SubtaskController(ISubtaskBizRules subtaskBizRules)
        {
            this._subtaskBizRules = subtaskBizRules;
        }

        [HttpPost]
        [Route("addSubtask")]
        public async Task<int> AddSubtask(Subtask subtask)
        {
            return await _subtaskBizRules.AddSubtask(subtask);
        }
    }
}