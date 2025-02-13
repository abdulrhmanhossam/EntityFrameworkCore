using _09_ExternalConfiguration.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace _09_ExternalConfiguration.Data;
//  A DbContext instance represents a session with the database and can be used to
//  query and save instances of your entities. DbContext is a combination of the
//  Unit Of Work and Repository patterns.
public class AppDbContext : DbContext
{
    // represent the collection of all entities
    public DbSet<Wallet> Wallets { get; set; }


    public AppDbContext(DbContextOptions options)
        :base(options)
    {
        
    }
}
