using Microsoft.EntityFrameworkCore;
using TraversalApiProject.DataAccessLayer.Entities;

namespace TraversalApiProject.DataAccessLayer.Context
{
    public class VisitorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-75IA2UT\\SQLEXPRESS; initial catalog=TraversalDbApi; integrated security=true;");
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}
