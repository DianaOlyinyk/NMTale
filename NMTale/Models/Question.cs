using NMTale.enums;

namespace NMTale.Models
{
    public class Question
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public string Text { get; set; } = string.Empty;
        public List<string> Answers { get; set; } = new();
        public int CorrectIndex { get; set; }
    }

}
