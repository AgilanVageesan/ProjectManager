using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManager;
using ProjectManager.Data.Core;
using ProjectManager.Models;
using Task = ProjectManager.Models.Task;

namespace ProjectManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : BaseController<Task, CoreTaskRepository>
    {
        public TaskController(CoreTaskRepository repository) : base(repository)
        {

        }
    }
}