namespace ApiAssignment1.Models
{
    public class TaskUpdateModel
    {
        public string Title { get; set; } = null!;
        public bool IsCompleted { get; set; }
    }
}