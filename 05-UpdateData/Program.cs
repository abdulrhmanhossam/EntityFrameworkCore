using UpdateData;

// make using to disbose session 
using (var dbContext = new AppDbContext())
{
    Console.WriteLine("Before Update");
    foreach (var item in dbContext.Wallets)
    {
        Console.WriteLine(item);
    }

    // get recored we want update
    var wallet = dbContext.Wallets
        .SingleOrDefault(x => x.Id == 3);
    
    // update balance for wallet
    wallet!.Balance += 1000;

    // now save change
    dbContext.SaveChanges();

    Console.WriteLine("After Update");
    foreach (var item in dbContext.Wallets)
    {
        Console.WriteLine(item);
    }
}