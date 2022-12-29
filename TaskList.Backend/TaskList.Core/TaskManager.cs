using Microsoft.Extensions.Logging;
using TaskList.Core.Interfaces;
using TaskList.Core.Models;
using TaskList.Entities;
using TaskList.Repository.Interfaces;

namespace TaskList.Core;

public class TaskManager : ITaskManager
{
    private readonly ILogger<TaskManager> _logger;
    private readonly ITaskRepository _taskRepository;

    public TaskManager(ILogger<TaskManager> logger, ITaskRepository taskRepository)
    {
        _logger = logger;
        _taskRepository = taskRepository;
    }

    public void Create(TaskItemCreateModel task)
    {
        try
        {
            if (task.IdUser <= 0)
                throw new ArgumentOutOfRangeException($"Invalid User Id [{task.IdUser}].");

            if (string.IsNullOrEmpty(task.Name))
                throw new ArgumentNullException(nameof(task.Name), "Invalid task name.");
            
            var taskEntity = new TaskItem
            {
                IdUser = task.IdUser,
                Name = task.Name,
                Description = task.Description,
                Done = false,
                CreationDate = DateTime.Now,
                FinishDate = null
            };

            _taskRepository.Create(taskEntity);

            _logger.LogInformation($"Task [{task.Name}] for user with Id [{task.IdUser}] created.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error while creating the task.");
            throw;
        }
    }
}