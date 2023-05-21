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
            //return Ok(_noteServices.CreateNote(note));
            var newNote = _noteServices.CreateNote(note);
            return CreatedAtRoute("GetNotes", new { id = newNote.Id }, newNote);
        }

        [HttpGet("{id}", Name = "GetNotes")]
        public IActionResult GetNote(int id)
        {
            return Ok(_noteServices.GetNote(id));
        }

        [HttpGet]
        public IActionResult GetNotes()
        {
            return Ok(_noteServices.GetNotes());
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNotes(int id)
        {
            _noteServices.DeleteNotes(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateNotes(int id, Note note)
        {
            _noteServices.UpdateNotes(id, note);
            return Ok();
        }

    }
}