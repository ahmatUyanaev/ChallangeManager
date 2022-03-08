using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeManager.Data.BaseModels
{
    public class Subtask
    {
        public int Id { get; set; }

        public int ObjectiveId { get; set; }

        public string Name { get; set; }

    }
}
