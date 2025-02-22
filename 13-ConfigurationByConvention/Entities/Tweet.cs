namespace _13_ConfigurationByConvention.Entities;

public class Tweet
{
    public int TweetId { get; set; }
    public int UserId { get; set; }
    public string TweetText { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
}
