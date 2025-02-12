using ImplementTransaction;

using (var dbContext = new AppDbContext())
{
    // start transaction to do some operation (must all success)
    using (var transaction = dbContext.Database.BeginTransaction())
    {
        // transfer $500 from wallet id:1 to id:2
        var fromWallet = dbContext.Wallets
            .Single(x => x.Id == 1);
        
        var toWallet = dbContext.Wallets
            .Single(x => x.Id == 2);

        decimal amountToTransfer = 500m;

        // operation #01 withdraw 500 from wallet id = 1
        fromWallet.Balance -= amountToTransfer;
        dbContext.SaveChanges();

        // operation #02 add 500 from wallet id = 2
        toWallet.Balance += amountToTransfer;
        dbContext.SaveChanges();

        // commit to make transaction (success)
        transaction.Commit();
    }
}