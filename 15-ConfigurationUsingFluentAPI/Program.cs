using _15_ConfigurationUsingFluentAPI.Data;

using (var dbContext = new AppDbContext())
{
    Console.WriteLine("-------- Users -----------");
    Console.WriteLine();
    foreach (var user in dbContext.Users)
    {
        Console.WriteLine(user.Username);
    }
    Console.WriteLine();
    Console.WriteLine("-------- Tweets -----------");
    Console.WriteLine();
    foreach (var tweet in dbContext.Tweets)
    {
        Console.WriteLine(tweet.TweetText);
    }
    Console.WriteLine();
    Console.WriteLine("-------- Comments -----------");
    Console.WriteLine();
    foreach (var comment in dbContext.Comments)
    {
        Console.WriteLine(comment.CommentText);
    }
}
