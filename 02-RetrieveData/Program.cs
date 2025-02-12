using RetrieveData;

// make using to disbose session 

using (var dbContext = new AppDbContext())
{
    foreach (var wallet in dbContext.Wallets)
    {
        Console.WriteLine(wallet);
    }
}