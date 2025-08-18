namespace API.Entities;

// class represents a table in the DB
public class AppUser
{
    // each property represents a column in the DB
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string DisplayName { get; set; }
    public required string Email { get; set; }
}
