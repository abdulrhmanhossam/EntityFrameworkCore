using System.ComponentModel.DataAnnotations.Schema;
namespace _14_ConfigurationByDataAnnotations.Entities;

[Table("tblComments")]
public class Comment
{
    [Column("CommentId")]
    public int Id { get; set; }
    public int TweetId { get; set; }
    public int UserId { get; set; }
    public string CommentText { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
}
