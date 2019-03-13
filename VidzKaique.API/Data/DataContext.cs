using Microsoft.EntityFrameworkCore;
using VidzKaique.API.Models;

namespace VidzKaique.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Value> Values { get; set; }
    }
}