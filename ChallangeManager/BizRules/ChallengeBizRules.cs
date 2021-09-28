using ChallangeManager.DataAcces;
using ChallangeManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
