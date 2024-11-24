using Microsoft.EntityFrameworkCore;
using NexCart.Models;

public class NexCartDBContext : DbContext
{
    public NexCartDBContext() { }

    public NexCartDBContext(DbContextOptions<NexCartDBContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Default connection string for migrations
            optionsBuilder.UseSqlServer("Server=localhost;Database=NexCart;User Id=yourusername;Password=yourpassword;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Seller> Sellers { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductInventory> ProductInventories { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Payment> Payments { get; set; }
}

