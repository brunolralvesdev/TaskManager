using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.Entities.Enums;

namespace TaskManager.Communication.Response
{
    public class ResponseTaskJson
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public EPriorityLevel Priority { get; set; }
        public EStatus Status { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
