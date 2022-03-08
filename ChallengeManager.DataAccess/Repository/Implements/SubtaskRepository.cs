using ChallengeManager.Data.BaseModels;
using ChallengeManager.DataAccess.Repository.Contracts;
using ChallengeManager.DataAccess.Sessions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallengeManager.DataAccess.Repository.Implements
{
    public class SubtaskRepository : ISubtaskRepository
    {
        public async Task<int> AddSubtask(ISession session, Subtask subtask)
        {
            var parametrs = new
            {
                name = subtask.Name,
                challengeId = subtask.ObjectiveId
            };

            var query = @"
INSERT INTO dbo.Subtasks
    (Name, ChallengeId)
VALUES
    (@name, @challengeId)
";

            return await session.ExecuteAsync(query, parametrs);
        }

        public async Task<IEnumerable<Subtask>> GetSubtasksByObjectiveIdAsync(ISession session, int objectiveId)
        {
            var parametrs = new
            {
                challengeID = objectiveId
            };

            string query = @"
SELECT * FROM dbo.Subtasks
WHERE ChallengeId = @challengeID
";
            return await session.QueryAsync<Subtask>(query, parametrs);
        }
    }
}