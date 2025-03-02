
using Microsoft.EntityFrameworkCore;

namespace _12_ContextPooling.Data;
//  A DbContext instance represents a session with the database and can be used to
//  query and save instances of your entities. DbContext is a combination of the
//  Unit Of Work and Repository patterns.
public class AppDbContext : DbContext
{
    // represent the collection of all entities
    //public DbSet<Wallet> Wallets { get; set; }


    public AppDbContext(DbContextOptions options)
        :base(options)
    {
        
    }
}
