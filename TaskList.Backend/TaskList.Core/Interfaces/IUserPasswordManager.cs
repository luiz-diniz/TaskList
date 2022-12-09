namespace TaskList.Core.Interfaces;

public interface IUserPasswordManager
{
    string GeneratePasswordHash(string text);

    bool VerifyPasswordMatch(string inputText, string hashedText);
}