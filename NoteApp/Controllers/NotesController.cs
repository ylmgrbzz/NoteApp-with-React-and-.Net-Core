using Microsoft.AspNetCore.Mvc;

namespace NoteApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly ILogger<NotesController> _logger;

        public NotesController(ILogger<NotesController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult CreateNote()
        {
            return Ok("ylm");
        }
    }
}