namespace BillsPaymentSystem.Contexts
{
    using Models.Billings;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TablePerHierarchyContext : DbContext
    {
        public TablePerHierarchyContext()
            : base("TablePerHierarchyContext")
        {
        }

        public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<BillingDetail> BillingDetails { get; set; }
    }
}