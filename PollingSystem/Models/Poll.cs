using System;
using System.Collections.Generic;

namespace PollingSystem.Models
{
    public class Poll
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ApplicationUser Author { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public List<Question> Questions { get; set; }
        public List<PollResult> Results { get; set; }
        public bool IsActive { get; set; }
    }
}
