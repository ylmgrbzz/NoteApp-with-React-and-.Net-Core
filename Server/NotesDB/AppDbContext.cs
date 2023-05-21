using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesDB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
        protected override void OnConfiguring(
                       DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2Q3K0QO\SQLEXPRESS;Database=Note;Trusted_Connection=True;");
        }
    }
}
