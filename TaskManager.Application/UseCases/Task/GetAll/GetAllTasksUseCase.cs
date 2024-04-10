using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Task.GetAll
{
    public class GetAllTasksUseCase
    {
        public ResponseGetAllTaskJson Execute()
        {
            return new ResponseGetAllTaskJson();
        }
    }
}
