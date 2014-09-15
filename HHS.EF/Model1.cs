namespace HHS.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<OfficeAssignment> OfficeAssignment { get; set; }
        public virtual DbSet<OnlineCourse> OnlineCourse { get; set; }
        public virtual DbSet<OnsiteCourse> OnsiteCourse { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<StudentGrade> StudentGrade { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasOptional(e => e.OnlineCourse)
                .WithRequired(e => e.Course);

            modelBuilder.Entity<Course>()
                .HasOptional(e => e.OnsiteCourse)
                .WithRequired(e => e.Course);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.StudentGrade)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Person)
                .WithMany(e => e.Course)
                .Map(m => m.ToTable("CourseInstructor").MapLeftKey("CourseID").MapRightKey("PersonID"));

            modelBuilder.Entity<Department>()
                .Property(e => e.Budget)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Course)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OfficeAssignment>()
                .Property(e => e.Timestamp)
                .IsFixedLength();

            modelBuilder.Entity<Person>()
                .HasOptional(e => e.OfficeAssignment)
                .WithRequired(e => e.Person);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.StudentGrade)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.StudentID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StudentGrade>()
                .Property(e => e.Grade)
                .HasPrecision(3, 2);
        }
    }
}
