using ChallengeManager.Data.BaseModels;
using ChallengeManager.DataAccess.Sessions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeManager.DataAccess.Repository.Contracts
{
    public interface ISubtaskRepository
    {
        Task<IEnumerable<Subtask>> GetSubtasksByObjectiveIdAsync(ISession session, int objectiveId);

        Task<int> AddSubtask(ISession session, Subtask subtask);
    }
}