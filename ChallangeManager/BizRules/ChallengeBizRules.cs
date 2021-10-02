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
        private ISubtaskBizRules subtaskBizRules;

        public ChallengeBizRules(IChallengeRepository challengeRepository,
            ISessionFactory sessionFactory,
            ISubtaskBizRules subtaskBizRules)
        {
            this.challengeRepository = challengeRepository;
            this.sessionFactory = sessionFactory;
            this.subtaskBizRules = subtaskBizRules;
        }

        public async Task<int> AddChallengeAsync(Challenge challenge)
        {
            using (var session = sessionFactory.CreateSession())
            {
                return await challengeRepository.AddChallengeAsync(session, challenge);
            }
        }

        public async Task<IEnumerable<Challenge>> GetAllChallengesAsync()
        {
            using (var session = sessionFactory.CreateSession())
            {
                var challenges =  await challengeRepository.GetAllChallengesAsync(session);
                foreach (var challenge in challenges)
                {
                    challenge.Subtasks = await subtaskBizRules.GetSubtasksByChallengeIdAsync(challenge.Id);
                }
                return challenges;
            }
        }
    }
}
