namespace HHS.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        public Course()
        {
            StudentGrade = new HashSet<StudentGrade>();
            Person = new HashSet<Person>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        public virtual OnlineCourse OnlineCourse { get; set; }

        public virtual OnsiteCourse OnsiteCourse { get; set; }

        public virtual ICollection<StudentGrade> StudentGrade { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
