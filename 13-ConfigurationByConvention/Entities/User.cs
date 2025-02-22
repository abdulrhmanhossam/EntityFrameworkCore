namespace _13_ConfigurationByConvention.Entities;

public class User
{
    // primary key must [Id] or [class name + Id]
    // col name macth prop name [not case senstive]
    public int UserId { get; set; }
    public string Username { get; set; } = null!;
}
