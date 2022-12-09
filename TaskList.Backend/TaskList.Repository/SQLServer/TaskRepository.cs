using TaskList.Entities;
using TaskList.Repository.Interfaces;

namespace TaskList.Repository.SQLServer;
public class TaskRepository : ITaskRepository
{
    private readonly DatabaseContext _dbContext;

    public TaskRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Create(TaskItem task)
    {
        _dbContext.Tasks.Add(task);
        _dbContext.SaveChanges();
    }
}