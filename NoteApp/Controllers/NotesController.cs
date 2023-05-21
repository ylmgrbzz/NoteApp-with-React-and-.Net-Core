using Microsoft.AspNetCore.Mvc;
using NotesCore;
using NotesDB;

namespace NoteApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly ILogger<NotesController> _logger;
        private INoteServices _noteServices;

        public NotesController(ILogger<NotesController> logger, INoteServices noteServices)
        {
            _logger = logger;
            _noteServices = noteServices;
        }

        [HttpPost]
        public IActionResult CreateNote(Note note)
        {
            return Ok(_noteServices.CreateNote(note));
        }
    }
}