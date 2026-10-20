using Microsoft.EntityFrameworkCore;

public class Olariu_Cristian_Lab2Context(DbContextOptions<Olariu_Cristian_Lab2Context> options) : DbContext(options)
{
    public DbSet<Olariu_Cristian_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Olariu_Cristian_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Olariu_Cristian_Lab2.Models.Author> Author { get; set; } = default!;
}
