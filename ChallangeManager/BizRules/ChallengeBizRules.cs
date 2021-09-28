using System.Collections.Generic;
using System.Threading.Tasks;

using ChallangeManager.DataAcces;
using ChallangeManager.Model;

namespace ChallangeManager.BizRules
{
    public class ChallengeBizRules : IChallengeBizRules
    {
        private IChallengeRepository challengeRepository;

        public ChallengeBizRules(IChallengeRepository challengeRepository)
        {
            this.challengeRepository = challengeRepository;
        }

        public Task AddChallengeAsync(Challenge challenge)
        {
            return challengeRepository.AddChallengeAsync(challenge);
        }

        public async Task<IEnumerable<Challenge>> GetAllChallenges()
        {
            return await challengeRepository.GetAllChallenges();
        
        }
    }
}
