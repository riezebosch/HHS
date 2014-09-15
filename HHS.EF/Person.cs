namespace HHS.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        public Person()
        {
            StudentGrade = new HashSet<StudentGrade>();
            Course = new HashSet<Course>();
        }

        public int PersonID { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        public DateTime? HireDate { get; set; }

        public DateTime? EnrollmentDate { get; set; }

        public virtual OfficeAssignment OfficeAssignment { get; set; }

        public virtual ICollection<StudentGrade> StudentGrade { get; set; }

        public virtual ICollection<Course> Course { get; set; }
    }
}
