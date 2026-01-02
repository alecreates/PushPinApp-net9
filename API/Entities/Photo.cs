using System;
using System.Text.Json.Serialization;

namespace API.Entities;

public class Photo
{
    public int Id { get; set; }
    public required string Url { get; set; }
    // Used for cloud
    public string? PublicId { get; set; }

    // Navigation properties bc has a relationship with Member
    // ONE-TO-MANY relationship because one member may have many photos

    [JsonIgnore]
    public Member Member { get; set; } = null!;
    public string MemberId { get; set; } = null!;
    
}