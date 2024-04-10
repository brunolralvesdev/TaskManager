using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Task.Create
{
    public class CreateTaskUseCase
    {
        public ResponseCreateTaskJson Execute(RequestTaskJson request)
        {
            return new ResponseCreateTaskJson() 
            {
             Id = Guid.NewGuid(),
             Name = request.Name 
            };
        }
    }
}
