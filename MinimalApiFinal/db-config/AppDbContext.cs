using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Usuario> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=nomeDoSeuBanco.db");
    }
}


