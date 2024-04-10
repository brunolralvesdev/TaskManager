using TaskManager.Application.Entities.Enums;

namespace TaskManager.Communication.Response
{
    public class ResponseGetAllTaskJson
    {
        public List<ResponseTaskJson> Tasks { get; set; } = [];
    }
}
