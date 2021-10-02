using ChallangeManager.BizRules;
using ChallangeManager.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallangeManager.Controllers
{
    [Route("subtask")]
    [ApiController]
    public class SubtaskController : ControllerBase
    {
        private ISubtaskBizRules subtaskBizRules;

        public SubtaskController(ISubtaskBizRules subtaskBizRules)
        {
            this.subtaskBizRules = subtaskBizRules;
        }
        
        [HttpPost]
        [Route("addSubtask")]
        public async Task<int> AddSubtask(Subtask subtask)
        {
            return await subtaskBizRules.AddSubtask(subtask);
        }
    }
}
