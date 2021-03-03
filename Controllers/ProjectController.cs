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

namespace ProjectManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : BaseController<Project, CoreProjectRepository>
    {
        public ProjectController(CoreProjectRepository repository) : base(repository)
        {

        }
    }
}
