using System.Collections.Generic;
using System.Threading.Tasks;

using ChallangeManager.Model;

namespace ChallangeManager.BizRules
{
    public interface IChallengeBizRules
    {
        public Task<int> AddChallengeAsync(Challenge challenge);

        public Task<IEnumerable<Challenge>> GetAllChallenges();
    }
}
