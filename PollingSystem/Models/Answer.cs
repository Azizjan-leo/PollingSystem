
namespace PollingSystem.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public PollResult PollResult { get; set; }
        public Question Question { get; set; }
        public bool Value { get; set; }
    }
}
