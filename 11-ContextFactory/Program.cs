using _11_ContextFactory.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _11_ContextFactory;

class Program
{
    static void Main(string[] args)
    {
        // build config file
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        string? connectionString = config
            .GetSection("ConnectionString").Value;

        // create obj from ServiceCollection to use
        var services = new ServiceCollection();

        // register appdbcontext as service on Factory and send options 
        services.AddDbContextFactory<AppDbContext>(options =>
               options.UseSqlServer(connectionString));

        // return IOC contauiner
        IServiceProvider serviceProvider = services.BuildServiceProvider();

        // get context service from factory
        var contextFactory = serviceProvider
            .GetService<IDbContextFactory<AppDbContext>>();

        // use contextFactory to get appdbcontext without create obj 
        // loose coupling
        // her caller is responsible for disposing the context
        using (var dbContext = contextFactory!.CreateDbContext())
        {
            foreach (var wallet in dbContext!.Wallets)
            {
                Console.WriteLine(wallet);
            }
        }
    }
}
