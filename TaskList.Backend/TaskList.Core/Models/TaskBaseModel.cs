namespace TaskList.Core.Models;

public class TaskBaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool Done { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime FinishDate { get; set; }
}