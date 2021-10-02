using ChallangeManager.DataAcces;
using ChallangeManager.DataAcces.Session;
using ChallangeManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallangeManager.BizRules
{
    public class SubtaskBizRules : ISubtaskBizRules
    {
        private ISubtaskRepository subtaskRepository;
        private ISessionFactory sessionFactory;
        public SubtaskBizRules(ISubtaskRepository subtaskRepository,
            ISessionFactory sessionFactory)
        {
            this.subtaskRepository = subtaskRepository;
            this.sessionFactory = sessionFactory;
        }

        public async Task<int> AddSubtask(Subtask subtask)
        {
            using (ISession session = sessionFactory.CreateSession())
            {
                return await subtaskRepository.AddSubtask(session, subtask);
            }
        }

        public async Task<IEnumerable<Subtask>> GetSubtasksByChallengeIdAsync(int challengeId)
        {
            using (ISession session = sessionFactory.CreateSession())
            {
                return await subtaskRepository.GetSubtasksByChallengeIdAsync(session, challengeId);
            }
        }
    }
}
