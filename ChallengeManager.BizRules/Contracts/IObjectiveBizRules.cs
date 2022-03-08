using ChallengeManager.Data.BaseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeManager.BizRules.Contracts
{
    public interface IObjectiveBizRules
    {
        public Task<int> AddObjectiveAsync(Objective objective);

        public Task<IEnumerable<Objective>> GetAllObjectivesAsync();
    }
}