namespace FinanceTracker.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Alimentação" },
                new Category { Id = 2, Name = "Transporte" },
                new Category { Id = 3, Name = "Saúde" },
                new Category { Id = 4, Name = "Educação" },
                new Category { Id = 5, Name = "Lazer" },
                new Category { Id = 6, Name = "Moradia" },
                new Category { Id = 7, Name = "Salário" },
                new Category { Id = 8, Name = "Freelance" },
                new Category { Id = 9, Name = "Investimentos" },
                new Category { Id = 10, Name = "Outros" }
            );
        }

    }
}