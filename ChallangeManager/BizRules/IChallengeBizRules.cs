using System.Collections.Generic;
using System.Threading.Tasks;

using ChallangeManager.Model;

namespace ChallangeManager.BizRules
{
    public interface IChallengeBizRules
    {
        public Task AddChallengeAsync(Challenge challenge);

        public Task<IEnumerable<Challenge>> GetAllChallenges();
    }
}
