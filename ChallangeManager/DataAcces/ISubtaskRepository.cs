using System.Collections.Generic;
using System.Threading.Tasks;

using ChallangeManager.DataAcces.Session;
using ChallangeManager.Model;

namespace ChallangeManager.DataAcces
{
    public interface ISubtaskRepository
    {
        Task<IEnumerable<Subtask>> GetSubtasksByChallengeIdAsync(ISession session, int challengeId);
        Task<int> AddSubtask(ISession session, Subtask subtask);
    }
}
