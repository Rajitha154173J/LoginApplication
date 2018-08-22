using application.Models;
using Microsoft.EntityFrameworkCore;

namespace application.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        :base (options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}