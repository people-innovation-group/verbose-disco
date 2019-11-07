using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class Context : DbContext
    {
        public DbSet<Org> Orgs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=studentData.db");
    }

}