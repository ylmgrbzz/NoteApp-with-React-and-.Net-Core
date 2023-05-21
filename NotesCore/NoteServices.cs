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
        public void DeleteNotes(int id)
        {
            var note = _context.Notes.First(n => n.Id == id);
            _context.Notes.Remove(note);
            _context.SaveChanges();

        }
        public Note GetNote(int id)
        {
            return _context.Notes.First(n => n.Id == id);
        }
        public List<Note> GetNotes()
        {
            return _context.Notes.ToList();
        }
        public void UpdateNotes(int id, Note note)
        {
            var noteToUpdate = _context.Notes.First(n => n.Id == id);
            noteToUpdate.Value = note.Value;
            _context.SaveChanges();
        }
    }
}