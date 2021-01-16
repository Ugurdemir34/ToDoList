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
    public class PartController : ControllerBase
    {
        private IPartService _partService;
        private readonly ILogger<WeatherForecastController> _logger;
        public PartController(ILogger<WeatherForecastController> logger, IPartService partService)
        {
            _logger = logger;
            _partService = partService;
        }
        [HttpGet]
        public IActionResult GetAllParts()
        {
            var model = _partService.GetAll();
            return Ok(model);
        }
        [HttpGet("{id}")]
        public IActionResult GetPartByProjectId(Guid id)
        {
            var model = _partService.GetPartByProjectId(id);
            return Ok(model);
        }
    }
}
