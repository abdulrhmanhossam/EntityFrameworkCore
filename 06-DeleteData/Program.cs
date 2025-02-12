using DeleteData;

// make using to disbose session 
using (var dbContext = new AppDbContext())
{
    Console.WriteLine("Before Delete");
    foreach (var item in dbContext.Wallets)
    {
        Console.WriteLine(item);
    }

    // get recored we want delete
    var wallet = dbContext.Wallets
        .SingleOrDefault(x => x.Id == 3);
    
    // Delete  wallet
    dbContext.Wallets.Remove(wallet!);

    // now save change
    dbContext.SaveChanges();

    Console.WriteLine("After Delete");
    foreach (var item in dbContext.Wallets)
    {
        Console.WriteLine(item);
    }
}