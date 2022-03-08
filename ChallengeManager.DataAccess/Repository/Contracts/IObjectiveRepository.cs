using ChallengeManager.Data.BaseModels;
using ChallengeManager.DataAccess.Sessions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeManager.DataAccess.Repository.Contracts
{
    public interface IObjectiveRepository
    {
        public Task<int> AddObjectiveAsync(ISession session, Objective objective);

        public Task<IEnumerable<Objective>> GetAllObjectivesAsync(ISession session);
    }
}