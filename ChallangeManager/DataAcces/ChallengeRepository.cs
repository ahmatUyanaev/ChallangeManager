using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

using ChallangeManager.Model;
using ChallangeManager.DataAcces.Session;

using Dapper;

namespace ChallangeManager.DataAcces
{
    public class ChallengeRepository : IChallengeRepository
    {
        public async Task<int> AddChallengeAsync(ISession session, Challenge challenge)
        {
           
            var parametrs = new {
                id = challenge.Id,
                name = challenge.Name,
                creationTime = challenge.CreationTime,
                deadLine = challenge.DeadLine };

            var query = @"
INSERT INTO Challenges
    (Id, Name, CreationTime, DeadLine)
VALUES
    (@id, @name, @creationTime, @deadLine)
";

                 return await session.ExecuteAsync(query, parametrs);
        }

        public async Task<IEnumerable<Challenge>> GetAllChallenges(ISession session)
        {
            var query = @"select * from Challenges";

            return await session.QueryAsync<Challenge>(query);
        }
    }
}
