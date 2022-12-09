namespace TaskList.Entities;

public class Task
{
    public int Id { get; set; }
    public int IdUser { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public bool Done { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime FinishDate { get; set; }
}