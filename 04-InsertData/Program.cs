using InsertData;

// create new wallet obj to add 
Wallet Wallet = new Wallet
{
    Holder = "Salah",
    Balance = 1200m
};


// make using to disbose session 
using (var dbContext = new AppDbContext())
{
    // we her added on memory we must save change to go to database
    dbContext.Wallets.Add(Wallet);

    // now we save it on database
    dbContext.SaveChanges();

    foreach (var wallet in dbContext.Wallets)
    {
        Console.WriteLine(wallet);
    }
}