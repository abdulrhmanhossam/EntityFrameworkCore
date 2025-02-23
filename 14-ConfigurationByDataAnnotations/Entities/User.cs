using System.ComponentModel.DataAnnotations.Schema;

namespace _14_ConfigurationByDataAnnotations.Entities;

[Table("tblUsers")]
public class User
{
    public int UserId { get; set; }
    public string Username { get; set; } = null!;
}
