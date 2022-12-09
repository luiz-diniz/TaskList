namespace TaskList.Core.Models;

internal class TaskSqlModel : TaskBaseModel
{
    public int Id { get; set; }
    public int IdUser { get; set; }
}