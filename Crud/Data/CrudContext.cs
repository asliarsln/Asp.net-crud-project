using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Web.Data
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options)
            : base(options)
        {
        }

        // DbSet'lerinizi buraya ekleyin
        // public DbSet<Model> Models { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
