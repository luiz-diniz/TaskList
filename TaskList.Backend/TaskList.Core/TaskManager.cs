using TaskList.Core.Interfaces;
using TaskList.Entities;
using TaskList.Repository.Interfaces;

namespace TaskList.Core;

public class TaskManager : ITaskManager
{
    private readonly ITaskRepository _taskRepository;

    public TaskManager(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public void Create(TaskItem task)
    {
        try
        {
            task.CreationDate = DateTime.Now;
            task.FinishDate = new DateTime();

            _taskRepository.Create(task);
        }
        catch (Exception)
        {

            throw;
        }
    }
}