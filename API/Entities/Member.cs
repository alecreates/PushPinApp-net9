using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Entities;

public class Member
{
    public string Id { get; set; } = null!;
    public DateOnly DateOfBirth { get; set; }
    // Image Url needed here because it is frequently requested information in the app (efficiency)
    public string? ImageUrl { get; set; }
    public required string DisplayName { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime LastActive { get; set; } = DateTime.UtcNow;
    public required string Gender { get; set; }
    public string? Description { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }

    [JsonIgnore]
    public List<Photo> Photos { get; set; } = [];

    [JsonIgnore]
     // Navigation property, because AppUser and Member have entity relationship
    [ForeignKey(nameof(Id))]
    public AppUser User { get; set; } = null!;

}