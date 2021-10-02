using ChallangeManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallangeManager.BizRules
{
    public interface ISubtaskBizRules
    {
        Task<IEnumerable<Subtask>> GetSubtasksByChallengeIdAsync(int challengeId);

        Task<int> AddSubtask(Subtask subtask);
    }
}
