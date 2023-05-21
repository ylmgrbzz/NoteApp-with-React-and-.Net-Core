using System.ComponentModel.DataAnnotations;

namespace NotesDB
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
    }
}