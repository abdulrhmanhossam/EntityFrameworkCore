using _13_ConfigurationByConvention.Entities;
using Microsoft.EntityFrameworkCore;

namespace _13_ConfigurationByConvention.Data;
//  A DbContext instance represents a session with the database and can be used to
//  query and save instances of your entities. DbContext is a combination of the
//  Unit Of Work and Repository patterns.
public class AppDbContext : DbContext
{
    // represent the collection of all entities
    public DbSet<Comment> Comments { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Tweet> Tweets { get; set; }


    public AppDbContext(DbContextOptions options)
        :base(options)
    {
        
    }
}
