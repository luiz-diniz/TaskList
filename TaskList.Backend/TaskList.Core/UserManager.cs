using TaskList.Core.Interfaces;
using TaskList.Entities;
using TaskList.Repository.Interfaces;

namespace TaskList.Core;

public class UserManager : IUserManager
{
    private readonly IUserRepository _userRepository;

    public UserManager(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void Create(User user)
    {
        try
        {
            
        }
        catch (Exception ex)
        {
            //log later
            throw;
        }
    }
}