using TaskList.Entities;

namespace TaskList.Repository.Interfaces;

public interface ITaskRepository
{
    void Create(TaskItem task);
}