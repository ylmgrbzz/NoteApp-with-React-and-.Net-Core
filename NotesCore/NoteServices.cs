using NotesDB;

namespace NotesCore
{
    public class NoteServices : INoteServices
    {
        private AppDbContext _context;
        public NoteServices(AppDbContext context)
        {
            _context = context;
        }

        public Note CreateNote(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
            return note;
        }

    }
}