namespace API.Entities;

// class represents a table in the DB
public class AppUser 
{
    // each property represents a column in the DB
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string DisplayName { get; set; }
    public required string Email { get; set; }
    // need image URL here because it appears in nav bar after log in
    public string? ImageUrl { get; set; }
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }

    // Navigation Property
    public Member Member { get; set; } = null!;
}
