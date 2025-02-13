using _08_InternalConfiguration.Data;

// call internaliy using parmaterless ctor
using var dbContext = new AppDbContext();

foreach (var wallet in dbContext.Wallets)
{
    Console.WriteLine(wallet);
}
