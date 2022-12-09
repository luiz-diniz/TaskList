using TaskList.Entities;
using TaskList.Repository.Interfaces;

namespace TaskList.Repository.SQLServer;

public class UserRepository : IUserRepository
{
    private readonly DatabaseContext _dbContext;

    public UserRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Create(User user)
    {
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
    }
}