using ChallangeManager.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChallangeManager.DataAcces
{
    public interface IChallengeRepository
    {
        public Task AddChallengeAsync(Challenge challenge);

        public Task<IEnumerable<Challenge>> GetAllChallenges();
    }
}
