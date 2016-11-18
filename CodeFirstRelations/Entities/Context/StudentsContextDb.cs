namespace Entities.Context
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class VechicleContect : DbContext
    {
        public VechicleContect()
            : base("StudentsContextDb")
        {

        }
        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Resourse> Resourses { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }

        public virtual IDbSet<Album> Albums { get; set; }

        public virtual IDbSet<Picture> Pictures { get; set; }

        public virtual IDbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasMany<Student>(x => x.Friends).WithMany()
                .Map(x => x.ToTable("Friends").MapLeftKey("Student").MapRightKey("Friend"));

            base.OnModelCreating(modelBuilder);
        }
    }
}