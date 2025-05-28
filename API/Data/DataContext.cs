using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

// Options are passed in from services in Program.cs
public class DataContext(DbContextOptions options) : DbContext(options)
{
    // Table in database named Users, uses Id property from AppUser as primary key
    public DbSet<AppUser> Users { get; set; }

}
