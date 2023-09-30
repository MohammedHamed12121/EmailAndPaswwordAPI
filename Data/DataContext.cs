using Microsoft.EntityFrameworkCore;
using VerifyEmailAndPassword1.Models;

namespace VerifyEmailAndPassword1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<User> Users { get; set; }
    }
}
