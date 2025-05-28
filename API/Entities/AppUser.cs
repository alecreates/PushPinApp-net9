using System;

namespace API.Entities;

// class represents a table in the DB
public class AppUser
{
    // each property represents a column in the DB
    public int Id { get; set; }
    public required string UserName { get; set; }
}
