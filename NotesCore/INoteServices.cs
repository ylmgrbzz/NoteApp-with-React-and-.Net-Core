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
    }
}
