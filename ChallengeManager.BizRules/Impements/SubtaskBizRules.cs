using ChallengeManager.BizRules.Contracts;
using ChallengeManager.Data.BaseModels;
using ChallengeManager.DataAccess.Repository.Contracts;
using ChallengeManager.DataAccess.Sessions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeManager.BizRules.Impements
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

        public async Task<IEnumerable<Subtask>> GetSubtasksByObjectiveIdAsync(int objectiveId)
        {
            using (ISession session = sessionFactory.CreateSession())
            {
                return await subtaskRepository.GetSubtasksByObjectiveIdAsync(session, objectiveId);
            }
        }
    }
}