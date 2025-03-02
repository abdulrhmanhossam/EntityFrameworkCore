using _12_ContextPooling.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// build config file
var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

string? connectionString = config
    .GetSection("ConnectionString").Value;

// create obj from ServiceCollection to use
var services = new ServiceCollection();

// register appdbcontext as service and send options 
// use context pool to change context state and reuse it after dispoise
services.AddDbContextPool<AppDbContext>(options =>
       options.UseSqlServer(connectionString));

// return IOC contauiner
IServiceProvider serviceProvider = services.BuildServiceProvider();

// use appdbcontext from serviceProvider without create obj 
// loose coupling
using (var dbContext = serviceProvider.GetService<AppDbContext>())
{
    //foreach (var wallet in dbContext!.Wallets)
    //{
    //    Console.WriteLine(wallet);
    //}
}


