using ChallengeManager.Data.BaseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeManager.BizRules.Contracts
{
    public interface ISubtaskBizRules
    {
        Task<IEnumerable<Subtask>> GetSubtasksByObjectiveIdAsync(int challengeId);

        Task<int> AddSubtask(Subtask subtask);
    }
}