using NotesDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesCore
{
    public interface INoteServices
    {
        Note CreateNote(Note note);
        Note GetNote(int id);
        List<Note> GetNotes();
        void DeleteNotes(int id);
        void UpdateNotes(int id, Note note);
    }
}
