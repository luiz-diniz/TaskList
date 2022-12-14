using TaskList.Core;
using TaskList.Core.Interfaces;
using TaskList.Entities;
using TaskList.Repository.Interfaces;
using TaskList.Repository.SQLServer;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddLog4Net();
builder.Logging.AddLog4Net();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Core
builder.Services.AddTransient<ITaskManager, TaskManager>();
builder.Services.AddTransient<IUserManager, UserManager>();
builder.Services.AddSingleton<IUserPasswordManager, UserPasswordManager>();

//Repository
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddTransient<ITaskRepository, TaskRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();

app.UseHttpsRedirection();

app.UseCors(p =>
{
    p.AllowAnyHeader();
    p.AllowAnyMethod();
    p.AllowAnyOrigin();
});

app.UseAuthorization();

app.MapControllers();

app.Run();