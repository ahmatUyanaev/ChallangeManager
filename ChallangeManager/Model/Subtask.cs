using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallangeManager.Model
{
    public class Subtask
    {
        public int Id { get; set; }

        public int ChallengeId { get; set; }

        public string Name { get; set; }

    }
}
