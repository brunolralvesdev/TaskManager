using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Task.Create;
using TaskManager.Application.UseCases.Task.DeleteTaskById;
using TaskManager.Application.UseCases.Task.GetAll;
using TaskManager.Application.UseCases.Task.GetTaskById;
using TaskManager.Application.UseCases.Task.UpdateTaskById;
using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseCreateTaskJson),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson),StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] RequestTaskJson request) 
        {
            var useCase = new CreateTaskUseCase();

            var response = useCase.Execute(request);

            return Ok(response);
        }


        [HttpGet]
        [ProducesResponseType(typeof(ResponseGetAllTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllTasksUseCase();

            var response = useCase.Execute();

            if(response.Tasks.Any())
                return Ok(response);

            return NoContent();
        }


        [HttpGet("{taskId}")]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson),StatusCodes.Status404NotFound)]
        public IActionResult GetTaskById([FromRoute]Guid taskId)
        {
            var useCase = new GetTaskByIdUseCase();
            var response = useCase.Execute(taskId);

            if(response is not null)
                return Ok(response);

            return NotFound();
        }



        [HttpPut("{taskId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult UpdateTaskById([FromRoute] Guid taskId, [FromBody] RequestTaskJson request)
        {
            var useCase = new UpdateTaskByIdUseCase();

            useCase.Execute(request);

            return NoContent();
        }


        [HttpDelete("{taskId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult DeleteTaskById([FromRoute] Guid taskId)
        {
            var useCase = new DeleteTaskByIdUseCase();

            useCase.Execute(taskId);

            return NoContent();
        }
    }
}
