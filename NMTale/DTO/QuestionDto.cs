namespace NMTale.DTO
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public List<string> Answers { get; set; }
    }
}
