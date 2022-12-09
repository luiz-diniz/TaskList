using TaskList.Core.Interfaces;
using static BCrypt.Net.BCrypt;

namespace TaskList.Core;

public class UserPasswordManager : IUserPasswordManager
{
    public string GeneratePasswordHash(string text)
    {
        return HashPassword(text);
    }

    public bool VerifyPasswordMatch(string inputText, string hashedText)
    {
        return Verify(inputText, hashedText);
    }
}