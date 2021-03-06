using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class ValueContext : DbContext
    {
        public ValueContext(DbContextOptions<ValueContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }
    }
}