using System.Data.Entity;
using Sana.WebShop.Model.Data;

namespace Sana.WebShop.Infrastructure.Sql
{
    public partial class WebShopDbContext : DbContext
    {
        public WebShopDbContext()
            : base("name=WebShopDbContext")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Product)
                .WithMany(e => e.Category)
                .Map(m => m.ToTable("ProductCategories").MapLeftKey("CategoryID").MapRightKey("ProductID"));

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetail)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>().HasKey(k=>k.SalesOrderDetailID)
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .ToTable("Product")
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetail)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);
        }
    }
}
