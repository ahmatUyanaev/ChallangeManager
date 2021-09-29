using System.Collections.Generic;
using System.Threading.Tasks;

using ChallangeManager.DataAcces;
using ChallangeManager.DataAcces.Session;
using ChallangeManager.Model;

namespace ChallangeManager.BizRules
{
    public class ChallengeBizRules : IChallengeBizRules
    {
        private IChallengeRepository challengeRepository;
        private ISessionFactory sessionFactory;

        public ChallengeBizRules(IChallengeRepository challengeRepository,
            ISessionFactory sessionFactory)
        {
            this.challengeRepository = challengeRepository;
            this.sessionFactory = sessionFactory;
        }

        public async Task<int> AddChallengeAsync(Challenge challenge)
        {
            using (var session = sessionFactory.CreateSession())
            {
                return await challengeRepository.AddChallengeAsync(session, challenge);
            }
        }

        public async Task<IEnumerable<Challenge>> GetAllChallenges()
        {
            using (var session = sessionFactory.CreateSession())
            {
                return await challengeRepository.GetAllChallenges(session);
            }
        }
    }
}
