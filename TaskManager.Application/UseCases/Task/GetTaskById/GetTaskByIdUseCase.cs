using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Task.GetTaskById
{
    public class GetTaskByIdUseCase
    {
        public ResponseTaskJson Execute(Guid id)
        {
            return new ResponseTaskJson();
        }
    }
}
