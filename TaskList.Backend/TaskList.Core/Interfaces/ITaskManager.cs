using TaskList.Core.Models;
using TaskList.Entities;

namespace TaskList.Core.Interfaces;
public interface ITaskManager
{
    void Create(TaskItem task);
}