using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

using ChallangeManager.Model;
using Dapper;

namespace ChallangeManager.DataAcces
{
    public class ChallengeRepository : IChallengeRepository
    {
        public Task AddChallengeAsync(Challenge challenge)
        {
            using (IDbConnection connection = new SqlConnection(@"Data Source=DESKTOP-29CFBJD\SQLEXPRESS;Initial Catalog=ChallengeDB;Integrated Security=True"))
            {
                var parametrs = new { name = challenge.Name, creationTime = challenge.CreationTime, deadLine = challenge.DeadLine };
                var query = @"
INSERT INTO Challenges
(Name, CreationTime, DeadLine)
VALUES(@name, @creationTime, @deadLine)
";
                return connection.QueryAsync(query, parametrs);
            }
        }

        public async Task<IEnumerable<Challenge>> GetAllChallenges()
        {
            using (IDbConnection connection = new SqlConnection(@"Data Source=DESKTOP-29CFBJD\SQLEXPRESS;Initial Catalog=ChallengeDB;Integrated Security=True"))
            {
                var query = @"select * from Challenges";

                return await connection.QueryAsync<Challenge>(query);
            }
        }
    }
}
