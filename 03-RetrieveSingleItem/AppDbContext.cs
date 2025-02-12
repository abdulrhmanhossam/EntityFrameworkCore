using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace RetrieveSingleItem;

//  A DbContext instance represents a session with the database and can be used to
//  query and save instances of your entities. DbContext is a combination of the
//  Unit Of Work and Repository patterns.
public class AppDbContext : DbContext
{
    // represent the collection of all entities
    public DbSet<Wallet> Wallets { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // build config file
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        // get the value from constr
        var connectionString = configuration
            .GetSection("ConnectionString").Value;

        // use value from constr to open session with the database
        optionsBuilder.UseSqlServer(connectionString);
    }
}



