using System.Collections.Generic;
using System.Threading.Tasks;

using ChallangeManager.DataAcces.Session;
using ChallangeManager.Model;

namespace ChallangeManager.DataAcces
{
    public class SubtaskRepository : ISubtaskRepository
    {
        public async Task<int> AddSubtask(ISession session, Subtask subtask)
        {
            var parametrs = new
            {
                name = subtask.Name,
                challengeId = subtask.ChallengeId
            };

            var query = @"
INSERT INTO dbo.Subtasks
    (Name, ChallengeId)
VALUES
    (@name, @challengeId)
";

            return await session.ExecuteAsync(query, parametrs);
        }

        public async Task<IEnumerable<Subtask>> GetSubtasksByChallengeIdAsync(ISession session, int challengeId)
        {
            var parametrs = new
            {
                challengeID = challengeId
            };

            string query = @"
SELECT * FROM dbo.Subtasks
WHERE ChallengeId = @challengeID
";
            return await session.QueryAsync<Subtask>(query, parametrs);
        }
    }
}
