using CodeFirstASPCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CodeFirstASPCore.Models
{
    public class StudentDBContext:DbContext
    {

       /* public StudentDBContext(DbContextOptions options) : base(options)
        {

        }*/
        public DbSet<Student> students { get; set; }
    }
}

