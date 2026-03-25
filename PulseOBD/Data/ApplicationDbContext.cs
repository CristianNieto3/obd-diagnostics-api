using Microsoft.EntityFrameworkCore;
using PulseOBD.Models;
namespace PulseOBD.Data;

public class ApplicationDbContext : DbContext {
    public DbSet<Vehicle> Vehicles { get; set;}

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }
}