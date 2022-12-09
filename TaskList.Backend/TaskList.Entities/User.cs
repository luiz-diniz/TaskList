using System.ComponentModel.DataAnnotations.Schema;

namespace TaskList.Entities;

[Table("User")]
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}