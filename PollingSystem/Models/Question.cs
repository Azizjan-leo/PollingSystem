
namespace PollingSystem.Models
{
    public class Question
    {
        public int Id { get; set; }
        public Poll Poll { get; set; }
        public string Text { get; set; }
    }
}
