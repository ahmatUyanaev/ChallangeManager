using ChallengeManager.Data.BaseModels;
using ChallengeManager.DataAccess.Repository.Contracts;
using ChallengeManager.DataAccess.Sessions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeManager.DataAccess.Repository.Implements
{
    public class ObjectiveRepository : IObjectiveRepository
    {
        public async Task<int> AddObjectiveAsync(ISession session, Objective objective)
        {
            var parametrs = new
            {
                id = objective.Id,
                name = objective.Name,
                creationTime = objective.CreationTime,
                deadLine = objective.DeadLine
            };

            var query = @"
INSERT INTO Challenges
    (Id, Name, CreationTime, DeadLine)
VALUES
    (@id, @name, @creationTime, @deadLine)
";

            return await session.ExecuteAsync(query, parametrs);
        }

        public async Task<IEnumerable<Objective>> GetAllObjectivesAsync(ISession session)
        {
            var query = @"select * from Challenges";

            return await session.QueryAsync<Objective>(query);
        }
    }
}