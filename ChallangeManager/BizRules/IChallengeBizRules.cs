using ChallangeManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallangeManager.BizRules
{
    public interface IChallengeBizRules
    {
        public Task AddChallengeAsync(Challenge challenge);
    }
}
