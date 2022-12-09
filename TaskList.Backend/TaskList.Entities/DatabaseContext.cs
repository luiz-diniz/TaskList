using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace TaskList.Entities;
public class DatabaseContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DatabaseContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<User> Users { get; set; }
    public DbSet<TaskItem> Tasks { get; set; }
}