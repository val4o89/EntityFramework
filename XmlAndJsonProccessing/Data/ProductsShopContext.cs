namespace Data
{
    using Models.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductsShopContext : DbContext
    {
        public ProductsShopContext()
            : base("ProductsShopContext")
        {
        }

        public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(u => u.Friends)
                .WithMany()
                .Map(u =>
                {
                    u.MapLeftKey("UserId");
                    u.MapRightKey("FriendId");
                    u.ToTable("UsersFriends");
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}