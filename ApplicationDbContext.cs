using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<category> Categories { get; set; }
}
