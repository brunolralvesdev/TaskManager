

using TaskManager.Application.Entities.Enums;

namespace TaskManager.Communication.Request
{
    public class RequestTaskJson
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public EPriorityLevel Priority { get; set; }
        public DateTime DeadLine { get; set; }
        public EStatus Status { get; set; }
    }
}
