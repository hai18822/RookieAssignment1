using ApiAssignment1.Models;
using ApiAssignment1.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiAssignment1.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    private readonly ILogger<TasksController> _logger;
    private readonly ITaskService _taskService;

    public TasksController(ILogger<TasksController> logger, ITaskService taskService)
    {
        _logger = logger;
        _taskService = taskService;
    }

    [HttpGet("")]
    public IEnumerable<TaskModel> GetAll()
    {
        var data = _taskService.GetAll();
        return from item in data
               select new TaskModel
               {
                   Id = item.Id,
                   Title = item.Title,
                   IsCompleted = item.IsCompleted
               };
    }

    [HttpGet("{index:int}")]
    public TaskModel GetOne(int index)
    {
        var data = _taskService.GetOne(index);
        if (data == null) return null;

        return new TaskModel
        {
            Id = data.Id,
            Title = data.Title,
            IsCompleted = data.IsCompleted
        };
    }

    [HttpPost]
    public IActionResult Create(TaskCreateModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        try
        {
            var task = new TaskModel
            {
                Id = model.Id,
                Title = model.Title,
                IsCompleted = model.IsCompleted
            };
            var result = _taskService.Create(task);

            return StatusCode(StatusCodes.Status201Created, result);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex);
        }
    }

    [HttpPut("{index:int}")]
    public IActionResult Update(int index, TaskUpdateModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        try
        {
            var data = _taskService.GetOne(index);
            if (data == null)
            {
                return NotFound();
            }
            data.Title = model.Title;
            data.IsCompleted = model.IsCompleted;

            var result = _taskService.Update(index, data);

            return new JsonResult(result);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex);
        }
    }

    [HttpDelete("{index:int}")]
    public IActionResult Delete(int index)
    {
        try
        {
            var data = _taskService.GetOne(index);
            if (data == null)
            {
                return NotFound();
            }

            var result = _taskService.Delete(index);

            return new JsonResult(result);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex);
        }
    }
}
