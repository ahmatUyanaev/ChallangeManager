using ChallengeManager.BizRules.Contracts;
using ChallengeManager.Data.BaseModels;
using ChallengeManager.DataAccess.Repository.Contracts;
using ChallengeManager.DataAccess.Sessions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeManager.BizRules.Impements
{
    public class ObjectiveBizRules : IObjectiveBizRules
    {
        private IObjectiveRepository objectiveRepository;
        private ISessionFactory sessionFactory;
        private ISubtaskBizRules subtaskBizRules;

        public ObjectiveBizRules(IObjectiveRepository objectiveRepository,
            ISessionFactory sessionFactory,
            ISubtaskBizRules subtaskBizRules)
        {
            this.objectiveRepository = objectiveRepository;
            this.sessionFactory = sessionFactory;
            this.subtaskBizRules = subtaskBizRules;
        }

        public async Task<int> AddObjectiveAsync(Objective objective)
        {
            using (var session = sessionFactory.CreateSession())
            {
                return await objectiveRepository.AddObjectiveAsync(session, objective);
            }
        }

        public async Task<IEnumerable<Objective>> GetAllObjectivesAsync()
        {
            using (var session = sessionFactory.CreateSession())
            {
                var objectives = await objectiveRepository.GetAllObjectivesAsync(session);
                foreach (var objective in objectives)
                {
                    objective.Subtasks = await subtaskBizRules.GetSubtasksByObjectiveIdAsync(objective.Id);
                }
                return objectives;
            }
        }
    }
}