using TaskList.Entities;

namespace TaskList.Core.Interfaces;

public interface IUserManager
{
    void Create(User user);
}