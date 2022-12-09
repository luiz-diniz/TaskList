using static BCrypt.Net.BCrypt;

namespace TaskList.Core;

internal class UserPasswordManager
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