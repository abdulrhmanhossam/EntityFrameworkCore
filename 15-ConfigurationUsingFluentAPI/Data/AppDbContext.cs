using _15_ConfigurationUsingFluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace _15_ConfigurationUsingFluentAPI.Data;
//  A DbContext instance represents a session with the database and can be used to
//  query and save instances of your entities. DbContext is a combination of the
//  Unit Of Work and Repository patterns.
public class AppDbContext : DbContext
{
    // represent the collection of all entities
    public DbSet<Comment> Comments { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Tweet> Tweets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var conifg = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = conifg.GetSection("ConnectionString").Value;

        optionsBuilder.UseSqlServer(connectionString);
       
    }

    //     Override this method to further configure the model that was discovered by convention
    //     from the entity types exposed in Microsoft.EntityFrameworkCore.DbSet`1 properties
    //     on your derived context. The resulting model may be cached and re-used for subsequent
    //     instances of your derived context.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Inside OnModel
        //modelBuilder.Entity<User>()
        //    .ToTable("tblUsers");

        //modelBuilder.Entity<Tweet>()
        //    .ToTable("tblTweets");

        //modelBuilder.Entity<Comment>()
        //    .ToTable("tblComments");

        //modelBuilder.Entity<Comment>()
        //    .Property(p => p.Id)
        //    .HasColumnName("CommentId"); 
        #endregion

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly
            .GetExecutingAssembly());
    }
}
