using _09_ExternalConfiguration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

class Program
{
    static void Main(string[] args)
    {
        // build config file
        
        IConfigurationRoot config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        string? connectionString = config
            .GetSection("ConnectionString").Value;

        // we cannot use this to create options its abstract
        // var optionsBuilder = new DbContextOptions();

        // use this to create options
        var optionsBuilder = new DbContextOptionsBuilder();

        // add provider to options 
        optionsBuilder.UseSqlServer(connectionString);

        // get options from optionBuilder
        var options = optionsBuilder.Options;


        using var dbContext = new AppDbContext(options);

        foreach (var wallet in dbContext.Wallets)
        {
            Console.WriteLine(wallet);
        }
    }
}

