using Microsoft.AspNetCore.Mvc;
using TaskList.Core.Interfaces;
using TaskList.Entities;

namespace TaskList.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    private readonly ITaskManager _taskManager;

    public TaskController(ITaskManager taskManager)
    {
        _taskManager = taskManager;
    }

    [HttpPost]
    [Route("create")]
    public IActionResult Create(TaskItem task)
    {
        try
        {
            _taskManager.Create(task);

            return Ok();
        }
        catch (Exception)
        {
            return Problem("Error while creating the task.");
        }
    }
}