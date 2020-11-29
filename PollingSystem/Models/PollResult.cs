using System;

namespace PollingSystem.Models
{
    public class PollResult
    {
        public int Id { get; set; }
        public ApplicationUser Answerer { get; set; }
        public Poll Poll { get; set; }
        public DateTime PassDate { get; set; }
    }
}
