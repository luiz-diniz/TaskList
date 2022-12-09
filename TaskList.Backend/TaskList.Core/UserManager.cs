using TaskList.Core.Interfaces;
using TaskList.Entities;
using TaskList.Repository.Interfaces;

namespace TaskList.Core;

public class UserManager : IUserManager
{
    private readonly IUserRepository _userRepository;
    private readonly IUserPasswordManager _userPasswordManager;

    public UserManager(IUserRepository userRepository, IUserPasswordManager userPasswordManager)
    {
        _userRepository = userRepository;
        _userPasswordManager = userPasswordManager;
    }

    public void Create(User user)
    {
        try
        {
            user.Password = _userPasswordManager.GeneratePasswordHash(user.Password);

            _userRepository.Create(user);
        }
        catch (Exception ex)
        {
            //log later
            throw;
        }
    }
}