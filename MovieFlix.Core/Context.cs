using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=MovieFlix.db");
    }

    public DbSet<Movie>? Movies { get; set; }
}