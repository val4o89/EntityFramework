namespace BillsPaymentSystem.Contexts
{
    using Models;
    using Models.Billings;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class TablePerConcreteClass : DbContext
    {
        public TablePerConcreteClass()
            : base("TablePerConcreteClass")
        {
            
        }

        public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<BillingDetail> BillingDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillingDetail>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<BillingBankAccount>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("BankAccounts");
            });

            modelBuilder.Entity<BillingBankCard>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("BankCards");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}