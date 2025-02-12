using RetrieveSingleItem;

var itemIdToRetrieve = 2;

// make using to disbose session 
using (var dbContext = new AppDbContext())
{
    var wallet  = dbContext.Wallets
        .FirstOrDefault(x => x.Id == itemIdToRetrieve);

    Console.WriteLine(wallet);
}