using System.Collections.Generic;
using System.Threading.Tasks;

using ChallangeManager.DataAcces.Session;
using ChallangeManager.Model;

namespace ChallangeManager.DataAcces
{
    public class SubtaskRepository : ISubtaskRepository
    {
        public async Task<IEnumerable<Subtask>> GetSubtasksByChallengeIdAsync(ISession session, int challengeId)
        {
            string query = @"
SELECT * FROM dbo.Subtasks
WHERE ChallengeId = @challengeId
";
            return await session.QueryAsync<Subtask>(query, challengeId);
        }
    }
}
