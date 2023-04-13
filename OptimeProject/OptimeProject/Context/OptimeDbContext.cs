using Microsoft.EntityFrameworkCore;
using OptimeProject.Models;
using System.Data.Common;

namespace OptimeProject.Context
{
    public class OptimeDbContext: DbContext
    {
        public OptimeDbContext(DbContextOptions<OptimeDbContext> options) :base(options)
        {

        }

        public DbSet<User> Users { get; set; } = null!;

    }
}
