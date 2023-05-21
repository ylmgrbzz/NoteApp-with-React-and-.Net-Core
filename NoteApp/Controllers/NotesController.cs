using Microsoft.AspNetCore.Mvc;

namespace NoteApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<NotesController> _logger;

        public NotesController(ILogger<NotesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            return Ok("ylm");
        }
    }
}