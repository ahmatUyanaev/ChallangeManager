using System.Collections.Generic;
using System.Threading.Tasks;

using ChallangeManager.DataAcces.Session;
using ChallangeManager.Model;

namespace ChallangeManager.DataAcces
{
    public interface IChallengeRepository
    {
        public Task<int> AddChallengeAsync(ISession session, Challenge challenge);

        public Task<IEnumerable<Challenge>> GetAllChallengesAsync(ISession session);
    }
}
