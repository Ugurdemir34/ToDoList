using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoList.Business.Abstract;

namespace ToDoList.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectService _projectService;
        private readonly ILogger<WeatherForecastController> _logger;
        public ProjectController(ILogger<WeatherForecastController> logger, IProjectService projectService)
        {
            _logger = logger;
            _projectService = projectService;
        }
        [HttpGet]
        public IActionResult GetAllProjects()
        {
            var model = _projectService.GetAll();
            return Ok(model);
        }
        [HttpGet("{id}")]
        public IActionResult GetProject(Guid id)
        {
            var model = _projectService.GetProject(id);
            return Ok(model);
        }
    }
}
