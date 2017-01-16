namespace WebApi.Models
{
    public class TaskDto
    {
        public int TaskId { get; set; }
        public string Flux { get; set; }
        public string Document { get; set; }
        public AnswerDto Answer { get; set; }
    }
}