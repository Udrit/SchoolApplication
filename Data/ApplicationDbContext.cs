using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentStorage.Models;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace StudentStorage.Data
{

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
            dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Student> Students { get; set; }


    }
}
