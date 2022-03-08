using System;
using System.Collections.Generic;

namespace ChallengeManager.Data.BaseModels
{
    public class Objective
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime DeadLine { get; set; }

        public IEnumerable<Subtask> Subtasks { get; set; }
    }
}