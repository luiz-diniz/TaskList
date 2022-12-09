using TaskList.Core.Models;

namespace TaskList.Core.Interfaces;
public interface ITaskManager
{
    void Create(TaskItemCreateModel task);
}