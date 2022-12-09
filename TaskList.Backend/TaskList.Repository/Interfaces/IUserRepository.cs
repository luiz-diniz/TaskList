using TaskList.Entities;

namespace TaskList.Repository.Interfaces;

public interface IUserRepository
{
    void Create(User user);
}